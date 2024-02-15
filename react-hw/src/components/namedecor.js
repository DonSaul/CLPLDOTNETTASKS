import { useState } from "react"

// HW Task 2
export const NameDecor = (props) => {
    const [isVisible, setIsVisible] = useState(false)
    return (
        <>
        <button onClick={() => setIsVisible(!isVisible)}>{isVisible ? "Show me" : "Hide from me"} this name!</button>
        <p>{isVisible ? props.nombre : "Name is hidden!"}</p>{/* HW Task 3 */}
        </>
    )
}