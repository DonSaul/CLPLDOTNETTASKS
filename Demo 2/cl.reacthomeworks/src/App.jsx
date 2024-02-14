import React from "react";
import {Stack,Container} from 'react-bootstrap';

import {SimpleElement} from "./components/SimpleElement";
import {Greeting} from "./components/Greeting";
import {StateChange} from "./components/StateChange";
import {NameList} from "./components/NameList";
import {SimpleForm} from "./components/SimpleForm";
import { CustomCard } from "./components/CustomCard";
import { Footer } from "./components/Footer";

import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";

function App() {
  const names = ["Alice", "Bob", "Charlie", "Dana"];

  return (
    <div className="d-flex flex-column full-height">
      <div className="p-2 mb-2 header-background">
        <h1 className="text-white text-uppercase">
          CL. Project Lab: React Homeworks
        </h1>
      </div>

      <Container className="pb-3 mb-auto">
        <Stack gap={2}>
          <CustomCard title="Task 1">
            <SimpleElement />
          </CustomCard>

          <CustomCard title="Task 2">
            <Greeting name="React Developer" />
          </CustomCard>

          <CustomCard title="Task 3">
            <StateChange />
          </CustomCard>

          <CustomCard title="Task 4">
            <NameList names={names}></NameList>
          </CustomCard>

          <CustomCard title="Task 5">
            <SimpleForm />
          </CustomCard>
        </Stack>
      </Container>

      <Footer></Footer>
    </div>
  );
}

export default App;