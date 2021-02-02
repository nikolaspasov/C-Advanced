using System;

namespace _03._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();

            int rows = int.Parse(size.Split(" ")[0]);
            int columns = int.Parse(size.Split(" ")[1]);
            int[,] matrix = new int[rows, columns];
            int[,] submatrix = new int[3, 3];
            int sum = 0;
            int maxSum = int.MinValue;
            
            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(input.Split(" ")[j]);
                }
            }

            for (int rowNum = 0; rowNum < rows; rowNum++)
            {
                for (int columnNum = 0; columnNum < columns; columnNum++)
                {
                    if (rowNum + 2 < rows && columnNum + 2 < columns)
                    {
                        sum = matrix[rowNum, columnNum]
                            + matrix[rowNum, columnNum + 1]
                            + matrix[rowNum, columnNum + 2]
                            + matrix[rowNum + 1, columnNum]
                            + matrix[rowNum + 1, columnNum + 1]
                            + matrix[rowNum + 1, columnNum + 2]
                            + matrix[rowNum + 2, columnNum]
                            + matrix[rowNum + 2, columnNum + 1]
                            + matrix[rowNum + 2, columnNum + 2];
                        if(sum>maxSum)
                        {
                            
                            maxSum = sum;
                            sum = 0;
                            submatrix[0, 0] = matrix[rowNum, columnNum];
                            submatrix[0, 1] = matrix[rowNum, columnNum+1];
                            submatrix[0, 2] = matrix[rowNum, columnNum+2];
                            submatrix[1, 0] = matrix[rowNum+1, columnNum];
                            submatrix[1, 1] = matrix[rowNum+1, columnNum+1];
                            submatrix[1, 2] = matrix[rowNum+1, columnNum+2];
                            submatrix[2, 0] = matrix[rowNum+2, columnNum];
                            submatrix[2, 1] = matrix[rowNum+2, columnNum+1];
                            submatrix[2, 2] = matrix[rowNum+2, columnNum+2];
                            
                        }
                    }

                }
            }
            Console.WriteLine("Sum = "+maxSum);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(submatrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
