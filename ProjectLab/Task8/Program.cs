using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Task8.Models;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            // Add objects of each type to the list
            people.Add(new Person("Alice"));
            people.Add(new Person("Eva"));
            people.Add(new Staff("Bob", 3000));
            people.Add(new Staff("Frank", 2800));
            people.Add(new Teacher("Charlie", 4000, "Math"));
            people.Add(new Teacher("Grace", 4200, "Science"));
            people.Add(new Developer("David", 5000, "Senior"));
            people.Add(new Developer("Hannah", 4800, "Junior"));

            // Call Print method for each item in the list
            foreach (var person in people)
            {
                person.Print();
            }

            // Enter the person's name and print information if present in the list
            Console.WriteLine("\nEnter a name to search: ");
            string searchName = Console.ReadLine();
            var foundPerson = people.FirstOrDefault(p => p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (foundPerson != null)
            {
                Console.WriteLine("Information about {0}:", foundPerson.Name);
                foundPerson.Print();
            }
            else
            {
                Console.WriteLine("Person not found in the list.");
            }

            // Sort list by name and output to a file
            var sortedListByName = people.OrderBy(p => p.Name).ToList();
            File.WriteAllLines("sorted_people.txt", sortedListByName.Select(p => p.Name));

            // Create a list of Employees and sort them by salary
            List<Staff> employees = people.OfType<Staff>().OrderBy(emp => emp.Salary).ToList();


            Console.WriteLine("\nEmployees sorted by salary:");
            foreach (var employee in employees)
            {
                Console.WriteLine("Name: {0}, Salary: ${1}", employee.Name, employee.Salary);
            }
        }
    }
}
