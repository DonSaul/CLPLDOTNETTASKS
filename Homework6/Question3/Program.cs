internal class Program
{
  public enum ColourEnum
  {
    Red,
    Green,
    Blue
  }

  public interface IColoured
  {
    ColourEnum Colour { get { return ColourEnum.Red; } }

  }

  public interface IDocument
  {
    static string defaultText = "Lorem ipsum";
    int Pages { get { return 0; } set => Pages = value; }
    string Name { get; set; }

    void AddPages(int pagesToAdd)
    {
      Pages += pagesToAdd;
    }

    void Rename(string newName)
    {
      Name = newName;
    }

  }

  public class ColouredDocument : IDocument, IColoured
  {
    public static string defaultText = "Lorem ipsum";


    public int Pages { get; set; }
    public string Name { get; set; }
    public ColourEnum Colour { get; set; }

    public ColouredDocument(string name, int pages, ColourEnum colour)
    {
      Name = name;
      Pages = pages;
      Colour = colour;
    }

    public ColouredDocument(ColourEnum colour)
    {
      Name = defaultText;
      Colour = colour;
    }

    public void AddPages(int pagesToAdd)
    {
      Pages += pagesToAdd;
    }

    public void Rename(string newName)
    {
      Name = newName;
    }
  }

  public class Example
  {
    public static void Do()
    {
      var doc1 = new ColouredDocument("Document1", 0, ColourEnum.Blue);
      doc1.AddPages(10);
      Console.WriteLine(doc1.Name);
      doc1.Rename("Document2");
      Console.WriteLine(doc1.Name);
    }
  }

  private static void Main(string[] args)
  {
    Example.Do();
  }
}