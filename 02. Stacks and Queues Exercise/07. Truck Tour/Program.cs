using System;
using System.Collections.Generic;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < numberOfPumps; i++)
            {
                queue.Enqueue(Console.ReadLine()+$" {i}");
            }
            int totalFuel = 0;
            for (int i = 0; i < numberOfPumps; i++)
            {
                string currInfo = queue.Dequeue();
                int newFuel = int.Parse(currInfo.Split()[0]);
                int distance = int.Parse(currInfo.Split()[1]);
                int index = int.Parse(currInfo.Split()[2]);
                totalFuel += newFuel;
                if(totalFuel>=distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i=-1;
                }
                queue.Enqueue(currInfo);
            }
            Console.WriteLine(queue.Dequeue().Split()[2]);
        }
    }
}
