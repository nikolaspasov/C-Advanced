using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] array = input.Split().ToArray();

            Stack<string> stack = new Stack<string>(array.Reverse());
            int sum = 0;
            string command = "+";
            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operation = (stack.Pop());
                int second = int.Parse(stack.Pop());


                if (operation == "+")
                {
                    stack.Push((first + second).ToString());
                }
                else if (operation == "-")
                {
                    stack.Push((first - second).ToString());
                }

            }
            Console.WriteLine(stack.Pop());
        }

    }
}
