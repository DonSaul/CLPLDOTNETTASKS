interface GreetingProps {
    name: string;
}

const Greeting: React.FC<GreetingProps> = ({ name }) => {
    return <h1>Hi {name}!</h1>;
};

export default Greeting;