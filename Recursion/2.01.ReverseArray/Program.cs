using System;
using System.Linq;

namespace _01.ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstPosition = 0;
            int lastPostion = array.Length - 1;
            ReverseArray(array, firstPosition, lastPostion);
            Console.WriteLine(string.Join(" ", array));
        }

        private static void ReverseArray(int[] array, int firstPosition, int lastPostion)
        {
            if (firstPosition < lastPostion)
            {
                int temp = array[firstPosition];
                array[firstPosition] = array[lastPostion];
                array[lastPostion] = temp;

                ReverseArray(array, firstPosition + 1, lastPostion - 1);
            }
        }
    }
}
