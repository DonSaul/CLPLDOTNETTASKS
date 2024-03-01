import React, { useState } from 'react';

const StateComponent = () => {
    const [message, setMessage] = useState('Initial message');

    const changeMessage = () => {
        setMessage('The message was changed after the click!');
    };

    return (
        <div>
            <p>{message}</p>
            <button onClick={changeMessage}>Click me to change the message</button>
        </div>
    );
};

export default StateComponent;