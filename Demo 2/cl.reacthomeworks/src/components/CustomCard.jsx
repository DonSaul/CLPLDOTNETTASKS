import React from "react";
import Card from "react-bootstrap/Card";

export const CustomCard = ({title, children}) => (
    <Card className="rounded-0 border-0 shadow">
        <Card.Body>
            <Card.Title  className="text-uppercase fs-6">{title}</Card.Title>
            {children}
        </Card.Body>
    </Card>
);