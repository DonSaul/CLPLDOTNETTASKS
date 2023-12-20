using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Mike"));
            people.Add(new Student("Michelle", "C#"));
            people.Add(new Staff("Luke", 1500));
            people.Add(new Teacher("Maths", "Clint", 10000));
            people.Add(new Developer("Senior", "Layla", 4000));

            foreach (var person in people)
            {
                person.Print();
                Console.ReadKey();
            }

            Console.WriteLine("Enter a name:");
            string inputName = Console.ReadLine();

            Person foundPerson = people.Find(person => person.Name.Equals(inputName, StringComparison.OrdinalIgnoreCase));
            if (foundPerson != null)
            {
                foundPerson.Print();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Person not found.");
                Console.ReadKey();
            }

            people.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));

            using (StreamWriter writer = new StreamWriter("sortedPeople.txt"))
            {
                foreach (var person in people)
                {
                    writer.WriteLine(person.Name);
                }
            }

            List<Staff> employees = people.OfType<Staff>().ToList();
            employees = employees.OrderBy(e => (int)typeof(Staff).GetField("salary", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(e)).ToList();

            Console.WriteLine("Sorted Employees by Salary:");
            foreach (var employee in employees)
            {
                employee.Print();
                Console.ReadKey();
            }
        }
    }
}
