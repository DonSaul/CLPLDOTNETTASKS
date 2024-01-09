﻿// See https://aka.ms/new-console-template for more information

string output = $"{Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile)}/rez.txt";
string input = $"{Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile)}/data.txt";

Console.WriteLine($"Writing data from {input} to {output}...");
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
