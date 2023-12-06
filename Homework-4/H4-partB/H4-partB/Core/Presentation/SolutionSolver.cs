using System;
using Homework_4.src.Core.Entities;

namespace Homework_4.src.Core.Presentation
{
	public class SolutionSolver
	{
        public void WriteShapesWithAreaInRangeToFile(List<Shape> shapes, double minArea, double maxArea, string fileName)
        {
            var filteredShapes = shapes.Where(s => s.Area() >= minArea && s.Area() <= maxArea).ToList();
            File.WriteAllLines(fileName, filteredShapes.Select(s => s.ToString()));
        }

        public void WriteShapesWithNameContainingToFile(List<Shape> shapes, string character, string fileName)
        {
            var filteredShapes = shapes.Where(s => s.Name.Contains(character)).ToList();
            File.WriteAllLines(fileName, filteredShapes.Select(s => s.ToString()));
        }

        public void RemoveShapesWithPerimeterLessThan(List<Shape> shapes, double minPerimeter)
        {
            shapes.RemoveAll(s => s.Perimeter() < minPerimeter);
        }
    }
}

