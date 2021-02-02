using System;

namespace _02._Snake_Help
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int snakeRow = -1;
            int snakeCol = -1;
            int firstBurrowRow = -1;
            int firstBurrowCol = -1;
            int secondBurrowRow = -1;
            int secondBurrowCol = -1;
            bool isFed = false;
            for (int rows = 0; rows < size; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'S')
                    {
                        snakeRow = rows;
                        snakeCol = cols;
                    }
                    if (matrix[rows, cols] == 'B')
                    {
                        if (firstBurrowRow == -1)
                        {
                            firstBurrowRow = rows;
                            firstBurrowCol = cols;
                        }
                        else
                        {
                            secondBurrowRow = rows;
                            secondBurrowCol = cols;
                        }
                    }
                }

            }

            int foodEaten = 0;
            matrix[snakeRow, snakeCol] = '.';
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "left")
                {
                    snakeCol--;
                }
                else if (command == "right")
                {
                    snakeCol++;
                }
                else if (command == "down")
                {
                    snakeRow++;
                }
                else if (command == "up")
                {
                    snakeRow--;
                }
                if (snakeRow < size && snakeRow >= 0 && snakeCol < size && snakeCol >= 0)

                {
                    if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodEaten++;
                        matrix[snakeRow, snakeCol] = '.';
                    }
                    else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        
                        if (firstBurrowRow == snakeRow && firstBurrowCol == snakeCol)
                        {
                            snakeRow = secondBurrowRow;
                            snakeCol = secondBurrowCol;
                           
                        }
                        else
                        {
                            snakeRow = firstBurrowRow;
                            snakeCol = firstBurrowCol;
                            
                        }
                        matrix[firstBurrowRow, firstBurrowCol] = '.';
                        matrix[secondBurrowRow, secondBurrowCol] = '.';

                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                    }
                }
                else
                {
                    break;
                }
                if (foodEaten >= 10)
                {
                    isFed = true;
                    Console.WriteLine("You won! You fed the snake.");
                    matrix[snakeRow, snakeCol] = 'S';
                    break;
                }

            }
            if (isFed == false)
            {
                Console.WriteLine("Game over!");

            }
            Console.WriteLine("Food eaten: " + foodEaten);
            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }


        }
    }
}
