using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PersonService
{
    public static Person SearchAndPrintPersonByName(List<Person> people, string searchQuery)
    {
        Person foundPerson = people.FirstOrDefault(p =>
        {
            string fullName = (p is Staff) ?  (searchQuery + " Staff") : searchQuery;
            return fullName.Equals(p.Name, StringComparison.OrdinalIgnoreCase);
        });

     
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
