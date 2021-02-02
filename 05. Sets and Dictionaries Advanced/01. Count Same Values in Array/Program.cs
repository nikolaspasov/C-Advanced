using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < input.Count; i++)
            {
                if(dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                }
                else
                {
                    dict.Add(input[i], 1);                      
                }
            }
            foreach (var element in dict)
            {
                Console.WriteLine(element.Key+ " - " +element.Value+" times");
            }
        }
    }
}
