public class PersonFileService
{
    public static void WritePeopleToFile(IEnumerable<Person> people, string filePath)
    {
        WriteToFile(people.Select(p => $"Name: {p.Name}"), filePath);
    }

    public static void WriteEmployeesToFile(IEnumerable<Staff> employees, string filePath)
    {
        WriteToFile(employees.Select(e => $"Name: {e.Name}, Salary: ${e.Salary}"), filePath);
    }

    private static void WriteToFile(IEnumerable<string> lines, string filePath)
    {
        File.WriteAllLines(filePath, lines);
        Console.WriteLine($"List written to {filePath}.");
    }
}