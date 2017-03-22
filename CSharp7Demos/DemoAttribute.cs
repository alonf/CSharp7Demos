using System;

namespace CSharp7Demos
{
    public class DemoAttribute : Attribute
    {
        public DemoAttribute(string menuEntry)
        {
            Text = menuEntry;
        }

        public string Text { get; }
    }
}