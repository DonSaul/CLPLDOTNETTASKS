using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("Alice"),
            new Staff("Bob", 50000),
            new Teacher("Charlie", 70000, "Mathematics"),
            new Developer("Diana", 90000, "Senior")
            // Add other Person, Staff, Teacher, Developer objects as needed
        };

        // Print all people
        foreach (var person in people)
        {
            person.Print();
        }

        // Search and print person by name
        Console.Write("Enter the person's name: ");
        string inputName = Console.ReadLine();
        SearchAndPrintPersonByName(people, inputName);

        // Sort people by name and write to file
        string peopleFilePath = "sorted_people.txt";
        SortPeopleByNameAndWriteToFile(people, peopleFilePath);

        // Sort employees by salary and write to file
        string employeeFilePath = "sorted_employees.txt";
        SortEmployeesBySalaryAndWriteToFile(people, employeeFilePath);
    }

    public static void SearchAndPrintPersonByName(List<Person> people, string name)
    {
        var foundPerson = people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (foundPerson != null)
        {
            foundPerson.Print();
        }
        else
        {
            Console.WriteLine("Person not found.");
        }
    }

    public static void SortPeopleByNameAndWriteToFile(List<Person> people, string filePath)
    {
        var sortedPeople = people.OrderBy(p => p.Name).ToList();

        using (StreamWriter file = new StreamWriter(filePath))
        {
            foreach (var person in sortedPeople)
            {
                file.WriteLine($"Name: {person.Name}");
            }
        }
        Console.WriteLine($"Sorted list written to {filePath}.");
    }

  public static void SortEmployeesBySalaryAndWriteToFile(List<Person> people, string filePath)
{
    var employees = people.OfType<Staff>().ToList();
    var sortedEmployees = employees.OrderBy(e => e.Salary).ToList(); // Use the public property here

    using (StreamWriter file = new StreamWriter(filePath))
    {
        foreach (var employee in sortedEmployees)
        {
            file.WriteLine($"Name: {employee.Name}, Salary: ${employee.Salary}");
        }
    }
    Console.WriteLine($"Sorted employees list written to {filePath}.");
}
}
