using System;
using System.Security.Cryptography;

namespace _07._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[,] matrix = new long[n, n];

            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }

            matrix[0, 0] = 1;
            matrix[1, 0] = 1;
            matrix[1, 1] = 1;
            Console.WriteLine(matrix[0, 0]);
            Console.Write(matrix[1, 0] + " ");
            Console.Write(matrix[1, 1]);
            Console.WriteLine();
            for (int row = 2; row < n; row++)
            {
                for (int column = 0; column < row + 1; column++)
                {
                    if (column == 0)
                    {
                        matrix[row, column] = matrix[row - 1, column];
                        Console.Write(matrix[row, column] + " ");
                    }

                    else
                    {
                        matrix[row, column] = matrix[row - 1, column] + matrix[row - 1, column - 1];
                        Console.Write(matrix[row, column] + " ");
                    }

                }
                Console.WriteLine();
            }


        }
    }
}
