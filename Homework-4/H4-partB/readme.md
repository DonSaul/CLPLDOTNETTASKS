
# Homework 4 Part B - Text File Analysis

## Overview
This C# program is designed to read a text file and perform various analyses on its contents. It reads all lines from a specified text file into an array of strings, where each array item represents one line from the file. The program then performs the following tasks:
- Counts and displays the number of symbols (characters) in every line.
- Identifies the longest and shortest lines in the file.
- Finds and displays lines that contain the word "var".

## Requirements
- .NET SDK (compatible with the version used in the project)
- A text file named `textfile.txt` placed in the project's `bin` directory

## Instructions for Running the Program
1. Clone or download the project from the repository.
2. Ensure that you have a text file named `textfile.txt` in the `bin\Debug\netX.X` directory of the project (where `netX.X` is the target .NET version).
3. Navigate to the project directory using a command prompt or terminal.
4. Execute the program using the command `dotnet run`.

## User Prompt Example
```
------------------------------------------------------------
Line                                               | Symbols
------------------------------------------------------------
Welcome to Homework 4!                             |      22
This line is short.                                |      19
var usage in a simple sentence.                    |      31
The quick brown fox jumps over the lazy dog.       |      44
1234567890!@#$%^&*()_+[];'./,\<>?:"{}|=            |      39
Special characters: ~`!@#$%^&*()-_+={}[]|\:;"'<... |      52
Here is a line with a variable declaration: int... |      61
Some lines are longer than others, and this is ... |     142
Short.                                             |       6
A line with multiple var var var.                  |      33
End of file!                                       |      12

Longest Line:
Some lines are longer than others, and this is one...

Shortest Line:
Short.

Lines Containing 'var':
- var usage in a simple sentence.
- Here is a line with a variable declaration: int...
- A line with multiple var var var.
```
