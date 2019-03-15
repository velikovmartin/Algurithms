using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            int result = Sum(input, index);
            Console.WriteLine(result);
        }

        private static int Sum(int[] input, int index)
        {
            if (index == input.Length)
            {
                return 0;
            }

            return input[index] + Sum(input, index + 1);
        }
    }
}
