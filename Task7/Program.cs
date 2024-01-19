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

Console.WriteLine($"\nListing all files and folders at the root of disk C");

string root = OperatingSystem.IsWindows() ? "C:\\" : "/";

string dirInfoOut = $"{HOME}/DirectoryC.txt";

static long GetDirLength(DirectoryInfo dir)
{
    long len = 0;
    try
    {
        FileInfo[] files = dir.GetFiles();
        len = files.Sum(f => f.Length);
    }
    catch (UnauthorizedAccessException) { }
    try
    {
        DirectoryInfo[] dirs = dir.GetDirectories();
        len += dirs.Sum(d => GetDirLength(d));
    }
    catch (UnauthorizedAccessException) { }
    return len;
}

using (StreamWriter writer = new(dirInfoOut))
{
    writer.WriteLine("Name:                    Type: Size (Bytes):");
    foreach (DirectoryInfo dir in Directory.GetDirectories(root).Select(path => new DirectoryInfo(path)))
    {
        writer.WriteLine("{0,-25}/dir  {1}", dir.Name, GetDirLength(dir));
    }
    foreach (FileInfo file in Directory.GetFiles(root).Select(path => new FileInfo(path)))
    {
        writer.WriteLine("{0,-25}{1,-6}{2}", file.Name, file.Extension, file.Length);
    }
}

Console.WriteLine($"Written to {dirInfoOut}\n");

Console.WriteLine("Reading files from the D disk directory...");

if (!OperatingSystem.IsWindows())
{
    Console.WriteLine("Whooops! This test only works on windows for now...");
    return;
}
IEnumerable<string> txts = Directory.GetFiles("D:\\").Where(f => f.EndsWith(".txt"));
try
{
    foreach (string txt in txts)
    {
        using StreamReader reader = new(txt);
        Console.WriteLine(reader.ReadToEnd());
    }
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("There's no directory D:, shouldn't you plug in a drive??? (Next time, maybe)");
}