using System;
using System.IO;

class Program
{
    static void Main()
    {
        string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string inputFile = Path.Combine(homeDirectory, "Desktop/FilesTest/data.txt");
        string outputFile = Path.Combine(homeDirectory, "rez.txt");

        string directoryForTxtFiles = Path.Combine("D:\\"); // Cambia esto según tu configuración

        // Task 1: Read from data.txt and write to rez.txt
        Console.WriteLine("Task 1:\n--------------------------");
        ReadAndWriteFile(inputFile, outputFile);

        // Task 2: Write information about directories and files from disk C
        Console.WriteLine("\nTask 2:\n--------------------------");
        WriteDirectoryInfo("C:\\", Path.Combine(homeDirectory, "DirectoryC.txt"));

        // Task 3: Select and print .txt files from a specific directory
        Console.WriteLine("\nTask 3:\n--------------------------");
        PrintTxtFilesFromDirectory(directoryForTxtFiles);

        Console.WriteLine("Many thanks for trying this program! Have a good day! Process Terminated.\n");
    }


    static void ReadAndWriteFile(string inputFile, string outputFile)
    {
        try
        {
            Console.WriteLine($"Reading data from: {inputFile}");
            Console.WriteLine("Wait a moment please...");

            string data = File.ReadAllText(inputFile);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.Write(data);
            }

            Console.WriteLine($"Writing complete. You can find the data in: {outputFile}");
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
        Console.WriteLine($"Writing info about files and directories in {path} into {outputFilePath}");
        Console.WriteLine("Wait a moment please...");

        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            DirectoryInfo[] directories = dirInfo.GetDirectories();

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                // Escribiendo información sobre directorios
                foreach (DirectoryInfo dir in directories)
                {
                    writer.WriteLine($"Directory: {dir.Name}, Type: Directory, Size: N/A");
                }

                // Escribiendo información sobre archivos
                foreach (FileInfo file in files)
                {
                    string fileType = file.Extension.ToLower(); // Obtiene la extensión del archivo
                    writer.WriteLine($"File: {file.Name}, Type: {fileType}, Size: {file.Length} bytes");
                }

                Console.WriteLine($"Done! You can find the file at: {outputFilePath}");
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

            Console.WriteLine($"Inspecting directory: {directoryPath}");
            Console.WriteLine($"{txtFiles.Length} files found");

            for (int i = 0; i < txtFiles.Length; i++)
            {
                Console.WriteLine($"File {i + 1} info:");
                Console.WriteLine($"Name: \"{txtFiles[i].Name}\"");
                Console.WriteLine("Content:");
                Console.WriteLine(File.ReadAllText(txtFiles[i].FullName));
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
