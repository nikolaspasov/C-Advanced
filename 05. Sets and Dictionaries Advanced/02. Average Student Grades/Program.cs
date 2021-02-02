using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string name = input.Split(" ")[0];
                if (dict.ContainsKey(name))
                {
                    dict[name].Add(decimal.Parse(input.Split(" ")[1]));
                }
                else
                {
                    dict.Add(name, new List<decimal> { });
                    dict[name].Add(decimal.Parse(input.Split(" ")[1]));

                }
            }
            foreach (var element in dict)
            {
                Console.Write(element.Key+" -> ");
                foreach (var grade in element.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {element.Value.Average():f2})");
            }
        }
    }
}
