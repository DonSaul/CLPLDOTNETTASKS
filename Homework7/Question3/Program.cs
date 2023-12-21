internal class Program
{
  public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
  {
    Dictionary<string, List<string>> namesToPhones = new();
    foreach (KeyValuePair<string, string> phoneToName in phonesToNames)
    {
      string name = phoneToName.Value ?? "";
      if (!namesToPhones.TryGetValue(name, out List<string> phones))
      {
        phones = new List<string>();
        namesToPhones.Add(name, phones);
      }
      phones.Add(phoneToName.Key);
    }

    return namesToPhones;
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

    Dictionary<string, List<string>> namesToPhones = ReverseNotebook(phonesToNames);

    foreach (KeyValuePair<string, List<string>> nameToPhones in namesToPhones)
    {
      Console.WriteLine("\n" + nameToPhones.Key);
      Console.WriteLine("----------");
      foreach (string phone in nameToPhones.Value)
      {
        Console.WriteLine(phone);
      }
    }
  }
}