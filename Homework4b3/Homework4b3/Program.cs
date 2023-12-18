using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Homework4b2
{
    static void Main()
    {

        try
        {
            string path = @"c:\!-ReadMe.txt";
            if (!File.Exists(path))
            {

            }


            StreamReader streamReader = new StreamReader(path);


            List<string> fileText = new List<string>();
            while (!streamReader.EndOfStream)
            {
                fileText.Add(streamReader.ReadLine());
            }

            streamReader.Close();

            string wordRegex = "var";
            Regex SymbolsRegex = new Regex(@wordRegex);

            bool AnyMatch = false;

            Console.WriteLine("Findind '{0}' in '{1}'", wordRegex, path);

            foreach (string line in fileText)
            {
                if (SymbolsRegex.IsMatch(line))
                {
                    Console.WriteLine("Line: {0} ", line);
                    AnyMatch = true;
                }           

            }

            if (!AnyMatch) 
            {
                Console.WriteLine("There is no match for '{0}'" , wordRegex);
            }
           


        }
        catch (Exception e)
        {

            Console.WriteLine(e.ToString());
        }
    }
}