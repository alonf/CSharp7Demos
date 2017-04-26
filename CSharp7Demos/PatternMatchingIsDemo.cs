using System;

namespace CSharp7Demos
{
    [Demo("Pattern Matching is assignemnt")]
    public class PatternMatchingIsDemo : IMenuEntry
    {
        public void Execute()
        {
            Print(new Circle() { Radius = 5 });
        }
		
        void Print(Shape shape)
        {
            Debugger.Break();

            // The old way
            var myRect = shape as Rectangle;
            if (myRect != null && myRect.Height > 2)
            {
                Console.WriteLine("Yay!");
            }

            // The new, shiny, C# 7 way
            if (shape is Rect r && r.Height > 2)
            {
                Console.WriteLine("Yay!");
            }

        }
        
    }
}