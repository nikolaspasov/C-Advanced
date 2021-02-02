using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>(input.Split());

            int n = int.Parse(Console.ReadLine());

           while(queue.Count>1)
            {
                for (int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine("Removed "+queue.Dequeue());

            }
            Console.WriteLine("Last is "+queue.Dequeue());
        }
    }
}
