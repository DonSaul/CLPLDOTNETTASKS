using System;
using Homework_4.src.Core.Entities;


	public class Solver
	{
        public List<Shape> FilterShapesByArea(List<Shape> shapes, double minArea, double maxArea)
        {
            return shapes.Where(s => s.Area() >= minArea && s.Area() <= maxArea).ToList();
        }

        public List<Shape> FilterShapesByName(List<Shape> shapes, string character)
        {
            return shapes.Where(s => s.Name.Contains(character)).ToList();
        }

        public void RemoveShapesByPerimeter(ref List<Shape> shapes, double minPerimeter)
        {
            shapes.RemoveAll(s => s.Perimeter() < minPerimeter);
        }
    }


