# SoftServe | Homework 1: Geometric Calculation and User Interaction

## Overview
This C# program performs various calculations related to squares and circles. It is designed to:
1. Calculate the area and perimeter of a square given its side length.
2. Ask for the user's name and age and display this information.
3. Calculate the circumference, area, and volume of a sphere given the radius of a circle.

## Features
- **User Input Validation:** Ensures that all numerical inputs are positive and in the correct format.
- **Error Handling:** Gracefully handles unexpected inputs or errors during execution.
- **Precision Control:** Results are rounded to two decimal places for better readability.

A notable feature enhancing its user-friendliness:

- **User-Friendly Guidance System:** Features an intuitive guidance system that assists users through each step with clear instructions and feedback. This ensures an accessible and smooth experience for all users, regardless of their familiarity with geometric concepts or console applications.

## Requirements
- .NET Framework or .NET Core
- A compatible C# compiler

## How to Run
1. **Compile the Program:**
   - Use a C# compiler to compile the program. If using the command line, navigate to the program directory and run: `csc Program.cs`.
2. **Execute the Program:**
   - After compilation, run the program using: `Program.exe` in the command line.

## Usage Instructions
1. **Square Calculations:**
   - Enter the length of a side of the square when prompted.
2. **User Information:**
   - Enter your name and age when prompted. 
3. **Circle Calculations:**
   - Enter the radius of a circle when prompted.
4. **Intuitive User Interface:** 
    Designed with a focus on user-centric interaction, making it engaging and straightforward for users of all technical backgrounds.


## Example prompt
```
Task 1: Square Calculations
----------------------------
Enter the side length of the square(e.g., 15.6):
400
Area of Square: 160,000.00
Perimeter of Square: 1,600.00


Task 2: User Information
----------------------------
What is your name?
John
How old are you, John?
34
Confirmed! Name: John, Age: 34


Task 3: Circle Calculations
----------------------------
Enter the radius of the circle (e.g., 3.14):
-3
Please enter a positive number. For example, 15.75.
Enter the radius of the circle (e.g., 3.14):
400
Length of Circle: 2,513.27
Area of Circle: 502,654.82
Volume of Sphere: 268,082,573.11


All calculations complete!
Many thanks for trying this program! Have a good day! Process Terminated.
```
