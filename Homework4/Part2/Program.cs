using System.Text.RegularExpressions;

internal class Program
{
  private static void Main(string[] args)
  {
    string filepath = "./text.txt";
    string pattern = @"[^a-zA-Z0-9\s]";

    bool doesFileExist = File.Exists(filepath);

    if (!doesFileExist) return;

    string[] lines = File.ReadAllLines(filepath);

    foreach (string line in lines)
    {
      int symbolCounter = 0;
      foreach (char c in line)
      {
        if (Regex.IsMatch(c.ToString(), pattern))
        {
          symbolCounter++;
        }
      }
      Console.WriteLine("Line: " + line + " has " + symbolCounter + " symbol(s)");
    }

    Console.WriteLine($"\nThe longest line is {lines.OrderByDescending(x => x.Length).First()}");
    Console.WriteLine($"The shortest line is {lines.OrderBy(x => x.Length).First()}\n");

    for (int i = 0; i < lines.Length; i++)
    {
      if (lines[i] == "var")
      {
        Console.WriteLine($"Line {i + 1} consists only of the word 'var'");
      }
    }

  }
}