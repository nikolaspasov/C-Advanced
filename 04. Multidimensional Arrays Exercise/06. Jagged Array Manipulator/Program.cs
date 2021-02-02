using System;
using System.Collections.Generic;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                jagged[i] = new int[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    jagged[i][j] = int.Parse(input[j]);
                }
            }
            for (int rowNum = 0; rowNum < rows; rowNum++)
            {
                if (rowNum + 1 < rows)
                {
                    if (jagged[rowNum].Length == jagged[rowNum + 1].Length)
                    {
                        for (int colNum = 0; colNum < jagged[rowNum].Length; colNum++)
                        {
                            jagged[rowNum][colNum] *= 2;
                            jagged[rowNum + 1][colNum] *= 2;

                        }
                    }
                    else
                    {
                        for (int colNum = 0; colNum < jagged[rowNum].Length; colNum++)
                        {
                            jagged[rowNum][colNum] /= 2;
                        }
                        for (int colNum = 0; colNum < jagged[rowNum + 1].Length; colNum++)
                        {
                            jagged[rowNum + 1][colNum] /= 2;
                        }
                    }

                }
            }
            

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command.Contains("Add"))
                {
                    int row = int.Parse(command.Split(" ")[1]);
                    int column = int.Parse(command.Split(" ")[2]);
                    int value = int.Parse(command.Split(" ")[3]);
                    if (rows > row && row >= 0 && column < jagged[row].Length && column >= 0)
                    {
                        jagged[row][column] += value;
                    }
                }
                else if (command.Contains("Subtract"))
                {
                    int row = int.Parse(command.Split(" ")[1]);
                    int column = int.Parse(command.Split(" ")[2]);
                    int value = int.Parse(command.Split(" ")[3]);
                    if (rows > row && row >= 0
                        && column <= jagged[row].Length && column >= 0)
                    {
                        jagged[row][column] -= value;
                    }
                }


                command = Console.ReadLine();
            }
            for (int rowNum = 0; rowNum < rows; rowNum++)
            {
                for (int colNum = 0; colNum < jagged[rowNum].Length; colNum++)
                {
                    Console.Write(jagged[rowNum][colNum] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
