namespace Entrypoint
{
  public class Person : IComparable<Person>
  {
    private readonly string name;
    public Person(string name)
    {
      this.name = name;
    }
    virtual public string Name { get { return name; } }
    virtual public void Print()
    {
      Console.WriteLine($"Name: {name}");
    }

    public int CompareTo(Person? other)
    {
      if (other == null) return 1;
      return Name.CompareTo(other.Name);
    }

    public class Staff : Person, IComparable<Staff>
    {
      private readonly int salary;
      public Staff(string name, int salary) : base(name)
      {
        this.salary = salary;
      }
      override public void Print()
      {
        Console.WriteLine($"Name: {Name}, Salary: {salary}");
      }

      public int CompareTo(Staff? other)
      {
        if (other == null) return 1;
        return salary.CompareTo(other.salary);
      }
    }

    public class Student : Person
    {
      private readonly string groupName;

      public Student(string name, string groupName) : base(name)
      {
        this.groupName = groupName;
      }

      public override void Print()
      {
        base.Print();
        Console.WriteLine($"Student of group: {groupName}");
      }
    }

    public class Teacher : Staff
    {
      private readonly string subject;

      public Teacher(string name, int salary, string subject) : base(name, salary)
      {
        this.subject = subject;
      }

      public override void Print()
      {
        base.Print();
        Console.WriteLine($"Teacher of subject: {subject}");
      }
    }

    public class Developer : Staff
    {
      private readonly string level;

      public Developer(string name, int salary, string level) : base(name, salary)
      {
        this.level = level;
      }


      public override void Print()
      {
        base.Print();
        Console.WriteLine($"Developer of level: {level}");
      }
    }
  }

  internal class Program
  {
    private static void Main(string[] args)
    {

      // Console.ForegroundColor = ConsoleColor.Gray;
      List<Person> people = new()
      {
          new Person.Student("Emma", "Group1"),
          new Person.Staff("Peter", 1000),
          new Person.Developer("Rob", 2400, "Senior"),
          new Person.Developer("John", 1500, "Junior"),
          new Person.Teacher("Louis", 1200, "Math")
      };


      foreach (Person person in people)
      {
        person.Print();
        Console.WriteLine();
      }

      Console.Write("Enter name to find: ");
      string? name = Console.ReadLine();
      var found = people.Where(Person => Person.Name == name);
      found.First().Print();
      Console.WriteLine();

      Console.WriteLine("\nList of people sorted by name: \n");
      people.Sort();

      foreach (Person person in people)
      {
        person.Print();
        Console.WriteLine();
      }

      List<Person.Staff> employees = people.OfType<Person.Staff>().ToList();

      Console.WriteLine("\nList of employees sorted by salary: \n");
      employees.Sort();

      foreach (Person.Staff employee in employees)
      {
        employee.Print();
        Console.WriteLine();
      }

    }
  }
}
