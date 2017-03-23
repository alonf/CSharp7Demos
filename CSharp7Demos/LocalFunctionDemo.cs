using System;

namespace CSharp7Demos
{
    [Demo("Local Function")]
    public class LocalFunctionDemo : IMenuEntry
    {
        public void Execute()
        {
            int[] numbers = { 0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000 };
            var (sum, count) = Tally(numbers);
            Console.WriteLine($"Sum: {sum}, count: {count}");

            (int sum, int count) Tally(int[] values)
            {
                var r = (s: 0, c: 0);
                foreach (var v in values)
                {
                    Add(v, 1);
                }
                return r;

                void Add(int s, int c) { r.s += s; r.c += c; }
            }
        }
    }

    [Demo("Pattern Matching is assignemnt")]
    public class PatternMatchingIsDemo : IMenuEntry
    {
        public void Execute()
        {
            var data = "Alon";
            Print();
            data = null;
            Print();

            void Print()
            {
                if (data is string text)
                {
                    Console.WriteLine(text);
                }
            }
        }
    }

    [Demo("Pattern Matching Constant")]
    public class PatternMatchingConstantDemo : IMenuEntry
    {
        public void Execute()
        {
            var data = DayOfWeek.Monday;
            Print();
            data = DayOfWeek.Thursday;
            Print();

            void Print()
            {
                if (data is DayOfWeek.Monday)
                {
                    Console.WriteLine("Monday");
                }

                if (data is DayOfWeek.Thursday)
                {
                    Console.WriteLine("Thursday");
                }
            }

            object o = null;
            if (o is null)
            {
                Console.WriteLine("null");
            }
            int x = 42;
            if (!(x is int.MaxValue))
                Console.WriteLine("x is not max integer value");
        }
    }

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