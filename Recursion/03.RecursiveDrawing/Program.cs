using System;

namespace _03.RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Draw(num);
        }

        private static void Draw(int number)
        {
            if (number <= 0)
            {
                return;
            }

            Console.WriteLine(new string('*', number));

            Draw(number - 1);

            Console.WriteLine(new string('#', number));
        }
    }
}
