using Task8;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating people list... ");
        List<Person> people = [];
        Console.WriteLine("Done.");

        Console.WriteLine("Adding the following people to the list:");
        people.Add(new Person("Mauricio"));
        people.Add(new Teacher("George", 2500, "IT"));
        people.Add(new Developer("Phillip", 1500, "mid level"));
        people.Add(new Person("Javier"));
        people.Add(new Staff("Ken", 1300));

        foreach (Person person in people)
        {
            person.Print();
        }
        Console.WriteLine("Done.");

        Console.WriteLine("Now, please type in the name of a person to see if it's in the list:");
        Console.Write("> ");
        string s = Console.ReadLine() ?? "";

        bool found = false;
        foreach (Person person in people)
        {
            string name = person.Name.Split(' ')[0];
            if (name.Equals(s, StringComparison.CurrentCultureIgnoreCase))
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("Yes! We have that person on the list!");
        }
        else
        {
            Console.WriteLine("Ehhh... That person is not on the list.");
        }
        Console.WriteLine("Now sorting the list by name...");
        people.Sort(ComparePeopleByName);
        using (StreamWriter writer = new("people.txt", false))
        {
            foreach (Person person in people)
            {
                person.Print();
                writer.WriteLine(person.Name);
            }
        }
        Console.WriteLine("List written to file: people.txt");

    }

    private static int ComparePeopleByName(Person person1, Person person2)
    {
        return person1.Name.CompareTo(person2.Name);
    }
}
