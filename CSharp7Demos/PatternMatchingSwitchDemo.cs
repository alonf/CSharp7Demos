using System;

namespace CSharp7Demos
{
    [Demo("Pattern Matching Switch on Type")]
    public class PatternMatchingSwitchDemo : IMenuEntry
    {
        private abstract class Shape 
        {
            
        }

        private class Rectangle : Shape
        {
            public int Length { get; set; }
            public int Height { get; set; }
        }

        private class Circle : Shape
        {
            public int Radius { get; set; }
        }

        private class Triangle : Shape
        {
        }

        public void Execute()
        {
            Shape shape = new Rectangle {Height = 20, Length = 20};
            Test();
            ((Rectangle) shape).Height = 10;
            Test();
            shape = new Circle() {Radius = 5};
            Test();
            shape = new Triangle();
            Test();
            shape = null;
            Test();

            void Test()
            {
                switch (shape) // Switch on anything
                {
                    case Rectangle s when (s.Length == s.Height): // when-condition
                        Console.WriteLine($"{s.Length} x {s.Height} square");
                        break;
                    case Rectangle r:
                        Console.WriteLine($"{r.Length} x {r.Height} rectangle");
                        break;
                    case Circle c: // Type pattern
                        Console.WriteLine($"circle with radius {c.Radius}"); // use c
                        break;
                    case null:
                        throw new ArgumentNullException(nameof(shape));
                    default:
                        Console.WriteLine("<unknown shape>");
                        break;
                }
            }
        }
    }
}