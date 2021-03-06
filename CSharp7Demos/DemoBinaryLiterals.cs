using System;

namespace CSharp7Demos
{
    [Demo("Binary Literals")]
    class BinaryLiteralsDemo : IMenuEntry
    {
        public void Execute()
        {
            Console.WriteLine($"1010 = {1010}");
            Console.WriteLine($"01010 = {01010}"); //not an octal
            Console.WriteLine($"b1010 = {0b1010}");
            Console.WriteLine($"1_01__0 = {1_01__0}");
        }
    }
}