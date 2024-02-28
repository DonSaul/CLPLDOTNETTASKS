using System;
using System.IO;
using System.Text;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Requirement 1
            Console.WriteLine("Initiating requirement 1...");
            Console.WriteLine("Description: This requirement reads the content of 'data.txt' in the Documents folder and writes it to 'rez.txt' in the current directory.\n");

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string error = null;

            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(documentsPath, "data.txt")))
                {
                    using (StreamWriter sw = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "rez.txt")))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line != null)
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
                Console.WriteLine("File 'rez.txt' created successfully.");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The file could not be found:");
                Console.WriteLine(e.Message);
                error = e.Message;
            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading or writing the file:");
                Console.WriteLine(e.Message);
                error = e.Message;
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred:");
                Console.WriteLine(e.Message);
                error = e.Message;
            }
            finally
            {
                if (error != null)
                {
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "rez.txt"), error);
                    Console.WriteLine("File 'rez.txt' created with error details.");
                }
            }

            // Requirement 2
            int maxDepth = 0; // Change this to adjust the maximum depth
            int maxFoldersToShow = 5; // Change this to adjust the maximum number of folders to show
            Console.WriteLine("\nInitiating requirement 2...");
            Console.WriteLine($"Description: This requirement explores the C:\\ directory up to a maximum depth of {maxDepth} and shows a maximum of {maxFoldersToShow} folders per depth level in 'DirectoryC.txt'.\n");

            var info = new StringBuilder();
            try
            {
                ExploreDirectory(@"C:\", info, 0, maxDepth, maxFoldersToShow, showAllFolders: false); // Change to true if you want to show all folders
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Permission is denied to access one or more folders or subfolders in C:\\");
                Console.WriteLine(e.Message);
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("The path of one or more subfolders in C:\\ is too long.");
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The directory C:\\ could not be found:");
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading a file or directory in C:\\");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while trying to obtain the folders and subfolders in C:\\");
                Console.WriteLine(e.Message);
            }

            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "DirectoryC.txt"), info.ToString());
            Console.WriteLine("File 'DirectoryC.txt' created successfully.");

            // Requirement 3
            Console.WriteLine("\nInitiating requirement 3...");
            Console.WriteLine("Description: This requirement searches for all .txt files in D:\\ and displays their content in the console.\n");
            try
            {
                var files = Directory.GetFiles(@"D:\\", "*.txt");
                if (files.Length == 0)
                {
                    Console.WriteLine("No .txt files were found in D:");
                }
                else
                {
                    int fileCount = 1;
                    foreach (var file in files)
                    {
                        try
                        {
                            string fileName = Path.GetFileName(file);
                            Console.WriteLine($"\nFile {fileCount}\n{fileName}\n-----------\n{File.ReadAllText(file)}\n-----------");
                            fileCount++;
                        }
                        catch (FileNotFoundException e)
                        {
                            Console.WriteLine($"The file {file} could not be found:");
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"The file {file} could not be read:");
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The directory D: could not be found:");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while trying to access the directory D:");
                Console.WriteLine(e.Message);
            }
        }
        static void ExploreDirectory(string directoryPath, StringBuilder info, int currentDepth, int maxDepth, int maxFoldersToShow, bool showAllFolders = false)
        {
            string indent = new string('\t', currentDepth);

            try
            {
                var dirInfo = new DirectoryInfo(directoryPath);
                string sanitizedDirName = SanitizeString(dirInfo.Name);
                info.AppendLine($"{indent}{sanitizedDirName}\\");

                // Counter to keep track of the number of folders shown
                int foldersShown = 0;

                // Explore only if the current depth is less than or equal to the maximum depth
                if (currentDepth <= maxDepth)
                {
                    foreach (var file in dirInfo.GetFiles())
                    {
                        // Show file information
                        try
                        {
                            string sanitizedFileName = SanitizeString(file.Name);
                            info.AppendLine($"{indent}\t{sanitizedFileName}, Type: File, Size: {file.Length} bytes");
                        }
                        catch (UnauthorizedAccessException e)
                        {
                            string sanitizedMessage = SanitizeString(e.Message);
                            info.AppendLine($"{indent}\tError accessing the file.\n{indent}Details: {sanitizedMessage}");
                        }
                        catch (Exception e)
                        {
                            string sanitizedMessage = SanitizeString(e.Message);
                            info.AppendLine($"{indent}\tError getting file information.\n{indent}Details: {sanitizedMessage}");
                        }
                    }

                    foreach (var dir in dirInfo.GetDirectories())
                    {
                        // Show only subfolders until the limit is reached or if showAllFolders is true
                        if (foldersShown < maxFoldersToShow || showAllFolders)
                        {
                            ExploreDirectory(dir.FullName, info, currentDepth + 1, maxDepth, maxFoldersToShow, showAllFolders);
                            foldersShown++;
                        }
                        else
                        {
                            info.AppendLine($"{indent}\t..."); // Indicate that there are more folders but not all are shown
                            break; // Exit the loop once the limit is reached
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                string sanitizedMessage = SanitizeString(e.Message);
                info.AppendLine($"{indent}Error accessing the directory.\n{indent}Details: {sanitizedMessage}");
            }
            catch (Exception e)
            {
                string sanitizedMessage = SanitizeString(e.Message);
                info.AppendLine($"{indent}Error getting directory information.\n{indent}Details: {sanitizedMessage}");
            }
        }

        public static string SanitizeString(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                if (c > 127)     // Checks if the character is non-ASCII
                {
                    continue; //Ignores non-ASCII characters by continuing to the next iteration
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
