using System;

namespace CSharp7Demos
{
    [Demo("Out Variables")]
    public class OutVariableDemo : IMenuEntry
    {
        public void Execute()
        {
            ReturnManyValues(out int a, out int b, out string s);
            Console.WriteLine($"a:{a}, b:{b}, s:{s}");

            void ReturnManyValues(out int x, out int y, out string z)
            {
                x = 10;
                y = 20;
                z = "Hello";
            }
        }
    }
}