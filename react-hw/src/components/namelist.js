import { NameDecor } from "./namedecor";

// HW Tak 4
export const NameList = props => (
    <ul>
        {props.list.map(name => (<li><NameDecor nombre={name}/></li>))}
    </ul>
)