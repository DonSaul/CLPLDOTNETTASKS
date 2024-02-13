import { useState } from "react";
import "./App.css";
import Greeting from "./components/Greeting";
import Toggle from "./components/Toggle";
import UList from "./components/UList";
import Form from "./components/Form";

function App() {
  const [count, setCount] = useState(0);

  const messages = [
    'Hey, you, you\'re finally awake',
    'The archer class is really made of archers',
    'People die when they are killed',
    'I am the bone of my sword',
    're:zero is just an isekai soap opera'
  ];

  return (
    <>
      <h1>Esta es la tarea de React y este header es el Problema 1</h1>
      <p>
        Todos los estilos vienen en el template de la aplicación (pero tuvieron
        que ser modificados).
      </p>

      <h2>Problema 2:</h2>
      <Greeting name="Juan" />

      <h2>Problema 3:</h2>
      <Toggle messages={messages} />

      <h2>Problema 4:</h2>
      <UList names={messages} />

      <h2>Problema 5:</h2>
      <Form></Form>
    </>
  );
}

export default App;
