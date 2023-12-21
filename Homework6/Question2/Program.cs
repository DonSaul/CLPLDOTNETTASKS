internal class Program
{
  public interface IAnimal
  {
    string Name { get; set; }
    void Voice();
    void Feed();
  }


  public class Dog : IAnimal
  {
    private string name;
    public string Name
    {
      get => name;
      set
      {
        if (value == null)
          throw new ArgumentOutOfRangeException(nameof(value), "Name must not be null.");

        if (value.Length <= 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Name must not be empty.");

        name = value;
      }
    }

    public void Voice ()
    {
      Console.WriteLine("Woof");
    }

    public void Feed()
    {
      Console.WriteLine("I eat meat");
    }

  }


  public class Cat : IAnimal
  {
    private string name;
    public string Name
    {
      get => name;
      set
      {
        if (value == null)
          throw new ArgumentOutOfRangeException(nameof(value), "Name must not be null.");

        if (value.Length < 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Name must not be empty.");


        name = value;
      }
    }

    public void Voice()
    {
      Console.WriteLine("Mew");
    }

    public void Feed()
    {
      Console.WriteLine("I eat mice");
    }
  }

  private static void Main(string[] args)
  {

  }
}