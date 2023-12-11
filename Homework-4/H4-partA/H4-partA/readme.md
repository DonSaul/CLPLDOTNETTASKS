
# Homework 4 - part A

## Purpose

This project is designed to demonstrate object-oriented programming (OOP) concepts and practices in C#. It involves creating a simple console application that manipulates various geometric shapes. The primary purpose is to showcase the use of abstract classes, inheritance, file operations, LINQ queries, and separation of concerns within a structured project.

## Instructions for Use

### Running the Application

1. **Starting the Application**: Run the application through your IDE or the command line, depending on your setup.

2. **Interacting with the Application**: The application will execute a series of operations on predefined geometric shapes (circles and squares), displaying results in the console.

### Understanding the Output

- **Original List Display**: Initially, the application displays a list of predefined shapes with their properties.
- **Operations Performed**: The application then performs various operations like filtering shapes based on certain criteria.
- **Results Display**: After each operation, the results are displayed in the console.

### Generated Files

- **Files Location**: The application generates two files based on the operations performed. You can find these files in the application's executing directory, typically where the `.exe` file is located if running a compiled version.
- **File Details**:
  - `ShapesWithAreaInRange.txt`: Contains shapes filtered based on a specific area range.
  - `ShapesWithNameContainingA.txt`: Contains shapes whose names include the letter 'a'.

## User Prompt Example

```
Original List:
--------------------------------------------------------------------------
   Type       | Name            | Radius/Side   | Area   | Perimeter
--------------------------------------------------------------------------
1. Circle     | Custom Circle   | Radius: 1.00 | 3.14   | 6.28
2. Circle     | Circle          | Radius: 3.00 | 28.27  | 18.85
3. Square     | Custom Square   | Side: 1.00   | 1      | 4
4. Square     | aBig Square     | Side: 1.00   | 1      | 4
5. Square     | a               | Side: 2.00   | 4      | 8
6. Square     | Normal Square   | Side: 0.50   | 0.25   | 2
--------------------------------------------------------------------------

Removing shapes with perimeter less than 5... Wait a moment please

Result:
--------------------------------------------------------------------------
   Type       | Name            | Radius/Side   | Area   | Perimeter
--------------------------------------------------------------------------
1. Circle     | Custom Circle   | Radius: 1.00 | 3.14   | 6.28
2. Circle     | Circle          | Radius: 3.00 | 28.27  | 18.85
3. Square     | a               | Side: 2.00   | 4      | 8
--------------------------------------------------------------------------

Many thanks for trying this program. Process terminated
```

## Class Diagram Explanation

The class diagram for this project represents the structure and relationships of the classes involved.

- **Shape**: An abstract class representing a general geometric shape. It includes properties like `Name` and abstract methods like `Area()` and `Perimeter()`.
- **Circle/Square**: Concrete implementations of the `Shape` class, providing specific logic for area and perimeter calculations.
- **Solver**: A utility class providing methods for manipulating collections of shapes, such as filtering.
- **UserDisplay**: Responsible for handling all user interface operations, including displaying shape information and messages.
- **SolutionSolver**: Contains specific methods required by the project's objectives, like writing certain shapes to files based on criteria.
- **Program**: The entry point of the application, orchestrating the use of other classes to achieve the application's goals.

The relationships are primarily inheritance (Circle and Square inheriting from Shape) and utilization (Program using Solver, UserDisplay, and SolutionSolver to execute operations).

