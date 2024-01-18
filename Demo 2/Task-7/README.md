# Task 7 : Working with Files in C#
This project is a C# program designed to perform file and directory reading 
and writing operations. It can read data from a text file, write to another, 
list detailed information about files and directories in a specific directory, 
and display the contents of text files in a given location.

## Features
- **File Reading and Writing**: Reads data from a `data.txt` file and writes it to `rez.txt`.
- **Listing Files and Directories**: Generates a file with detailed information (name, type, size) about all files and directories in a specified directory.
- **Displaying Text File Contents**: Displays the content of all `.txt` files in a specific directory.
- **Exception Handling**: Captures and handles appropriate exceptions such as `FileNotFoundException`, `IOException`, `UnauthorizedAccessException`, and other general exceptions.

## Requirements
- .NET Core or .NET Framework (depending on your development environment).
- Access to system directories and files for reading/writing.

## Example Prompt
```
Task 1:
--------------------------
Reading data from: C:\Users\Claudio\Desktop/FilesTest/data.txt
Wait a moment please...
Writing complete. You can find the data in: C:\Users\Claudio\rez.txt

Task 2:
--------------------------
Writing info about files and directories in C:\ into C:\Users\Claudio\DirectoryC.txt
Wait a moment please...
Done! You can find the file at: C:\Users\Claudio\DirectoryC.txt

Task 3:
--------------------------
Inspecting directory: D:\
4 files found
File 1 info:
Name: "arnold_schwarzenegger_fun_facts.txt"
Content:
Fun Facts about Arnold Schwarzenegger:

1. Arnold won the Mr. Olympia title seven times.
2. Emigrated to the U.S. from Austria at 21.
3. Started weight training at 15.
4. California Governor from 2003-2011.
5. Famous for action films like the Terminator series.
6. Holds a business and economics degree from the University of Wisconsin.

File 2 info:
Name: "micro_story_1.txt"
Content:
"When I Woke Up, The Dinosaur Was Still There"
- by Augusto Monterroso

File 3 info:
Name: "micro_story_2.txt"
Content:
"For sale: baby shoes, never worn"
- Often attributed to Ernest Hemingway.

File 4 info:
Name: "micro_story_3.txt"
Content:
"The last man on Earth sat alone in a room. There was a knock on the door..."
- Often attributed to Frederick Brown.

Many thanks for trying this program! Have a good day! Process Terminated.
```