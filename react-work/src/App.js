import './App.css';
import React, { useState } from 'react';

const SimpleElement = () => {
  return <h1>Mensaje estático</h1>;
};

const Greeting = ({ nombre }) => {
  return <p>Hola, {nombre}!</p>;
};

const StateComponent = () => {
  const [mensaje, setMensaje] = useState('Mensaje inicial');

  const cambiarMensaje = () => {
    setMensaje('Mensaje cambiado');
  };

  return (
    <div>
      <p>{mensaje}</p>
      <button onClick={cambiarMensaje}>Cambiar mensaje</button>
    </div>
  );
};

const NameList = ({ nombres }) => {
  return (
    <ul>
      {nombres.map((nombre, index) => (
        <li key={index}>{nombre}</li>
      ))}
    </ul>
  );
};

const SimpleForm = () => {
  const [inputValue, setInputValue] = useState('');

  const handleSubmit = (event) => {
    event.preventDefault();
    alert(`Valor ingresado: ${inputValue}`);
    setInputValue('');
  };

  const handleChange = (event) => {
    setInputValue(event.target.value);
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        type="text"
        value={inputValue}
        onChange={handleChange}
        placeholder="Ingrese un valor"
      />
      <button type="submit">Enviar</button>
    </form>
  );
};

const App = () => {
  const nombres = ['Juan', 'María', 'Carlos', 'Diego'];

  return (
    <div>
      <SimpleElement />
      <Greeting nombre="Usuario React" />
      <StateComponent />
      <NameList nombres={nombres} />
      <SimpleForm />
    </div>
  );
}

export default App;
