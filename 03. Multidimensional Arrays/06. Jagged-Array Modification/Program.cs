using System;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(input.Split(" ")[j]);
                }
            }
            string command = Console.ReadLine();

            while (command != "END")
            {
                int row = int.Parse(command.Split(" ")[1]);
                int column = int.Parse(command.Split(" ")[2]);
                int number = int.Parse(command.Split(" ")[3]);
                if (row < n && column < n && row > -1 && column > -1)
                {
                    if (command.Contains("Add"))
                    {
                        matrix[row, column] += number;
                    }
                    else if (command.Contains("Subtract"))
                    {
                        matrix[row, column] -= number;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
