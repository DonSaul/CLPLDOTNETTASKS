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

        // Print all people with improved formatting
        Console.WriteLine("List of People:\n");
        foreach (var person in people)
        {
            person.Print();
            Console.WriteLine(); // Adds a newline for better separation
        }

        // Search and print person by name with improved formatting
        Console.WriteLine("----------------------------");
        Console.Write("Enter the person's name: ");
        string inputName = Console.ReadLine();
        Console.WriteLine();
        
        var foundPerson = PersonService.SearchAndPrintPersonByName(people, inputName);
        if (foundPerson != null)
        {
            Console.WriteLine($"Details for '{inputName}':\n");
            foundPerson.Print();
        }
        else
        {
            Console.WriteLine($"No details found for '{inputName}'.");
        }
        
        Console.WriteLine("\n----------------------------");

        // Sort people by name and write to file with improved formatting
        string peopleFilePath = "sorted_people.txt";
        PersonService.SortPeopleByNameAndWriteToFile(people, peopleFilePath);
        Console.WriteLine($"Sorted list written to {peopleFilePath}.\n");

        // Sort employees by salary and write to file with improved formatting
        string employeeFilePath = "sorted_employees.txt";
        PersonService.SortEmployeesBySalaryAndWriteToFile(people, employeeFilePath);
        Console.WriteLine($"Sorted employees list written to {employeeFilePath}.\n");
    }
}


