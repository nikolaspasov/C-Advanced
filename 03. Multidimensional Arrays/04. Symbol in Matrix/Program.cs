using System;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();

                for (int column = 0; column < n; column++)
                {
                    matrix[row, column] = input[column];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine("(" + i + ", " + j + ")");
                        return;
                    }
                }
            }
            Console.WriteLine(symbol + " does not occur in the matrix");
        }
    }
}
