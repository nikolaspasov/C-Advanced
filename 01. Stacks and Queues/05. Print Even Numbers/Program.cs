using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(array);

            while(queue.Count>1)
            {
                if(queue.Peek()%2==0)
                {
                    Console.Write(queue.Dequeue()+", ");
                }
                else
                {
                    queue.Dequeue();
                }
            }
            if(queue.Count==1&&queue.Peek()%2==0)
            {
                Console.WriteLine(queue.Dequeue());
            }


        }
    }
}
