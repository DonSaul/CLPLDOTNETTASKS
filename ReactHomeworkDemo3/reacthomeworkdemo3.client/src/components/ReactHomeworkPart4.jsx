import React from 'react';

const ListComponent = (props) => {
    const names = props.names;

    return (
        <ul>
            {names.map((name, index) => (
                <li key={index}>{name}</li>
            ))}
        </ul>
    );
};

export default ListComponent;