public class Developer : Staff
{
    private string level;

    public Developer(string name, int salary, string level) : base(name, salary)
    {
        this.level = level;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Level: {level}");
    }
}