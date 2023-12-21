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
      { "1", "aa" },
      { "2", "bb" },
      { "3", "aa" },
      { "4", "dd" },
      { "5", "cc" },
      { "6", "zz" }
    };

    Lookup<string, string> notebook = CreateNotebook(phonesToNames);

    foreach (var item in notebook)
    {
      foreach (var value in item)
      {
        Console.WriteLine(item.Key+"\t"+value);
      }
    }

  }
}