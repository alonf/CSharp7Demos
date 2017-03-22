using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharp7Demos
{
    public class Menu
    {
        private readonly List<ValueTuple<string, IMenuEntry>> _entries;

        public Menu()
        {
            var entries = from type in Assembly.GetEntryAssembly().GetTypes()
                let att = IntrospectionExtensions.GetTypeInfo(type).GetCustomAttribute<DemoAttribute>()
                where att != null
                select (Text: att.Text, Demo: Activator.CreateInstance(type) as IMenuEntry);
            _entries = entries.ToList();
        }
        public void Run()
        {
            while (true)
            {
                Show();

                Console.WriteLine("Select menue entry:");
                int entry;
                bool r = int.TryParse(Console.ReadLine(), out entry);
                if (!r || entry < 1 || entry > _entries.Count)
                    continue;

                Console.WriteLine("\n*******************************************************");
                var (Text, Demo) = _entries[entry - 1];
                try
                {
                    Demo.Execute();
                    Console.WriteLine("\n*******************************************************\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void Show()
        {
            for (int i = 0; i < _entries.Count;++i)
            {
                var (Text, Demo) = _entries[i];
                Console.WriteLine($"{i+1}. {Text}");
            }
        }
    }
}