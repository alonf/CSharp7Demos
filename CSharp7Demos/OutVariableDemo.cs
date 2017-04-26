using System;

namespace CSharp7Demos
{
    [Demo("Out Variables")]
    public class OutVariableDemo : IMenuEntry
    {
        public void Execute()
        {
            // The old way
            int g;
            int e;
            string f;
            ReturnManyValues(out g, out e, out f);

            // The new way
            ReturnManyValues(out int a, out int b, out string s);
            Console.WriteLine($"a:{a}, b:{b}, s:{s}");
        }


        void ReturnManyValues(out int x, out int y, out string z)
        {
            x = 10;
            y = 20;
            z = "Hello";
        }
    }
}