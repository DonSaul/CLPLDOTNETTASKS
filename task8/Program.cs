//**Para utilizar las librerias de Entity Framework Core**
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //Declararemos una lista de personas ya sean Developers o Teachers
        List<Person> persons = new List<Person>()
        {
            //**Aquí es donde se inicializan los objetos de las clases que heredan de Person**
            new Developer("John", 2000, "Junior"),
            new Developer("Jane", 2500, "Senior"),
            new Developer("Francisco", 2000, "Junior"),
            new Developer("Jorge", 2500, "Senior"),
            new Developer("Javier", 2000, "Junior"),
            new Teacher("Jack", 1200, "Maths"),
            new Teacher("Jill", 1400, "English"),
            new Teacher("Andres", 1200, "Maths"),
            new Teacher("Juan", 1400, "English"),
            new Teacher("Jose", 1200, "Maths"),
            new Student("Ana", "S001"),
            new Student("Luis", "S002"),
            new Student("Maria", "S003"),
        };

        //**Imprimimos los datos de la lista a través de un foreach**
        foreach (Person person in persons)
        {
            //Método que imprime los datos de los teacher o developer heredado de la clase Person
            person.Print();
        }
        Console.WriteLine("---------------------------------------");
        //**Buscaremos a traves de un nombre de un teacher o developer si existe en la lista**
        //? SI este existe, devolvemos su información.
        //!! SI no existe, devolvemos un mensaje indicando que la persona no existe en esa lista.
        Console.WriteLine("Write here the name of the Developer or Teacher you want to search: ");
        //Leemos el nombre que el usuario quiere buscar por consola.
        string name = Console.ReadLine();
        // Busca en la lista de personas si existe el nombre que el usuario ingresó.
        Person foundPerson = persons.FirstOrDefault(p => p.Name == name);
        //Si la persona existe, imprimimos su información.
        if (foundPerson != null)
        {
            foundPerson.Print();
        }
        else
        {
            Console.WriteLine("The person you are looking for does not exist in this list!!.");
        }

        Console.WriteLine("---------------------------------------");
        //** Ordenaremos la lista de personas por nombre**
        //? Para esto, utilizaremos el método OrderBy de LINQ
        Console.WriteLine("List of persons ordered by salary: ");
        //!! Este método recibe como parámetro una función que recibe como parámetro una persona y devuelve su nombre.
        //!! El método OrderBy devuelve una lista de personas ordenadas por nombre.
        // Ordena la lista de personas por nombre
        List<Person> orderedPersons = persons.OrderBy(p => p.Name).ToList();

        // Escribe la lista de personas ordenadas en un archivo
        File.WriteAllLines("persons.txt", orderedPersons.Select(p => p.Name).ToArray());

        // Crea una lista de empleados y mueve solo los trabajadores allí
        List<Staff> employees = persons.OfType<Staff>().ToList();

        // Ordena los empleados por salario
        List<Staff> orderedEmployees = employees.OrderBy(s => s.Salary).ToList();

        // Imprime la lista de empleados ordenada
        foreach (Staff employee in orderedEmployees)
        {
            employee.Print();
        }
    }
}
