# SoftServe ProjectLab CL 2023

En esta branch se encuentran las tareas realizadas por el alumno Guillermo Oliva.

Solo se suben los archivos .cs, .csproj y .sln, por tanto para ejecutar se debe utilizar los comandos:

`dotnet build`
`dotnet run`

## Tareas

### Tarea Git

Clase Git, 22-nov:

1. Inicializar un repositorio, agregar un archivo de texto y crear branches feature-a y feature-b
2. Cambiarse a feature-a y agregar una línea al archivo
3. Cambiarse a feature-b y agregar una línea al archivo, en una línea diferente que en el paso anterior
4. Cambiarse a main y hacer merge con feature-a
5. Intentar hacer merge con feature-b
6. Resolver conflictos y finalizar el merge

### Tarea 1

Clase Code Conventions, 23-nov (H1):

Create Console Application project in VS. In method Main() write code to solve the following tasks:
1. Define integer variable `a`. Read the value of `a` from console and calculate area and perimeter of a square with length `a`. Output obtained results.
2. Define string variable `name` and integer value `age`. Output question "What is your name?"; Read the value `name` and output next question: "How old are you,(`name`)?". Read `age` and write whole information.
3. Read double number `r` and calculate the length (l=2\*pi\*r), area (S=pi\*r\*r) and volume (4/3\*pi\*r\*r\*r) of a circle (sphere in the case of volume) with radius `r`.


### Tarea 2

Clase CLR, 24-nov (H2):

1. Read 3 float numbers and check if they all belong to the range [-5,5].
2. Read 3 integers and write the minimum and maximum value of them.
3. Read number of HTTP Error (400, 401, 402, ...) and write the name of this error. Declare enum HTTPError.
4. Declare struct `Dog` with fields `Name`, `Breed` and `Age`. Declare variable `myDog` of type `Dog` and read values for it. Output `myDog` into console. Declare method `ToString` in struct.



### Tarea 3

Clase Statements, 27-nov (T3):

1. Enter `a` and `b` are two integers. Calculate how many integers in the range [a..b] are divided by 3 without remainder.
2. Enter a character string. Print each second character.
3. Enter the name of a drink (coffee, tea, juice, water). Print the name of the drink and its price.
4. Enter a sequence of positive integers (to the first negative). Calculate the average of the entered numbers.
5. Check whether the entered year is a leap.
6. Find the sum of digits of the entered integer number.
7. Check whether the entered integer number contains only odd numbers.


### Tarea 4

Clase Regex, 29-nov (H4):

##### Part A
Use classes `Shape`, `Circle` and `Square`. Use Linq and string functions to complete next tasks:
1. Create list of type `Shape` and fill it with 6 different shapes (Circle and Square).
2. Find and write into the file shapes with area from range [10, 100]
3. Find and write into the file shapes which name contains the letter 'a'.
4. Find and remove from the list all shapes with perimeter less than 5. Write resulted list into Console.


##### Part B
Prepare a .txt file with a lot of text. Read each line into a string and store it in an array. Then, complete the next tasks:
1. Count and write the number of symbols in every line.
2. Find the longest and the shortest line.
3. Find and write only lines, which consist of word "var".


### Tarea 5

##### T8
1. Add two classes `Person` and `Staff` (use the presentation code).
2. Create two classes `Teacher` and `Developer`, derived from `Staff`. 
- Add field `subject` for class `Teacher`; 
- Add field `level` for class `Developer`; 
- Override method `Print()` for both classes.
3. In Main, specify a list of type `Person` and add objects of each type to it. Call for each item in the list method `Print()`.
4. Enter the person's name. If this name present in the list, print more information about this person.
5. Sort list by name, output to file.
6. Create a list of `Employees` and move only workers there. Sort them by salary.

##### H8

Create abstract class `Shape` with field `name` and property `Name`. 
- Add constructor with 1 parameter and abstract methods `Area()` and `Perimeter()`, which can return area and perimeter of shape.
- Create classes `Circle` and `Square` derived from `Shape` with field `radius` (for Circle) and `side` (for Square). Add necessary constructors and properties to these classes, override methods from abstract class `Shape`.
1. In Main() create list of `Shape`, then ask user to enter data of 10 different shapes.  Write `name`, `area` and `perimeter` of all shapes. 
2. Find shape with the largest perimeter and print its name. 
3. Sort shapes by area and print obtained list (Remember about `IComparable`)
