using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp7Demos
{
    abstract class Shape
    {
    }

    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Height { get; set; }
    }

    class Circle : Shape
    {
        public int Radius { get; set; }
    }

    class Triangle : Shape
    {
    }
}
