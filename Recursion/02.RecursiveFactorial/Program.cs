using System;

namespace _02.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = CalcFact(number);

            Console.WriteLine(result);
        }

        private static int CalcFact(int number)
        {
            if (number <= 0)
            {
                return 1;
            }

            return number * CalcFact(number - 1);
        }
    }
}
