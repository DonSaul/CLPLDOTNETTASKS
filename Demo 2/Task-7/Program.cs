using System;
using System.IO;

class Program
{
    static void Main()
    {


        // Replace these paths with paths valid on your Mac
        string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string inputFile = Path.Combine(homeDirectory, "data.txt");
        string outputFile = Path.Combine(homeDirectory, "Directory.txt");
        string directoryInfoOutput = Path.Combine(homeDirectory, "DirectoryInfo.txt");
        string directoryForTxtFiles = homeDirectory; // Change to a directory of your choice


        // Task 1: Read from data.txt and write to rez.txt
        Console.WriteLine("Task 1 ---------------\n ");
        ReadAndWriteFile(inputFile, outputFile);

        // Task 2: Write information about directories and files from a specific path
        Console.WriteLine("Task 2 ---------------\n ");
        WriteDirectoryInfo(homeDirectory, directoryInfoOutput);

        // Task 3: Select and print .txt files from a specific directory
        Console.WriteLine("Task 3 ---------------\n ");
        PrintTxtFilesFromDirectory(directoryForTxtFiles);

        //// Task 1: Read from data.txt and write to rez.txt
        //ReadAndWriteFile("data.txt", "rez.txt");

        //// Task 2: Write information about directories and files from disk C
        //WriteDirectoryInfo(@"C:\");

        //// Task 3: Select and print .txt files from directory D
        //PrintTxtFilesFromDirectory(@"D:\");
    }

    static void ReadAndWriteFile(string inputFile, string outputFile)
    {
        try
        {
            string data = File.ReadAllText(inputFile);
            File.WriteAllText(outputFile, data);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception: " + ex.Message);
        }
    }

    static void WriteDirectoryInfo(string path, string outputFilePath)
    {
        Console.WriteLine("Writing info about files into DirectoryInfo.txt");
        Console.WriteLine("You can find it at..");
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            DirectoryInfo[] directories = dirInfo.GetDirectories();

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (DirectoryInfo dir in directories)
                {
                    writer.WriteLine($"asñldfjaslkjdf: {dir.Name}, Type: Directory, Size: N/A");
                }
                foreach (FileInfo file in files)
                {
                    writer.WriteLine($"File: {file.Name}, Type: File, Size: {file.Length} bytes");
                }
            }
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Access denied: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception: " + ex.Message);
        }
    }

    static void PrintTxtFilesFromDirectory(string directoryPath)
    {
        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
            FileInfo[] txtFiles = dirInfo.GetFiles("*.txt");

            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine($"Contents of {file.Name}:");
                Console.WriteLine(File.ReadAllText(file.FullName));
                Console.WriteLine();
            }
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Directory not found: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception: " + ex.Message);
        }
    }
}
