using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Create a rectangle and a trapezoid
            Rectangle rectangle = new Rectangle { Length = 10, Width = 5 };
            Trapezoid trapezoid = new Trapezoid { Length1 = 8, Length2 = 6, Width = 4 };

            // Create rooms with these shapes
            Room<Rectangle> rectangleRoom = new Room<Rectangle> { Height = 3, Floor = rectangle };
            Room<Trapezoid> trapezoidRoom = new Room<Trapezoid> { Height = 3, Floor = trapezoid };

            // Show original room volumes
            Console.WriteLine($"Rectangle Room Volume: {rectangleRoom.Volume()}");
            Console.WriteLine($"Trapezoid Room Volume: {trapezoidRoom.Volume()}");

            // Clone the rectangle room
            Room<Rectangle> clonedRectangleRoom = (Room<Rectangle>)rectangleRoom.Clone();

            // Compare rooms
            int comparisonResult = rectangleRoom.CompareTo(clonedRectangleRoom);
            string comparisonMessage = comparisonResult == 0 ? "have the same area" : "have different areas";
            Console.WriteLine($"Original and cloned rectangle rooms {comparisonMessage}.");

            // Modify the clone and compare again
            clonedRectangleRoom.Floor.Length = 20;
            comparisonResult = rectangleRoom.CompareTo(clonedRectangleRoom);
            comparisonMessage = comparisonResult == 0 ? "have the same area" : "have different areas";
            Console.WriteLine($"After modification, original and cloned rectangle rooms {comparisonMessage}.");
        }
    }

