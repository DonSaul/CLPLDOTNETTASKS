/*
*   ListaDeNombres.js: Componente que recibe un arreglo de nombres y los muestra en una lista.
*/

import React from 'react';
import { Box } from '@mui/material';

function ListaDeNombres({ nombres }) {
    return (
        <Box component="ul" sx={{ listStyle: 'none', padding: 0 }}>
        {nombres.map((nombre, index) => (
            <Box component="li" key={index} sx={{ marginBottom: 1 }}>
            {nombre}
            </Box>
        ))}
        </Box>
    );
}

export default ListaDeNombres;
