using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Dating_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            string malesInput = Console.ReadLine();
            string femalesInput = Console.ReadLine();
            int matches = 0;


            Stack<int> males = new Stack<int>
                (malesInput.Split(" ").Select(int.Parse));
            Queue<int> females = new Queue<int>
                (femalesInput.Split(" ").Select(int.Parse));

            while (males.Count>=1&&females.Count>=1)
            {
                int currMale = males.Peek();
                int currFemale = females.Peek();
                if (currMale <= 0)
                {
                    males.Pop();
                   
                    continue;
                }
                if (currFemale <= 0)
                {
                    females.Dequeue();
                    
                    continue;
                }
                if (currMale % 25 == 0)
                {
                    if (males.Count > 1)
                    {
                        males.Pop();
                        males.Pop();
                    }
                    else if (males.Count == 1)
                    {
                        males.Pop();
                    }
                    continue;
                }
                if (currFemale % 25 == 0)
                {
                    if (females.Count > 1)
                    {

                        females.Dequeue();
                        females.Dequeue();
                    }
                    else if(females.Count==1)
                    {
                        females.Dequeue();
                    }
                    continue;
                }
                if (currMale == currFemale)
                {
                    matches++;
                    males.Pop();
                    females.Dequeue();
                }
                else if (currMale != currFemale)
                {
                    females.Dequeue();
                    currMale -= 2;
                    males.Pop();
                    males.Push(currMale);
                }
            }
            Console.WriteLine("Matches: "+matches);
            if(males.Any())
            {
                Console.Write("Males left: ");
                Console.Write(string.Join(", ",males));
            }
            else
            {
                Console.Write("Males left: none");
            }
            Console.WriteLine();
            if(females.Any())
            {
                Console.Write("Females left: ");
                Console.Write(string.Join(", ",females));
            }
            else
            {
                Console.Write("Females left: none");
            }

        }
    }
}
