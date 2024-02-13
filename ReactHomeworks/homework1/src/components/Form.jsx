import { useState } from "react";

const Form = () => {
  const [input, setInput] = useState("");

  return (
    <form onSubmit={() => alert(input)}>
      <input onChange={(e) => setInput(e.target.value)} required/>
      <button type="submit">Submit</button>
    </form>
  );
};

export default Form;
