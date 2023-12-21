

class Task8
{
    public class Person
    {
        private string name;

        public Person(string name)
        { this.name = name; }

        virtual public string Name { get { return name; } }

        virtual public void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }

    public class Staff : Person
    {
        private int salary;

        public Staff(string name, int salary) : base(name)
        { this.salary = salary; }

        override public string Name { get { return base.Name + " Staff"; } }

        public int Salary { get { return this.salary; } }

        public override void Print()
        {
            Console.WriteLine("Person: {0} has salary: ${1}", Name, this.salary);
        }
    }

    public class Teacher : Staff
    {
        private string subject;

        public Teacher(string name, int salary, string subject) : base(name, salary)
        { this.subject = subject; }

        override public string Name { get { return base.Name + " Teacher"; } }

        public override void Print()
        {
            Console.WriteLine("Person: {0} has salary: ${1} and has subject: {2}", Name, base.Salary, this.subject);
        }
    }
    
    public class Developer : Staff
    {
        private string level; 

        public Developer(string name, int salary, string level) : base(name, salary)
        { this.level = level; }

        override public string Name { get { return base.Name + " Developer"; } }

        public override void Print()
        {
            Console.WriteLine("Person: {0} has salary: ${1} and has level: {2}", Name, base.Salary, this.level);
        }
    }

    class Student : Person
    {
        private string groupName;

        public Student(string name, string groupName) : base(name)
        { this.groupName = groupName; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Student of group: {0}", this.groupName);
        }
    }

    static void Main(string[] args)
    {
        // Task8 
        // Part 1: Add two classes Persons and Staff (use the presentation code)

        // Part 2: Create two classes Teacher and Developer, derived from Staff. 
        // Add field subject for class Teacher;
        // Add field level for class Developer;
        //override method Print for both classes.

        // Part 3:In Main, specify a list of Person type and add objects of each type to it.
        // Call for each item in the list method Print().
        
        Console.WriteLine("Task8 ");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("List of people: ");
        
        //Create list of person and add people information 
        List <Person> people = new List<Person>();
        people.Add(new Person("Yura"));
        people.Add(new Staff("Ira", 1300));
        people.Add(new Teacher("Elon", 500, "Tesla"));
        people.Add(new Developer("Rena", 700, "Junior"));
        foreach (var personInfo in people)
            personInfo.Print();

        Console.WriteLine("-----------------------------------------");

        //Part 4 Enter the person's name. If this name present in  list - print information about this person

        string characterString = "";
        bool isValidInputString = false;

        //While loop until user enters a valid name 
        while (!isValidInputString)
        {
            Console.WriteLine("Enter a valid person's name to print information about this person: ");
            string inputString = Console.ReadLine();

            // Check if the string is valid:
            // - Ensure it is not null or has white spaces
            // - To ensure all values are letters 
            isValidInputString = !string.IsNullOrWhiteSpace(inputString) && inputString.All(char.IsLetter);

            if (isValidInputString)
            {
                characterString = inputString;
            }
        }

        // Check if the entered name is present in the list
        bool personFound = false;
        foreach (var person in people)
        {
            //Split because we want to check first word of the Name object
            string[] nameWords = person.Name.Split(' ');

            if (nameWords[0].Equals(characterString))
            {
                personFound = true;
                Console.WriteLine("Person was found! , information:");
                person.Print();
                break;
            }
        }

        if (!personFound)
        {
            Console.WriteLine("Person was not found in the list.");
        }


        //Part5 :Sort list by name, output to file
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("List has been sorted by name, here is the sorted list:");

        //Using LINQ operation to sort by name
        people = people.OrderBy(p => p.Name).ToList();

        foreach (var personInfo in people)
            personInfo.Print();

        //Generating txt file 
        string filePath = "sortedByNamePeople.txt";
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var personInfo in people)
                writer.WriteLine(personInfo.Name);
        }

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Generating txt File:"); 
        Console.WriteLine($"Sorted list has been written to {filePath}");
        Console.WriteLine("-----------------------------------------");


        //Part 6 Create a list of Employees and move only workers there. Sort them by salary.
        Console.WriteLine("List of workers sorted by salary: ");
       
        //Create a new workers list and add Staff
        List<Staff> workers = new List<Staff>();
        foreach (var person in people)
        {
            if (person is Staff staff)
            {
                workers.Add(staff);
            }
        }

        // Sort the list of workers by salary with LINQ 
        workers = workers.OrderBy(w => w.Salary).ToList();

        // Print the sorted list of workers
        foreach (var worker in workers)
            worker.Print();

        Console.WriteLine("--------------------------");
        Console.WriteLine("Program finished , press enter to close the terminal...");
        Console.ReadLine(); 
    }
}