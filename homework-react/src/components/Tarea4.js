import React from 'react';
import ListaDeNombres from './ListaDeNombres';
import { Box, Typography } from '@mui/material';
function Tarea4() {
    const nombres = ['Carlos', 'Luisa', 'Fernando', 'Ana']; // Lista de nombres predefinidas que le enviaremos al componente ListaDeNombres.js
    return (
        <Box>
            <Typography variant="h2">Lista de Nombres</Typography>
            <ListaDeNombres nombres={nombres} />
        </Box>
    );
}

export default Tarea4;
