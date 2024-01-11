// See https://aka.ms/new-console-template for more information

string HOME = Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);

string output = $"{HOME}/rez.txt";
string input = $"{HOME}/data.txt";

Console.WriteLine($"Writing data from {input} to {output}...");
if (File.Exists(input))
{
    Console.Write("Using StreamReader/Writter... ");
    using (StreamReader reader = new(input))
    {
        using StreamWriter writer = new(output);
        writer.Write(reader.ReadToEnd());
    }
    Console.WriteLine("Done.");

    Console.Write("Using File.WriteAllText... ");
    using (StreamReader reader = new(input))
    {
        File.WriteAllText(output, reader.ReadToEnd());
    }
    Console.WriteLine("Done.");
}
else
{
    Console.WriteLine($"Uhhhhh... {input} doesn't exist.");
}
