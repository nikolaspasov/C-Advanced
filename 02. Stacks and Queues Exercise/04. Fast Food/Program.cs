using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);

            int biggest = queue.Max();

            for (int i = 0; i < orders.Length; i++)
            {
                if(quantity-orders[i]>=0)
                {
                    
                    quantity -= orders[i];
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine(biggest);
                    Console.Write("Orders left:");
                    while(queue.Count>0)
                    {
                      
                        Console.Write(" "+queue.Dequeue());
                        
                    }
                    return;
                }
            } 
            Console.WriteLine(biggest);
            Console.WriteLine("Orders complete");
        }
    }
}
