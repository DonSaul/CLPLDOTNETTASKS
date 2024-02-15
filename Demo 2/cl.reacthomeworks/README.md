# CL.REACTHOMEWORKS
This repository contains solutions to a series of React homework assignments designed to reinforce fundamental concepts of React development, including component creation, props handling, state management, list rendering, and form handling.

## Requirements

To run these components, ensure you have the following installed:
- Node.js (preferably the latest LTS version)
- A package manager like npm or Yarn
- A code editor such as VS Code


## Homework Assignments

### 1. Rendering a Simple Element
Create a component that renders a simple JSX element, such as an `<h1>` with a static message.

#### Solution
```jsx
function SimpleElement() {
  return <h1>Hello, welcome to React!</h1>;
}
```
### 2. Using Props
Create a component that accepts a name prop and renders a greeting message using that prop.
#### Solution
```jsx
export const Greeting = ({ name }) => {
  return <h1>Hello, {name}!</h1>;
};
```

### 3. State Management
Create a component with a button. Clicking the button should change its state and display a different message.

#### Solution
```jsx
import React, { useState } from "react";
import Button from 'react-bootstrap/Button';

export const StateChange = () => {
  const [message, setMessage] = useState("Click the button to Change State");
  const [clickCount, setClickCount] = useState(0);

  const changeMessage = () => {
    setMessage("The state has changed!");
    setClickCount(clickCount + 1);
  };
  return (
    <div>
      <p>
        {message}
        {clickCount !== 0 && 
          <span>{` Clicked times: ${clickCount}`}</span>
        }
      </p>
      <Button
        variant="dark"
        className="border-0 rounded-0"
        type="submit"
        onClick={changeMessage}
      >
        Click Here
      </Button>
    </div>
  );
};
```

### 4. Iterating Over a List
Create a component that receives a list of names as a prop and displays each name in an unordered list.

#### Solution
```jsx
import ListGroup from 'react-bootstrap/ListGroup';

export const NameList = ({ names = [] }) => {
  if (names.length === 0) {
    return <p>No names provided.</p>;
  }

  return (
    <ListGroup>
      {names.map((name, index) => (
        <ListGroup.Item  
          key={index}
          className='border-0 p-1'
        >{name}</ListGroup.Item>
      ))}
    </ListGroup>
  );
};
```

### 5. Simple Form
Create a component that has a form with a text input field and a submit button. Clicking the button should display an alert with the value entered in the text field.

#### Solution
```jsx
import React, { useState } from "react";
import Button from 'react-bootstrap/Button'
import Form from 'react-bootstrap/Form';

export const SimpleForm = () => {
  const [value, setValue] = useState("");

  const handleChange = (event) => setValue(event.target.value);

  const handleSubmit = (event) => {
    alert(`Entered value: ${value}`);
    event.preventDefault();
    setValue("");
  };

  return (
    <Form onSubmit={handleSubmit}>  
      <Form.Group className="mb-3">
        <Form.Label></Form.Label>
        <Form.Control 
          type="text" 
          value={value}
          onChange={handleChange} 
          placeholder="Enter some text" size="md"
          className = "shadow-none"
          >
        </Form.Control>
      </Form.Group>  
      <Button variant="dark" className="border-0 rounded-0" type="submit">Submit</Button>
    </Form>
  );
};

```
## User Interface
[![Click here to see the video](link-to-thumbnail-image)](art/React_Homeworks_ClaudioRain.mp4)

