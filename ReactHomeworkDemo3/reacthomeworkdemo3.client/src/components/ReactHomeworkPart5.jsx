import React, { useState } from 'react';

const FormComponent = () => {
    const [inputValue, setInputValue] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();
        alert('Entered value: ' + inputValue);
    };

    const handleChange = (e) => {
        setInputValue(e.target.value);
    };

    return (
        <form onSubmit={handleSubmit}>
            <input
                type="text"
                value={inputValue}
                onChange={handleChange}
                placeholder="Enter a value"
            />
            <button type="submit">Submit</button>
        </form>
    );
};

export default FormComponent;