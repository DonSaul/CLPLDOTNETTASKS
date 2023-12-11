using System;
namespace Homework_4.src.Core.Entities
{
    public abstract class Shape
    {
        public string Name { get; protected set; }

        protected Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return $"Shape: {Name}";
        }
        
    }
}

