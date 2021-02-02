using System;
using System.Data;
using System.Resources;

namespace _02._Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input.Split(" ")[0]);
            int m = int.Parse(input.Split(" ")[1]);

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Bloom Bloom Plow")
                {
                    break;
                }

                int row = int.Parse(command.Split(" ")[0]);
                int col = int.Parse(command.Split(" ")[1]);

                if (row >= 0 && row < n && col >= 0 && col < m)
                {
                    matrix[row, col]++;
                    int currRow = row;
                    int currCol = col;
                   while(currRow>0)
                    {
                        currRow--;
                        matrix[currRow, col]++;
                    }
                    currRow = row;
                    while (currRow<n-1)
                    {
                        currRow++;
                        matrix[currRow, col]++;
                    }
                    currRow = row;
                    while (currCol>0)
                    {
                        currCol--;
                        matrix[row, currCol]++;
                    }
                    currCol = col;
                    while (currCol<m-1)
                    {
                        currCol++;
                        matrix[row, currCol]++;
                    }
                    currCol = col;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
           

        }
    }
}
