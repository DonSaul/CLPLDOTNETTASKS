# Homework 2: C# Console Application: Various Tasks

This C# Console Application is a comprehensive project that demonstrates basic C# concepts and functionalities. It includes several tasks like handling floating-point and integer inputs, working with enums and structs, and implementing utility functions.

## Features

1. **Float Range Check:** Reads three floating-point numbers and checks if they all belong to the range [-5, 5].

2. **Maximum and Minimum Finder:** Accepts three integer values and determines the maximum and minimum among them.

3. **HTTP Error Resolver:** Reads a numeric HTTP error code and outputs the corresponding error name using an enum.

4. **Dog Struct Handling:** Implements a `Dog` struct with properties for name, mark, and age. It reads values for a `Dog` instance and displays them.

5. **Utility Functions:** Includes utility functions for parsing float and integer arrays from user input.

## How to Run

1. Open the project in Visual Studio.
2. Press `Ctrl + F5` to run the program without debugging.
3. Follow the on-screen prompts to interact with the program.

## Prerequisites

- Microsoft Visual Studio (Recommended version: 2019 or later)
- .NET Framework (Recommended version: 4.7.2 or later)

## Usage

Each task is executed sequentially. The user is prompted to input data for each task, and the program outputs the results accordingly.

For example:
- For the float range check, input three floats separated by spaces.
- For the HTTP error resolver, input a numeric HTTP error code.

## Example prompt
```
Task #1:
----------------------------
Enter three float numbers separated by spaces (example: 3.14 -2.5 4):
24
Invalid input. Please enter 3 float numbers (example: 5 12 13)

Enter three float numbers separated by spaces (example: 3.14 -2.5 4):
4 5 2
Result: All numbers belong to the range [-5,5].

Task #2:
----------------------------
Enter three integers separated by spaces (example: 5 12 13):
4 2 4
Max: 4, Min: 2

Task #3:
----------------------------
Enter an HTTP Error number (e.g., 404, 500):
405
Result: The name of the error is: MethodNotAllowed

Task #4:
----------------------------
Enter dog's name, mark, and age:
Dog Name: Pancito
Dog Mark: German Shepherd
Dog Age: 5
Dog data:
Name: Pancito, Mark: German Shepherd, Age: 5

Many thanks for trying this program! Have a good day! Process Terminated.
```