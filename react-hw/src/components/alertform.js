// HW Task 5
export const AlertForm = () => {
    const handleSubmit = (e) => {
        e.preventDefault();
        alert(e.target.input.value);
    };
    return (
        <form onSubmit={handleSubmit}>
            <input type="text" name="input"/>
            <button type="submit">Go!</button>
        </form>
    );
}