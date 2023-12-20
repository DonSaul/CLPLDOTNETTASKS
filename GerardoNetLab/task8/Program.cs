using Task8;

List<Person> people = new List<Person>
            {
                new Person("Gerardo"),
                new Staff("John", 230000),
                new Teacher("Carlitox", 240000, "Math"),
                new Developer("Dieguito", 634050, "Senior"),
                new Student("David", "A"),
               
            };

foreach (var person in people)
{
    person.Print();
}

string userInput;
do
{
    Console.Write("Enter a person's name (type 'exit' to stop): ");
    userInput = Console.ReadLine();

    if (userInput.ToLower() != "exit")
    {
        Person foundPerson = people.FirstOrDefault(p => p.Name.Equals(userInput, StringComparison.OrdinalIgnoreCase));

        if (foundPerson != null)
        {
            foundPerson.Print();
        }
        else
        {
            Console.WriteLine("Person not found.");
        }
    }

} while (userInput.ToLower() != "exit");

// Sort list by name
people.Sort((p1, p2) => String.Compare(p1.Name, p2.Name, StringComparison.Ordinal));

// Output to file
using (StreamWriter writer = new StreamWriter("output.txt"))
{
    foreach (var person in people)
    {
        writer.WriteLine(person.Name);
    }
}

// list of Employees and workers 
List<Staff> employees = people.OfType<Staff>().ToList();

// Arrange  employees by salary
employees.Sort((e1, e2) => e1.Salary.CompareTo(e2.Salary));

Console.WriteLine("Employees sorted by salary:");
foreach (var employee in employees)
{
    Console.WriteLine("Name: {0}, Salary: {1}", employee.Name, employee.Salary);
}
