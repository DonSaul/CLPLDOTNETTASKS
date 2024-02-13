import React from 'react'

const UList = ({names}) => {
  return (
    <ul>
      {names.map((name, index) => {
        return <li key={index}>{name}</li>
      })}
    </ul>
  )
}

export default UList