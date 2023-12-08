using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PersonService
{
    public static Person SearchAndPrintPersonByName(List<Person> people, string name)
    {
        var foundPerson = people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (foundPerson != null)
        {
            Console.WriteLine($"Details for '{name}':\n");
            foundPerson.Print();
        }
        else
        {
            Console.WriteLine($"No details found for '{name}'.");
        }
        return foundPerson;
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
        var sortedEmployees = employees.OrderBy(e => e.Salary).ToList();

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
