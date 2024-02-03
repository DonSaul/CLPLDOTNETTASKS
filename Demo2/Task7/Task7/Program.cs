using Microsoft.VisualBasic;
using System.IO;
using System.Linq.Expressions;

class Task7
{
    static void Main(string[] args)
    {
        // Task 7 

        Console.WriteLine("Task 7:");
        Console.WriteLine("-----------------------------------------");
        //1)Read and write all data from data.txt into rez.txt files, by using (Catch appropriative exceptions):
        //1.1)StreamReader StreamWriter
        //1.2)File.WriteAllText

        //Combine the current directory with the file names
        string filePathData = Path.Combine(Environment.CurrentDirectory, "data.txt");
        string filePathRez = Path.Combine(Environment.CurrentDirectory, "rez.txt");

        //1.1)StreamReader StreamWriter
        try
        {
            StreamReader sr = new StreamReader(filePathData);
            StreamWriter sw = new StreamWriter(filePathRez);
            using (sr)
            {
                // Read data from data.txt using StreamReader
                string dataToCopy = sr.ReadToEnd();
                using (sw)
                {
                    // Write data from data.txt into rez.txt using StreamWriter
                    sw.Write(dataToCopy);
                }
            }
            Console.WriteLine("1.1) Contents from data.txt were written into rez.txt successfully using StreamWriter");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error with 1.1)Exception: " + e.Message);
        }

        //1.2)File.WriteAllText
        try
        {
            //Write text from data.txt into rez.txt using WriteAllText
            File.WriteAllText(filePathRez, filePathData);
            Console.WriteLine("1.2) Contents from data.txt were written into rez.txt successfully using WriteAllText");
        }
        catch (Exception e)
        {

            Console.WriteLine("Error with 1.2)Exception: " + e.Message);
        }

        //2 Write into file ‘DirectoryC.txt’ information (name, type, size)
        //about all directories and files from disc C on your computer.
        //Catch appropriative exceptions.

        //Combine the current directory with the file names
        string filePathC = Path.Combine(Environment.CurrentDirectory, "DirectoryC.txt");

        try
        {
            //Combine the current directory with the file names
            StreamWriter swc = new StreamWriter(filePathC);
            using (swc)
            {
                //checking if "C:\\" Directory exists
                string dirNameC = "C:\\";
                if (Directory.Exists(dirNameC))
                {
                    //getting all directory names and write it into DirectoryC
                    Console.WriteLine("Directory C directories: ");
                    swc.WriteLine("Directory C directories: ");
                    string[] dirs = Directory.GetDirectories(dirNameC);
                   
                    foreach (string directoryNames in dirs)
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(directoryNames);
                        Console.WriteLine($"Name: {directoryInfo.Name}");
                        swc.WriteLine($"Name: {directoryInfo.Name}");
                    }

                    // Write information about files and write it into DirectoryC
                    Console.WriteLine("Directory C files: ");
                    swc.WriteLine("Files:");
                    string[] files = Directory.GetFiles(dirNameC);
                    
                    foreach (string filesInfo in files)
                    {
                        FileInfo fileInfo = new FileInfo(filesInfo);
                        Console.WriteLine($"Name: {fileInfo.Name}, Type: File, Size: {fileInfo.Length} bytes");
                        swc.WriteLine($"Name: {fileInfo.Name}, Type: File, Size: {fileInfo.Length} bytes");
                    }


                }
            }

            Console.WriteLine("2) Info was written into DirectoryC");
        }
        catch (Exception e)
        {

            Console.WriteLine("Error with 2)Exception: " + e.Message);
        }

        //3)Select from directory D only .txt files and print the text from it into console. Catch appropriative exceptions.
        try
        {
            //checking if "D:\\" Directory exists
            string dirNameD = "D:\\";
            if (Directory.Exists(dirNameD))
            {

                // Get all ".txt" files in the directory D
                string[] txtFiles = Directory.GetFiles(dirNameD, "*.txt");
                Console.WriteLine("All content from all txt files from directory D:"); 
                foreach (string txtFile in txtFiles)
                {
                    // Write all context from each txt file into the console 
                    string fileContent = File.ReadAllText(txtFile);
                    Console.WriteLine($"Text from {txtFile}:\n{fileContent}\n");

                }
            }
        }
        catch (Exception e)
        {

            Console.WriteLine("Error with 3)Exception: " + e.Message);
        }

        Console.WriteLine("--------------------------");
        Console.WriteLine("Program finished , press enter to close the terminal...");
        Console.ReadLine();
    }
}
