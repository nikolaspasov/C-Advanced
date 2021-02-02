using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string car = Console.ReadLine();
            int count = 0;

            while(car!="end")
            {
                if(car=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count != 0)
                        {
                            Console.WriteLine(queue.Dequeue() + " passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(car);
                }
                car = Console.ReadLine();
            }
            Console.WriteLine(count+" cars passed the crossroads.");

        }
    }
}
