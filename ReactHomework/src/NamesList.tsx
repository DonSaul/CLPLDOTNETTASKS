const NamesList: React.FC<{ names: string[] }> = ({ names }) => {
    return (
        <ul>
            {names.map((name) => (
                <li key={name}>{name}</li>
            ))}
        </ul>
    );
};

export default NamesList;