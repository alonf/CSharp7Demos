using System;

namespace CSharp7Demos
{
    [Demo("Throw Exceptions")]
    public class ThrowExceptionsDemo : IMenuEntry
    {
        class Person
        {
            public string Name { get; }

            public Person(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

            public string GetFirstName()
            {
                var parts = Name.Split(' ');
                return (parts.Length > 1) ? parts[0] : throw new InvalidOperationException("No name!");
            }

            public string GetLastName() => throw new NotImplementedException();
        }
        public void Execute()
        {
            try
            {
                var p = new Person(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                var p = new Person("Fliess");
                p.GetFirstName();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                var p = new Person("Alon");
                p.GetLastName();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }



        }
    }
}