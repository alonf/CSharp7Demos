using System;

namespace CSharp7Demos
{
    [Demo("Local Function")]
    public class LocalFunctionDemo : IMenuEntry
    {
        public void Execute()
        {
            int[] numbers = { 0b1, 0b10, 0b100, 0b1000, 0b1_0000, 0b10_0000 };
            var (sum, count) = Tally(numbers);
            Console.WriteLine($"Sum: {sum}, count: {count}");

            (int sum, int count) Tally(int[] values)
            {
                var r = (s: 0, c: 0);
                foreach (var v in values)
                {
                    Add(v, 1);
                }
                return r;

                void Add(int s, int c) { r.s += s; r.c += c; }
            }
        }
    }
}