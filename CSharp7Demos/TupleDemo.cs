using System;

namespace CSharp7Demos
{
    [Demo("Tuples")]
    public class TupleDemo: IMenuEntry
    {
        private (string, int) ReturnTuple()
        {
            return ("Alon", 47);
        }

        private (string Name, int Age) ReturnTuple2()
        {
            return ("Alon", 47);
        }

        public void Execute()
        {
            var oldTuple = new Tuple<int, int>(1,2);
            Console.WriteLine(oldTuple);
            Console.WriteLine($"OldTuple Item1:{oldTuple.Item1}, Item2:{oldTuple.Item2}");
            Console.Write("new Tuple: ");
            Console.WriteLine(ReturnTuple());
            
            var newTuple = (Name: "Alon", Age: 47);
            Console.WriteLine(newTuple);
            Console.WriteLine($"New Tuple Name:{newTuple.Name}, Age:{newTuple.Age}");

            var result = ReturnTuple2();
            Console.WriteLine($"Name: {result.Name}   Age:{result.Item2}");


        }
    }
}