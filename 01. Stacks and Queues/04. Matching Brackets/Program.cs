using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            string extraction = "";

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].ToString()=="(")
                {
                    stack.Push(i);
                }
                if(input[i].ToString()==")")
                {
                    int startIndex = stack.Pop();
                    for (int j = startIndex; j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
