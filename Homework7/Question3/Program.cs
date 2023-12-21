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
    Console.WriteLine("Hello, World!");
  }
}