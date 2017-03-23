using System;

namespace CSharp7Demos
{
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
}