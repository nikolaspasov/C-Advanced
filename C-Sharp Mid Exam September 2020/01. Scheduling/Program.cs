using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            string tasksInput = Console.ReadLine();
            string threadsInput = Console.ReadLine();

            Stack<int> tasks = new Stack<int>(tasksInput
                .Split(", ").Select(int.Parse));
            Queue<int> threads = new Queue<int>(threadsInput
                .Split(" ").Select(int.Parse));

            int taskToKill = int.Parse(Console.ReadLine());
            int killer = 0;

            while (true)
            {
                int currTask = tasks.Peek();
                int currThread = threads.Peek();

                if(currTask==taskToKill)
                {
                    killer = currThread;
                    break;
                }
                if (currThread >= currTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (currThread < currTask)
                {
                    threads.Dequeue();

                }
            }
            Console.WriteLine($"Thread with value {killer} killed " +
                $"task {taskToKill}");
            if(threads.Any())
            {
                Console.WriteLine(string.Join(" ",threads));
            }
        }
    }
}
