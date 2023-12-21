internal class Program
{
  public static Lookup<string, string> CreateNotebook(Dictionary<string, string> phonesToNames)
  {
    List<(string, string)> commonList = new();
    foreach (KeyValuePair<string, string> phoneToName in phonesToNames)
    {
      commonList.Add((phoneToName.Value ?? "", phoneToName.Key));
    }

    return (Lookup<string, string>)commonList.ToLookup(el => el.Item1, el => el.Item2);
  }

  private static void Main(string[] args)
  {
    Dictionary<string, string> phonesToNames = new()
    {
      { "12345", "Pedro" },
      { "65789", "Pedro" },
      { "87654", "Alvaro" },
      { "98765", "Ballero" },
      { "11223", "Pizzeria" },
      { "44556", "Pizzeria" }
    };

    Lookup<string, string> notebook = CreateNotebook(phonesToNames);

    foreach (var item in notebook)
    {
      Console.WriteLine("\n"+item.Key);
      Console.WriteLine("----------");
      foreach (var value in item)
      {
        Console.WriteLine(value);
      }
    }

  }
}