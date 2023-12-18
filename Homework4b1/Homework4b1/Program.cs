using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Homework4b1
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

            Regex SymbolsRegex = new Regex(@"[^a-zA-Z0-9 ]");


            foreach (string line in fileText)
            {
                int AmountSymbols = SymbolsRegex.Matches(line).Count;
                Console.WriteLine("Line: {0} Amount of symbols: {1}" ,line , AmountSymbols);

            }


        }
        catch (Exception e)
        {
            
            Console.WriteLine(e.ToString());
        }
    }
}