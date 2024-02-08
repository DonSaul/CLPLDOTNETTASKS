import React, { useState } from "react";

export const SimpleForm = () => {
  const [value, setValue] = useState("");

  const handleChange = (event) => setValue(event.target.value);

  const handleSubmit = (event) => {
    alert(`Entered value: ${value}`);
    event.preventDefault();
    setValue("");
  };

  return (
    <form onSubmit={handleSubmit}>
      <input type="text" value={value} onChange={handleChange} />
      <button type="submit">Submit</button>
    </form>
  );
};
