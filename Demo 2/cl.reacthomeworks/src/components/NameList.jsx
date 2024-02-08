
export const NameList = ({ names = [] }) => {
  if (names.length === 0) {
    return <p>No names provided.</p>;
  }

  return (
    <ul>
      {names.map((name, index) => (
        <li key={index}>{name}</li>
      ))}
    </ul>
  );
};
