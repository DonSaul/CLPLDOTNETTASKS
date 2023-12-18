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

            var fileTextWithIndex = fileText.Select((n, i) => new { Valor = n, Indice = i + 1 }).ToList();

            var Shortest = fileTextWithIndex.OrderBy(n  => n.Valor.Length ).First();
            var Longest = fileTextWithIndex.OrderByDescending(n => n.Valor.Length).First();

            Console.WriteLine("Shortest Line: {0} Length: {1} Line Number: {2}", Shortest.Valor , Shortest.Valor.Length, Shortest.Indice);
            Console.WriteLine("Longest Line: {0} Length: {1} Line Number: {2}", Longest.Valor , Longest.Valor.Length, Longest.Indice);


        }
        catch (Exception e)
        {

            Console.WriteLine(e.ToString());
        }
    }
}
