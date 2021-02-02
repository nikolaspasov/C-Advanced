using System;
using System.Data;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int rows = 0; rows < size; rows++)
            {
                string input = Console.ReadLine();
                for (int cols = 0; cols < size; cols++)
                {
                    matrix[rows, cols] = input[cols];
                }

            }
            int foodEaten = 0;
            string command = Console.ReadLine();
            bool isOutside = false;
            bool isFed = false;
            
            while (command!="")
            {
                bool isChanged = false;
                if (command == "left")
                {
                    for (int row = 0; row < size; row++)
                    {
                        if (isOutside == true) { break; }
                        for (int col = 0; col < size; col++)
                        {
                            if (matrix[row, col] == 'S')
                            {
                                if (col - 1 >= 0)
                                {
                                    if (matrix[row, col - 1] == '*')
                                    {
                                        foodEaten++;
                                        matrix[row, col] = '.';
                                        matrix[row, col - 1] = 'S';
                                    }
                                    else if (matrix[row, col - 1] == 'B')
                                    {
                                        matrix[row, col - 1] = '.';
                                        for (int i = 0; i < size; i++)
                                        {
                                            for (int j = 0; j < size; j++)
                                            {
                                                if (matrix[i, j] == 'B')
                                                {
                                                    matrix[i, j] = 'S';
                                                }
                                            }
                                        }

                                    }
                                    else
                                    {
                                        matrix[row, col - 1] = 'S';
                                        matrix[row, col] = '.';
                                    }
                                }
                                else
                                {
                                    matrix[row, col] = '.';
                                    isOutside = true ;
                                    break;
                                }

                            }
                        }
                    }
                }
                else if (command == "right")
                {
                    for (int row = 0; row < size; row++)
                    {
                        if (isChanged == true) { break; }
                        if (isOutside == true) { break; }
                        for (int col = 0; col < size; col++)
                        {
                            if (isChanged == true) { break; }
                            if (matrix[row, col] == 'S')
                            {
                                if (col + 1 < size)
                                {
                                    if (matrix[row, col + 1] == '*')
                                    {
                                        foodEaten++;
                                        matrix[row, col] = '.';
                                        matrix[row, col + 1] = 'S';
                                        isChanged = true;
                                    }
                                    else if (matrix[row, col + 1] == 'B')
                                    {
                                        matrix[row, col + 1] = '.';
                                        for (int i = 0; i < size; i++)
                                        {
                                            for (int j = 0; j < size; j++)
                                            {
                                                if (matrix[i, j] == 'B')
                                                {
                                                    matrix[i, j] = 'S';
                                                    isChanged = true;
                                                }
                                            }
                                        }

                                    }
                                    else
                                    {
                                        matrix[row, col + 1] = 'S';
                                        matrix[row, col] = '.';
                                        isChanged = true;
                                    }
                                }
                                else
                                {
                                    matrix[row, col] = '.';
                                    isOutside =true;
                                    break;
                                }
                            }

                        }
                    }

                }
                else if (command == "down")
                {
                    for (int row = 0; row < size; row++)
                    {
                        if (isChanged == true) { break; }
                        if (isOutside == true) { break; }
                        for (int col = 0; col < size; col++)
                        {
                            if (isChanged== true) { break; }
                            if (matrix[row, col] == 'S')
                            {
                                if (row + 1 < size)
                                {
                                    if (matrix[row+1, col ] == '*')
                                    {
                                        foodEaten++;
                                        matrix[row, col] = '.';
                                        matrix[row+1, col] = 'S';
                                        isChanged = true;
                                    }
                                    else if (matrix[row+1, col] == 'B')
                                    {
                                        matrix[row+1, col ] = '.';
                                        for (int i = 0; i < size; i++)
                                        {
                                            for (int j = 0; j < size; j++)
                                            {
                                                if (matrix[i, j] == 'B')
                                                {
                                                    matrix[row, col] = '.';
                                                    matrix[i, j] = 'S';
                                                    isChanged = true;
                                                }
                                            }
                                        }

                                    }
                                    else
                                    {
                                        matrix[row+1, col] = 'S';
                                        matrix[row, col] = '.';
                                    }
                                }
                               else
                                {
                                    matrix[row, col] = '.';
                                    isOutside =true;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (command == "up")
                {
                    for (int row = 0; row < size; row++)
                    {
                        if (isOutside == true) { break; }
                        for (int col = 0; col < size; col++)
                        {
                            if (matrix[row, col] == 'S')
                            {
                                if (row - 1  >=0)
                                {
                                    if (matrix[row -1, col] == '*')
                                    {
                                        foodEaten++;
                                        matrix[row, col] = '.';
                                        matrix[row -1, col] = 'S';
                                    }
                                    else if (matrix[row -1, col] == 'B')
                                    {
                                        matrix[row-1, col] = '.';
                                        for (int i = 0; i < size; i++)
                                        {
                                            for (int j = 0; j < size; j++)
                                            {
                                                if (matrix[i, j] == 'B')
                                                {
                                                    matrix[i, j] = 'S';
                                                }
                                            }
                                        }

                                    }
                                    else
                                    {
                                        matrix[row-1, col ] = 'S';
                                        matrix[row, col] = '.';
                                    }
                                }
                                else
                                {
                                    matrix[row, col] = '.';
                                    isOutside =true;
                                    break;
                                }
                            }
                        }
                    }
                }
                if(isOutside==true)
                {
                    break;
                }
                if(foodEaten>=10)
                {
                    isFed = true;
                    break;
                }
                command = Console.ReadLine();

            }
            if(isFed==true)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            else
            {
                Console.WriteLine("Game over!");
            }
            Console.WriteLine("Food eaten: "+foodEaten);
            for (int rows = 0; rows < size; rows++)
            {
                for (int cols = 0; cols < size; cols++)
                {
                    Console.Write(matrix[rows,cols]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
