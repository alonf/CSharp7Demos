using System;

namespace CSharp7Demos
{
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
}