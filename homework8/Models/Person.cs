public class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }

    virtual public string Name { get {return name;} }

    virtual public void Print()
    {
        Console.WriteLine("Name");
    }
}