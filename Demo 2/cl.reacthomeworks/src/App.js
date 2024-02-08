import React from "react";
import logo from "./logo.svg";
import "./App.css";
import {SimpleElement} from "./components/SimpleElement";
import {Greeting} from "./components/Greeting";
import {StateChange} from "./components/StateChange";
import {NameList} from "./components/NameList";
import {SimpleForm} from "./components/SimpleForm";

function App() {
  // Example list of names for NameList component
  const names = ["Alice", "Bob", "Charlie", "Dana"];

  return (
    <div className="App">
      <header className="App-header">
        <SimpleElement />
        <Greeting name="React Developer" />
        <StateChange></StateChange>
        <NameList names={names}></NameList>
        <SimpleForm></SimpleForm>
      </header>
    </div>
  );
}

export default App;