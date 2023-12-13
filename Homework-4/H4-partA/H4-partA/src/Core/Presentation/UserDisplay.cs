using System;
using Homework_4.src.Core.Entities;

namespace Homework_4.src.Core.Presentation
{
    public class UserDisplay
    {
        public void DisplayShapes(List<Shape> shapes)
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("   Type       | Name            | Radius/Side   | Area   | Perimeter");
            Console.WriteLine("--------------------------------------------------------------------------");
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(FormatShape(i + 1, shapes[i]));
            }
            Console.WriteLine("--------------------------------------------------------------------------");
        }

        public void WriteShapesToFile(string fileName, List<Shape> shapes)
        {
            File.WriteAllLines(fileName, shapes.Select(s => s.ToString()));
        }

        private string FormatShape(int index, Shape shape)
        {
            string type = shape.GetType().Name;
            string name = shape.Name.Length > 15 ? shape.Name.Substring(0, 12) + "..." : shape.Name;
            string dimension = type == "Circle" ? $"Radius: {((Circle)shape).Radius:F2}" : $"Side: {((Square)shape).Side:F2}";
            return $"{index}. {type,-10} | {name,-15} | {dimension,-12} | {shape.Area(),-6} | {shape.Perimeter(),-10}";

   

}
}

