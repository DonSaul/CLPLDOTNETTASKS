import React, { useState } from "react";
import SimpleElement from "./SimpleElement";
import Greeting from "./Greeting";
import NamesList from "./NamesList";
import Form from "./Form";

const App: React.FC = () => {
    const [count, setCount] = useState(0);

    const handleClick = () => {
        setCount(count + 1);
    };

    const names = ["Juan", "Maria", "Pedro"];

    return (
        <div>
            <SimpleElement />
            <Greeting name="Juan" />
            <Greeting name="Saul" />
            <h1>The counter is {count}</h1>
            <button onClick={handleClick}>Click me!</button>
            <NamesList names={names} />
            <Form />
        </div>
    );
};

export default App;