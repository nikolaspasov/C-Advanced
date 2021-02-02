using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stacks_and_Queues_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int elementsToPush = int.Parse(input.Split()[0]);
            int elementsToPop = int.Parse(input.Split()[1]);
            int elementsToLookFor = int.Parse(input.Split()[2]);

            Stack<int> numbers = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            for (int i = 0; i < elementsToPop; i++)
            {
                numbers.Pop();
            }
           
             
                if(numbers.Contains(elementsToLookFor))
            {
                Console.WriteLine("true");
            }
            else if(numbers.Count>0)
            {
                int smallestNum = numbers.Pop();
                int currNum = smallestNum;
                while(numbers.Count!=0)
                {
                    currNum = numbers.Peek();
                    if (numbers.Pop() < smallestNum)
                    {
                        smallestNum = currNum;
                    }
                }
                Console.WriteLine(smallestNum);
            }
                else
            {
                Console.WriteLine(0);
            }
        }
    }
}
