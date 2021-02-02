using System;

namespace _04._Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();

            int rows = int.Parse(size.Split(", ")[0]);
            int columns = int.Parse(size.Split(", ")[1]);

            int[,] matrix = new int[rows, columns];
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(input.Split(", ")[j]);
                    sum += int.Parse(input.Split(", ")[j]);
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sum);
        }
    }
}
