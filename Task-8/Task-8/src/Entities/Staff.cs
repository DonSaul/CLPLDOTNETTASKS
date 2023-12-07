public class Staff : Person
{
    private int salary;

    public int Salary // Public property to expose the salary
    {
        get { return salary; }
        // Optionally add a setter if you need to allow salary changes from outside
    }

    public Staff(string name, int salary) : base(name)
    {
        this.salary = salary;
    }

    public override string Name
    {
        get { return base.Name + " Staff"; }
    }

    public override void Print()
    {
        Console.WriteLine($"Person {name} has salary: ${salary}");
    }
}