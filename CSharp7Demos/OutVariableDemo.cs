using System;

namespace CSharp7Demos
{
    [Demo("Out Variables")]
    public class OutVariableDemo : IMenuEntry
    {
        public void Execute()
        {
            ReturnManyValues(out int a, out int b, out string s);
            Console.WriteLine($"a:{a}, b:{b}, s:{s}");

            void ReturnManyValues(out int x, out int y, out string z)
            {
                x = 10;
                y = 20;
                z = "Hello";
            }
        }
    }

    [Demo("Ref Return and ref local")]
    public class RefReturnAndLocalDemo : IMenuEntry
    {
        public ref int Find(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i]; // return the storage location, not the value
                }
            }
            throw new IndexOutOfRangeException($"{nameof(number)} not found");
        }

        public void Execute()
        {
            int[] array = { 1, 15, -39, 0, 7, 14, -12 };
            ref int place = ref Find(7, array); // aliases 7's place in the array
            Console.WriteLine(array[4]); // prints 7
            place = 9; // replaces 7 with 9 in the array
            Console.WriteLine(array[4]); // prints 9
        }
    }
}