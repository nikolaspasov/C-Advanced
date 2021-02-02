using System;

namespace _04._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            int rows = int.Parse(size.Split(" ")[0]);
            int columns = int.Parse(size.Split(" ")[1]);
            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = input.Split(" ")[j];
                }
            }
            string command = Console.ReadLine();

            while (command != "END")
            {
                int commandLength = command.Split(" ").Length;
                if (command.Contains("swap")&&commandLength==5)
                {
                    int row1 = int.Parse(command.Split(" ")[1]);
                    int col1 = int.Parse(command.Split(" ")[2]);
                    int row2 = int.Parse(command.Split(" ")[3]);
                    int col2 = int.Parse(command.Split(" ")[4]);

                    

                    if (row1 + 1 <= rows && col1 + 1 <= columns && row2 < rows && col2 < columns
                        && row1 >= 0 && col1 >= 0 && row2 >= 0 && col2 >= 0&& commandLength==5)
                    {
                        string firstValue = matrix[row1, col1];
                        string secondValue = matrix[row2, col2];

                        matrix[row1, col1] = secondValue;
                        matrix[row2, col2] = firstValue;

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
