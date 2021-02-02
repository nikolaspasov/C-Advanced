using System;

namespace _05._Square_With_Maximum_Sum
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
                    matrix[i, j] = int.Parse(input.Split(", ")[j]);
                }
            }

            int[,] submatrix = new int[2, 2];
            int sum = 0;
            int maxSum = int.MinValue;
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {

                    if (rows > row + 1 && columns > column + 1)
                    {
                        sum = matrix[row, column]
                       + matrix[row, column + 1]
                       + matrix[row + 1, column]
                       + matrix[row + 1, column + 1];
                        if (sum > maxSum)
                        {
                            Array.Clear(submatrix, 0, submatrix.Length);
                            submatrix[0, 0] = matrix[row, column];
                            submatrix[0, 1] = matrix[row, column + 1];
                            submatrix[1, 0] = matrix[row + 1, column];
                            submatrix[1, 1] = matrix[row + 1, column + 1];
                            maxSum = sum;
                        }
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(submatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
