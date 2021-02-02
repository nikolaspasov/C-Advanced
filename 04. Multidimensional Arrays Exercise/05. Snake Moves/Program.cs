using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            int rows = int.Parse(size.Split(" ")[0]);
            int columns = int.Parse(size.Split(" ")[1]);

            char[,] matrix = new char[rows, columns];

            string word = Console.ReadLine();
            List<char> snake = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                snake.Add(char.Parse(word[i].ToString()));
            }
            int counter = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = columns - 1; j >= 0; j--)
                    {
                        
                        if(counter>=word.Length)
                        {
                            counter = 0;
                        }
                        matrix[i, j] = snake[counter];
                        counter++;
                    }
                    
                }
                else
                {
                    for (int j = 0; j < columns; j++)
                    {
                        
                        if(counter>=word.Length)
                        {
                            counter = 0;
                        }
                        matrix[i, j] = snake[counter];
                        counter++;
                    }
                    
                }
                for (int k= 0; k < columns; k++)
                {
                    Console.Write(matrix[i,k]);
                }
                Console.WriteLine();
            }

        }
    }
}
