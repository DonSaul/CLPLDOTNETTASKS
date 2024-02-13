// Imports
// Importar React y librerías de Material-UI
import React, { useState } from 'react';
import Saludo from './Saludo';
import { TextField, Button, Box } from '@mui/material';

// Componente Tarea3
function Tarea3() {
    const [nombre, setNombre] = useState('');
    const [nombreParaSaludo, setNombreParaSaludo] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();
        setNombreParaSaludo(nombre); // Actualiza el estado que se pasa a Saludo solo cuando se envía el formulario
    };

    const handleChange = (e) => {
        const valor = e.target.value;
        const regex = /^[A-Za-zñÑ]+$/; // Expresión regular para letras mayúsculas, minúsculas y la ñ

        if (valor === '' || regex.test(valor)) { // Permite campo vacío o que cumpla con la expresión regular
            setNombre(valor);
        }
    };


    return (
        // "Formulario" con un campo de texto y un botón que actualice el estado
        <Box
            component="form"
            sx={{
                '& .MuiTextField-root': { m: 1, width: '25ch' },
            }}
            noValidate
            autoComplete="off"
            onSubmit={handleSubmit}
        >
            <TextField
                label="Ingresa tu nombre"
                variant="outlined"
                value={nombre}
                onChange={handleChange} // para usar handleChange
            />

            <Button type="submit" variant="contained" sx={{ mt: 3, ml: 1 }}>
                Actualizar Saludo
            </Button>

            {/* Saludo que se actualiza con el estado */}
            <Saludo nombre={nombreParaSaludo} />
        </Box>
    );
}

export default Tarea3;
