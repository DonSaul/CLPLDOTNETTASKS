// Importaciones de librerias
import React from 'react';
import { Link as RouterLink } from 'react-router-dom';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import Container from '@mui/material/Container';
import Box from '@mui/material/Box';

function Home() {
    // Retornamos la página principal con los botones de redirección para cada tarea
    return (
        <Container>
            {/* Título de la página */}
            <Typography variant="h2" gutterBottom>
                Homework React - Francisco Munoz
            </Typography>
            {/* Botones de redirección anidados en una Box */}
            <Box sx={{ display: 'flex', flexDirection: 'column', gap: 2 }}>
                <Button variant="contained" component={RouterLink} to="/tarea1">
                Tarea 1 - Renderizar un elemento simple
                </Button>
                <Button variant="contained" component={RouterLink} to="/tarea2">
                Tarea 2 - Uso de props (Enviando "Usuario" como nombre)
                </Button>
                <Button variant="contained" component={RouterLink} to="/tarea3">
                    Tarea 3 - Manejo de estado
                </Button>
                <Button variant="contained" component={RouterLink} to="/tarea4">
                    Tarea 4 - Iterar sobre una lista
                </Button>
                <Button variant="contained" component={RouterLink} to="/tarea5">
                    Tarea 5 - Formulario simple
                </Button>
            </Box>
        </Container>
    );
}

export default Home;
