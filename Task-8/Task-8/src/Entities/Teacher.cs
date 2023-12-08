public class Teacher : Staff
{
    private string subject;

    public Teacher(string name, int salary, string subject) : base(name, salary)
    {
        this.subject = subject;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine("Role: Teacher");
        Console.WriteLine($"Subject: {subject}");
    }
}