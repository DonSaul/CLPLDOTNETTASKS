
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
