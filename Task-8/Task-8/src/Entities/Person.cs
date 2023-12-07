public class Person
{
    protected string name;

    public Person(string name)
    {
        this.name = name;
    }

    public virtual string Name
    {
        get { return name; }
    }

    public virtual void Print()
    {
        Console.WriteLine($"Name: {name}");
    }
}