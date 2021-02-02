using System;

namespace _02._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeString = Console.ReadLine();
            int rows = int.Parse(sizeString.Split(" ")[0]);
            int columns = int.Parse(sizeString.Split(" ")[1]);
            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = input.Split(" ")[j];
                }
            }
            int counter = 0;
            for (int rowNum = 0; rowNum < rows; rowNum++)
            {

                for (int columnNum = 0; columnNum < columns; columnNum++)
                {
                    if (rowNum  < rows-1&& columnNum  <columns-1)
                    {
                        if (matrix[rowNum, columnNum] == matrix[rowNum, columnNum + 1]
                            && matrix[rowNum, columnNum] == matrix[rowNum + 1, columnNum]
                            && matrix[rowNum, columnNum] == matrix[rowNum + 1, columnNum + 1])
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
