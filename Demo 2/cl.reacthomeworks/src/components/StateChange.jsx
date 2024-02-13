import React, { useState } from "react";
import Button from 'react-bootstrap/Button';


export const StateChange = () => {
  const [message, setMessage] = useState("Click the button to Change State");

  const changeMessage = () => setMessage("The state has changed!");

  return (
    <div>
      <p>{message}</p>
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
