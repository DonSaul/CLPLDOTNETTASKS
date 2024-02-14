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
