using System;
using System.Collections.Concurrent;

namespace CSharp7Demos
{
    [Demo("Extended Expression Bodied Member List")]
    public class ExtendedExpressionBodiedMemberListDemo : IMenuEntry
    {
        class Person
        {
            private static ConcurrentDictionary<int, string> names = new ConcurrentDictionary<int, string>();
            private static int _ids = 0;
            private int id = GetId();

            private static int GetId() => ++_ids;
            public Person(string name) => names.TryAdd(id, name); // constructors

            ~Person() => names.TryRemove(id, out string value); // destructors

            public string Name
            {
                get  => names  [id] ; // getters
                set  => names  [id] = value; // setters
            }
        }
        
        public void Execute()
        {
            { 
                var p = new Person("Alon");
                Console.WriteLine(p.Name);
                p.Name = "alon";
                Console.WriteLine(p.Name);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}