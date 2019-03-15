using System;

namespace _2._05.CombinationsWithoutRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int index = 0;
            int border = 1;
            int[] vector = new int[k];

            PrintCombinations(vector, index, border, n);

        }

        private static void PrintCombinations(int[] vector, int index, int border, int n)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = border; i <= n; i++)
                {
                    vector[index] = i;
                    PrintCombinations(vector, index + 1, i + 1, n);
                }
            }
        }
    }
}
