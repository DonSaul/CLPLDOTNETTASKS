// Importación de estilo para App.js
import './App.css';

// Importaciones componentes tarea
import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from './components/Home'; // Importamos el componente Home: Será la página principal.
import Tarea1 from './components/Tarea1'; // Importamos el componente Tarea1: Contiene la renderizacion de un componente simple.
import Saludo from './components/Saludo'; // Importamos el componente Saludo Equivalente a TAREA2
import Tarea3 from './components/Tarea3'; // Importamos el componente Tarea3: Contiene el manejo de estado.
import Tarea4 from './components/Tarea4'; // Importamos el componente Tarea4: Contiene la iteración sobre una lista.
import FormularioSimple from './components/FormularioSimple'; // Importamos el componente FormularioSimple: Contiene un formulario simple.

function App() {
  // Retornamos el Router con las rutas de la tarea de React
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/tarea1" element={<Tarea1 />} />
        <Route path="/tarea2" element={<Saludo nombre="Usuario" />} />
        <Route path="/tarea3" element={<Tarea3 />} />
        <Route path="/tarea4" element={<Tarea4 />} />
        <Route path='/tarea5' element={<FormularioSimple/>} />
      </Routes>
    </Router>
  );
}

export default App;
