// Componente que sera usado tanto en el item2 como en el item3
// A través de este componente, se mostrará un saludo con el nombre recibido desde el boton del Home con el valor "Usuario"

import React from 'react';

function Saludo({ nombre }) {
    return <h2>Hola, {nombre}!</h2>;
}

export default Saludo;
