using System;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizes = Console.ReadLine();

            int n = int.Parse(sizes.Split(" ")[0]);
            int m = int.Parse(sizes.Split(" ")[1]);

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            string input = "";

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                firstSet.Add(int.Parse(input));
            }
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine();
                secondSet.Add(int.Parse(input));
            }
            foreach (var number in firstSet)
            {
                if(secondSet.Contains(number))
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}
