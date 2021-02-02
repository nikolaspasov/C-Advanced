using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queue = new Queue<string>(input);

            string command = Console.ReadLine() ;

            while(queue.Count>0)
            {
                

                if(command=="Play")
                {
                    
                    queue.Dequeue();

                }
                else if(command.Contains("Add"))
                {
                    if(queue.Contains(command.Split("Add ")[1]))
                    {
                        Console.WriteLine($"{command.Split("Add ")[1]} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(command.Split("Add ")[1]);
                    }
                }
                else if(command.Contains("Show"))
                {
                    string firstElement = queue.Peek();
                    Console.Write(firstElement);
                    foreach (var element in queue)
                    {
                        if (element == firstElement)
                        {

                        }
                        else
                        {
                            Console.Write(", " + element);
                        }
                        
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
            if(queue.Count==0)
            {
                Console.WriteLine("No more songs!");
            }
        }

    }
}
