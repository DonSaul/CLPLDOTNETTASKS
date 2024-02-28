# Task7

This program performs three main tasks related to reading and writing files and directories.

## Requirements

### Requirement 1

This requirement reads the content of the 'data.txt' file in the Documents folder and writes it to 'rez.txt' in the current directory.

### Requirement 2

This requirement explores the C:\\ directory up to a specified maximum depth and displays a maximum number of folders per depth level in 'DirectoryC.txt'.

### Requirement 3

This requirement searches for all .txt files in D:\\ and displays their content in the console.

## Special Features

This program offers the ability to customize certain aspects of its operation. These features and how you can modify them are described below:

### Change the maximum exploration depth of directories

In Requirement 2, the program explores the C:\\ directory up to a maximum depth. This depth is set with the `maxDepth` variable. You can change this value to adjust the exploration depth. For example, if you want to explore up to 3 levels deep, you can change the corresponding line of code to `int maxDepth = 3;`.

### Change the maximum number of folders to display

Also in Requirement 2, the program displays a maximum number of folders per depth level. This number is set with the `maxFoldersToShow` variable. You can change this value to adjust the number of folders displayed. For example, if you want to display up to 10 folders per depth level, you can change the corresponding line of code to `int maxFoldersToShow = 10;`.

### Show all folders

By default, the program only displays a limited number of folders per depth level. However, you can change this to display all folders. To do this, change the `showAllFolders` parameter value to `true` in the `ExploreDirectory` function call. For example: `ExploreDirectory(@"C:\", info, 0, maxDepth, maxFoldersToShow, showAllFolders: true);`.

## How to Use

1. Clone this repository to your local machine.
2. Open the project in Visual Studio.
3. Make sure you have the 'data.txt' file in your Documents folder and some .txt files in D:\\ to test all functionalities.
4. Run the program.

## Error Handling

The program is designed to handle various types of errors, including:

- File not found
- Error reading or writing the file
- Access denied to a folder or subfolder
- Subfolder path too long
- Directory not found
- Error reading a file or directory

When an error occurs, a message is displayed in the console and, in some cases, the error is written to a file.
