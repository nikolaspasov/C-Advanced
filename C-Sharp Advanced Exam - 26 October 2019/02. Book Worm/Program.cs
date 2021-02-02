using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Book_Worm
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialString = Console.ReadLine();
            Stack<char> letters = new Stack<char>();
            for (int i = 0; i < initialString.Length; i++)
            {
                letters.Push(initialString[i]);
            }

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int playerRow = -1;
            int playerCol = -1;

            for (int row= 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if(matrix[row,col]=='P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
                
            }
            matrix[playerRow, playerCol] = '-';
            while(true)
            {
                string command = Console.ReadLine();
                if(command=="end")
                {
                    matrix[playerRow, playerCol] = 'P';
                    break;
                }
                if(command=="up")
                {
                    playerRow--;
                }
                else if(command=="down")
                {
                    playerRow++;
                }
                else if(command=="left")
                {
                    playerCol--;
                }
                else if(command=="right")
                {
                    playerCol++;
                }

                if(playerRow>=0&&playerRow<size&&playerCol>=0&&playerCol<size)
                {
                    if (matrix[playerRow,playerCol]!='-')
                    {
                        letters.Push(matrix[playerRow, playerCol]);
                        matrix[playerRow, playerCol] = '-';
                          
                    }

                }
                else
                {
                    if (letters.Count > 0)
                    {
                        letters.Pop();
                    }
                    switch(command)
                    {
                        case "up":playerRow++;break;
                        case "down":playerRow--;break;
                        case "left":playerCol++;break;
                        case "right":playerCol--;break;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            while(letters.Count>0)
            {
                sb.Append(letters.Pop());
            }
            for (int i = sb.Length-1; i >=0; i--)
            {
                Console.Write(sb[i]);
            }
            Console.WriteLine();

            for (int row = 0; row < size; row++)
            {
                for (int col= 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }

        }
    }
}
