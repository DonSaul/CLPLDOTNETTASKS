using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main()
        {
            string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string inputFile = Path.Combine(homeDirectory, "Desktop/data.txt");
            string outputFile = Path.Combine(homeDirectory, "rez.txt");

            string directoryForTxtFiles = Path.Combine("D:\\");

            Console.WriteLine("Task 1:\n--------------------------");
            ReadAndWriteFile(inputFile, outputFile);

            Console.WriteLine("\nTask 1 Alternative: Using File methods\n--------------------------");
            ReadAndWriteFileSimple(inputFile, outputFile);


            Console.WriteLine("\nTask 2:\n--------------------------");
            WriteDirectoryInfo("C:\\", Path.Combine(homeDirectory, "DirectoryC.txt"));

            Console.WriteLine("\nTask 3:\n--------------------------");
            PrintTxtFilesFromDirectory(directoryForTxtFiles);

            Console.WriteLine("Many thanks for trying this program! Have a good day! Process Terminated.\n");
            Console.ReadKey();
        }


        static void ReadAndWriteFile(string inputFile, string outputFile)
        {
            try
            {
                Console.WriteLine($"Reading data from: {inputFile} using StreamReader and StreamWriter");
                Console.WriteLine("Wait a moment please...");

                using (StreamReader reader = new StreamReader(inputFile))
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
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

        static void ReadAndWriteFileSimple(string inputFile, string outputFile)
        {
            try
            {
                Console.WriteLine($"Reading data from: {inputFile} using File methods");
                Console.WriteLine("Wait a moment please...");

                string data = File.ReadAllText(inputFile);
                File.WriteAllText(outputFile, data);

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
                    foreach (DirectoryInfo dir in directories)
                    {
                        long dirSize = CalculateDirectorySize(dir);
                        writer.WriteLine($"Directory: {dir.Name}, Size: {FormatSize(dirSize)}");
                    }

                    foreach (FileInfo file in files)
                    {
                        writer.WriteLine($"File: {file.Name}, Type: {file.Extension.ToLower()}, {FormatSize(file.Length)}");
                    }
                }
                Console.WriteLine($"Done! You can find the file at: {outputFilePath}");
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

        static long CalculateDirectorySize(DirectoryInfo directory)
        {
            long size = 0;

            try
            {
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    size += file.Length;
                }

                DirectoryInfo[] subDirs = directory.GetDirectories();
                foreach (DirectoryInfo dir in subDirs)
                {
                    size += CalculateDirectorySize(dir);
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

            return size;
        }

        static string FormatSize(long bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(scale, orders.Length - 1);

            foreach (var order in orders)
            {
                if (bytes > max)
                    return string.Format("{0:##.##} {1}", decimal.Divide(bytes, max), order);

                max /= scale;
            }
            return "0 Bytes";
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
}
