using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(array);

            string command = Console.ReadLine().ToLower();
            int numsToRemove = 0;
            while (command != "end")
            {

                if (command.Split(" ")[0] == "add")
                {
                    stack.Push(int.Parse(command.Split(" ")[1]));
                    stack.Push(int.Parse(command.Split(" ")[2]));
                }
                else if (command.Split(" ")[0] == "remove")
                {
                    numsToRemove = int.Parse(command.Split(" ")[1]);
                    if (stack.Count < numsToRemove)
                    {
                        
                    }
                    else
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum: "+ stack.Sum());
           
            
        }
    }
}
