/*
 * FormularioSimple.js: Componente que muestra un formulario simple con un campo de texto y un botón para enviarlo.
*/

import React, { useState } from 'react';
import { TextField, Button } from '@mui/material';
import Swal from 'sweetalert2';

function FormularioSimple() {
    const [inputValue, setInputValue] = useState('');

    const handleChange = (event) => {
        setInputValue(event.target.value);
    };

    const handleSubmit = (event) => {
        event.preventDefault(); // Prevenir el comportamiento por defecto del formulario
        // Mostrar alerta con SweetAlert2
        Swal.fire({
        title: 'Valor ingresado',
        text: inputValue,
        icon: 'info',
        confirmButtonText: 'Ok'
        });
        setInputValue(''); // Se limpia el campo de texto después de enviar
    };

    // Retornamos el FormularioSimple
    return (
        <form onSubmit={handleSubmit} style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', gap: '20px' }}>
        {/* Componentes para el formulario (Titulo, descripcion y campos) */}
        <h2>Tarea5: Formulario Simple</h2>
        <p>Por favor ingrese un texto o número en el formulario y el input de este será mostrado por una alerta.</p>
        <TextField
            label="Ingresa algo"
            variant="outlined"
            value={inputValue}
            onChange={handleChange}
            style={{ marginBottom: '20px' }}
        />
        {/* Botón para enviar el formulario y volver a Home*/}
        <Button variant="contained" color="secondary" href="/">
            Volver a Home
        </Button>
        <Button type="submit" variant="contained" color="primary">
            Enviar
        </Button>
        </form>
    );
}

export default FormularioSimple;
