import React from 'react';
import SimpleElement from './components/ReactHomeworkPart1';
import Greeting from './components/ReactHomeworkPart2';
import StateComponent from './components/ReactHomeworkPart3';
import ListComponent from './components/ReactHomeworkPart4';
import FormComponent from './components/ReactHomeworkPart5';

const App = () => {
    return (
        <div>
            <h1> React HomeWork</h1>
            <hr /> 
            <h2> Part 1: </h2>
            <SimpleElement />
            <hr /> 
            <h2> Part 2: </h2>
            <Greeting name="Stephen King" />
            <hr />
            <h2> Part 3: </h2>
            <StateComponent />
            <hr />
            <h2> Part 4: </h2>
            <ListComponent names={['Bart', 'Lisa', 'Homer' , 'Maggie','Marge']} />
            <hr />
            <h2> Part 5: </h2>
            <FormComponent />
        </div>
    );
};

export default App;