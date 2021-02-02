using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            string command = "";

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine();

                if(command.Split()[0]=="1")
                {
                    int element = int.Parse(command.Split()[1]);
                    stack.Push(element);
                }
                else if(command.Split()[0]=="2"&&stack.Count>0)
                {
                    stack.Pop();
                }
                else if(command.Split()[0]=="3" && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if(command.Split()[0]=="4" && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
                
            }

            while (stack.Count>0)
            {
                if (stack.Count == 1)
                {
                    Console.WriteLine(stack.Pop());
                    break;
                }
                Console.Write(stack.Pop() + ", ");
                
            }
            
        }
    }
}
