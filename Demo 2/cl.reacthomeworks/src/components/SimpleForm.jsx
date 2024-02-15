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
