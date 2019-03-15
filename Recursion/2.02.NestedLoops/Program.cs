using System;

namespace _2._02.NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] vector = new int[number];
            int index = 0;
            NestedLoops(vector, index);
        }

        private static void NestedLoops(int[] vector, int index)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = 1; i <= vector.Length; i++)
                {
                    vector[index] = i;
                    NestedLoops(vector, index + 1);
                }
            }
        }
    }
}
