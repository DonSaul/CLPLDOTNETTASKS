import React, { useState } from "react";

export const StateChange = () => {
  const [message, setMessage] = useState("Click the button");

  const changeMessage = () => setMessage("The state has changed!");

  return (
    <div>
      <p>{message}</p>
      <button onClick={changeMessage}>Click Here</button>
    </div>
  );
};
