// HW Task 5
export const AlertForm = () => {
    const handleSubmit = (data) => {
        const input = data.get('input');
        alert(input);
    };
    return (
        <form action={handleSubmit}>
            <input type="text" name="input"/>
            <button type="submit">Go!</button>
        </form>
    );
}