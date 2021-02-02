using System;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();

            int rows = int.Parse(size.Split(", ")[0]);
            int columns = int.Parse(size.Split(", ")[1]);

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(input.Split(" ")[j]);
                }

            }

            for (int i = 0; i < columns; i++)
            {
                int sum = 0;

                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
