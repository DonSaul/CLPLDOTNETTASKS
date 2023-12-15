## Overview
This project is designed to demonstrate various utility functions, ranging from basic arithmetic operations to string manipulations and input validations. It is structured into three main classes: `Solver`, `UserInteraction`, and `UserInputValidation`.

## Classes
![Class Diagram](Task-3-Class-Diagram.png "Class Diagram")

### 1. Solver

**Responsibility**: 
- Contains methods for performing specific operations or calculations as per the defined tasks. These tasks include arithmetic calculations, string manipulations, and logical operations.
- It acts as the core logic provider for the application, performing the required computations and returning results.

**Methods**:
- `CountDivisibleByThree(int a, int b)`: Counts integers divisible by 3 in a range.
- `PrintEverySecondChar(string str)`: Prints every second character of a string.
- `GetDrinkPrice(string drinkName)`: Returns the price of a specified drink.
- `CalculateAverage(List<int> numbers)`: Calculates the arithmetic average of a list of integers.
- `IsLeapYear(int year)`: Determines if a given year is a leap year.
- `SumOfDigits(int number)`: Calculates the sum of digits of an integer.
- `HasOnlyOddDigits(int number)`: Checks if an integer consists only of odd digits.

### 2. UserInteraction

**Responsibility**: 
- Handle all user interactions. It prompts the user for input, calls the appropriate methods from the `Solver` class, and displays the results.
- It acts as an interface between the user and the application's logic.

**Methods**:
- Methods corresponding to each task (`HandleDivisibleByThree`, `HandlePrintEverySecondChar`, etc.) which guide the user through the process of providing input and viewing results.

### 3. UserInputValidation

**Responsibility**: 
- Provide utility functions to validate and parse user input.
- It ensures that the inputs provided by users are in the correct format and are valid before they are processed by the `Solver` class. This helps in preventing runtime errors and exceptions.

**Methods**:
- `GetValidInteger()`: Validates and retrieves a valid integer input from the user.
- `GetValidString()`: Validates and retrieves a non-empty string input.
- `GetValidStringFromOptions(string[] options)`: Validates a string input against a set of allowed options.
- `GetPositiveIntegersSequence()`: Retrieves a sequence of positive integers from the user, stopping at a negative input.

## Example Prompt
![Class Diagram](Example-prompt.png "Example prompt")
```
-----------------------------------------------
Enter the first integer (a): 4
Enter the second integer (b): 20
Result: There are 5 integers divisible by 3 in the range [4..20].

Task 2: Print Every Second Character in a String
------------------------------------------------
Enter a string: Lorem ipsum dolor sit amet
Result: The second characters in the string are "oe pu oo i mt".

Task 3: Get Drink Price
------------------------
Enter the name of the drink (Options: coffee, tea, juice, water):
cofee
Invalid option. Please enter one of the following: coffee, tea, juice, water
coffee
Result: The price of Coffee is $2.

Task 4: Calculate Arithmetic Average of Positive Integers
----------------------------------------------------------
Enter positive integers (negative number to stop):
4
23
4
2
3
4
5
-2
Result: The arithmetic average of the entered numbers is 6.43.

Task 5: Check if a Year is a Leap Year
--------------------------------------
Enter a year:
2044
Result: The year 2044 is a leap year.

Task 6: Find Sum of Digits of an Integer
----------------------------------------
Enter an integer number:
2445
Result: The sum of the digits in the number 2445 is 15.

Task 7: Check if Integer Contains Only Odd Numbers
--------------------------------------------------
Enter an integer number:
243
Result: The number 243 does not contain only odd digits.

Many thanks for trying this program! Have a good day! Process Terminated.
```
---
*Note: This document provides a basic overview of the project structure and class responsibilities. For detailed implementation, refer to the source code.*

