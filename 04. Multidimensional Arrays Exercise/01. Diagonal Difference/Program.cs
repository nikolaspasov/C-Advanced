using System;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(input.Split(" ")[j]);
                }
            }
            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    if(row==column)
                    {
                        primarySum += matrix[row, column];
                    }
                }
            }
            int columnNum= 0;
            for (int row =size-1; row >= 0; row--)
            {
                
                    secondarySum += matrix[row, columnNum];
                columnNum++;
            }
            Console.WriteLine(Math.Abs(primarySum-secondarySum));
        }
    }
}
