using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace _06.ConnectedAreasInMatrix
{
    class Program
    {
        private static char[,] matrix;

        static int counter = 0;

        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfCols = int.Parse(Console.ReadLine());

            matrix = new char[numberOfRows, numberOfCols];

            FillTheMatrix(matrix);

            FindAreas();
        }

        private static void FindAreas()
        {
            int foundAreas = 0;
            List<Area> areas = new List<Area>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '-')
                    {
                        CheckArea(i, j);
                        foundAreas++;
                        areas.Add(new Area(counter, i, j));
                        counter = 0;
                    }
                }
            }

            areas = areas.OrderByDescending(x => x.Size).ThenBy(x => x.Row).ThenBy(x => x.Column).ToList();

            PrintOutput(areas, foundAreas);
        }

        private static void CheckArea(int x, int y)
        {
            if (x < 0 || y < 0 || x >= matrix.GetLength(0) || y >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[x, y] != ' ')
            {
                return;
            }

            MarkCell(x, y);
            counter++;
            CheckArea(x, y - 1); //left
            CheckArea(x + 1, y); //down
            CheckArea(x, y + 1); //right
            CheckArea(x - 1, y); //up
        }

        private static void MarkCell(int x, int y)
        {
            matrix[x, y] = 'x';
        }

        private static void FillTheMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }

        private static void PrintOutput(List<Area> areas, int foundAreas)
        {
            Console.WriteLine($"Total areas found: {foundAreas}");

            int areaPosition = 0;
            foreach (var area in areas)
            {
                Console.WriteLine($"Area #{++areaPosition}, at ({area.Row}, {area.Column}), size: {area.Size}");
            }
        }
    }

    public class Area
    {
        public Area(int size, int row, int column)
        {
            this.Size = size;
            this.Row = row;
            this.Column = column;
        }

        public int Size { get; set; }

        public int Row { get; set; }

        public int Column { get; set; }
    }
}
    