using System;

namespace _02._Present_delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPresents = int.Parse(Console.ReadLine());

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int santaRow = -1;
            int santaCol = -1;
            int totalNiceKids = 0;
            int happyKids = 0;
            
            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = char.Parse(input.Split(" ")[col]);
                    if (matrix[row, col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;

                    }
                    if (matrix[row, col] == 'V')
                    {
                        totalNiceKids++;
                    }
                }
            }
            matrix[santaRow, santaCol] = '-';
            while (true)
            {
                //matrix[santaRow, santaCol] = '-';
                
                string command = Console.ReadLine();
                if (command == "Christmas morning")
                {
                    matrix[santaRow, santaCol] = 'S';
                    break;
                }
                if (totalPresents <= 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break; }
                
                if (command == "up")
                {
                    santaRow--;
                }
                else if (command == "down")
                {
                    santaRow++;
                }
                else if (command == "left")
                {
                    santaCol--;
                }
                else if (command == "right")
                {
                    santaCol++;
                }

                if (santaRow < size && santaRow >= 0 && santaCol < size && santaCol >= 0)
                {
                    if (matrix[santaRow, santaCol] == 'C')
                    {
                       matrix[santaRow, santaCol] = 'S';
                        if (matrix[santaRow, santaCol - 1] == 'V' || matrix[santaRow, santaCol - 1] == 'X')
                        {
                            if (matrix[santaRow, santaCol - 1] == 'V')
                            { happyKids++; }
                            matrix[santaRow, santaCol - 1] = '-';
                            totalPresents--;
                        }
                        if (totalPresents == 0)
                        {
                            Console.WriteLine("Santa ran out of presents!");
                            break;
                        }

                        if (matrix[santaRow, santaCol + 1] == 'V' || matrix[santaRow - 1, santaCol + 1] == 'X')
                        {
                            if (matrix[santaRow, santaCol + 1] == 'V')
                            {
                                happyKids++;
                            }
                            matrix[santaRow, santaCol + 1] = '-';
                            totalPresents--;
                        }
                        if (totalPresents == 0)
                        {
                            Console.WriteLine("Santa ran out of presents!");
                            break;
                        }
                        if (matrix[santaRow - 1, santaCol] == 'V' || matrix[santaRow - 1, santaCol] == 'X')
                        {
                            if (matrix[santaRow - 1, santaCol] == 'V')
                            { happyKids++; }
                            totalPresents--;
                            matrix[santaRow-1, santaCol ] = '-';
                        }
                        if (totalPresents == 0)
                        {
                            Console.WriteLine("Santa ran out of presents!");
                            break;
                        }
                        if (matrix[santaRow + 1, santaCol] == 'V' || matrix[santaRow + 1, santaCol] == 'X')
                        {
                            if (matrix[santaRow + 1, santaCol] == 'V')
                            { happyKids++; }
                            matrix[santaRow+1, santaCol ] = '-';
                            totalPresents--;
                        }
                        
                       
                        if (totalPresents == 0)
                        {
                            Console.WriteLine("Santa ran out of presents!");
                            break;
                        }


                    }
                    else if (matrix[santaRow, santaCol] == 'V')
                    {
                        happyKids++;
                        totalPresents--;
                        matrix[santaRow, santaCol] = '-';
                    }
                    else if(matrix[santaRow,santaCol]=='X')
                    {
                        matrix[santaRow, santaCol] = '-';
                    }
                    

                }
                if (totalPresents == 0)
                {
                    
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }
                //for (int row = 0; row < size; row++)
                //{

                //    for (int col = 0; col < size; col++)
                //    {
                //        Console.Write(matrix[row, col] + " ");
                //    }
                //    Console.WriteLine();
                //}

            }
            matrix[santaRow, santaCol] = 'S';
            for (int row = 0; row < size; row++)
            {
               
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]+ " ");
                }
                Console.WriteLine();
            }
            if (happyKids == totalNiceKids)
            {
                Console.WriteLine("Good job, Santa! "+totalNiceKids +" happy nice kid/s.");
            }
            else
            {
                Console.WriteLine("No presents for "+(totalNiceKids-happyKids)+" nice kid/s.");
            }

        }
    }
}
