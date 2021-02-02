using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            int numbersToAdd = int.Parse(input.Split()[0]);
            int numbersToRemove = int.Parse(input.Split()[1]);
            int numbersToSearchFor = int.Parse(input.Split()[2]);

            int[] numArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < numbersToAdd; i++)
            {
                numbers.Enqueue(numArray[i]);
            }
            for (int i = 0; i < numbersToRemove; i++)
            {
                numbers.Dequeue();
            }
            
            if(numbers.Contains(numbersToSearchFor))
            {
                Console.WriteLine("true");
            }
            else if(numbers.Count>0)
            {
                
                Console.WriteLine(numbers.Min());
            }
            else
            {
                Console.WriteLine(0);
            }    
        }
    }
}
