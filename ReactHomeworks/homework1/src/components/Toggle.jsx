import { useState } from "react";

const Toggle = ({ messages }) => {
  const [message, setMessage] = useState("Click this button to see it change!");

  const onClick = () => {
    setMessage(messages[Math.floor(Math.random() * 5)]);
  };

  return <button onClick={onClick}>{message}</button>;
};

export default Toggle;
