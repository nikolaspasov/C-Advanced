using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string colour = input.Split(" -> ")[0];
                string clothes = input.Split(" -> ")[1];
                string[] clothesArr = clothes.Split(",").ToArray();

                if (dict.ContainsKey(colour))
                {
                    for (int j = 0; j < clothesArr.Length; j++)
                    {
                        if (dict[colour].ContainsKey(clothesArr[j]))
                        {
                            dict[colour][clothesArr[j]]++;
                        }
                        else
                        {
                            dict[colour].Add(clothesArr[j], 1);
                        }

                    }
                }
                else
                {
                    dict.Add(colour, new Dictionary<string, int>());
                    for (int j = 0; j < clothesArr.Length; j++)
                    {
                        if (dict[colour].ContainsKey(clothesArr[j]))
                        {
                            dict[colour][clothesArr[j]]++;
                        }
                        else

                        {
                            dict[colour].Add(clothesArr[j], 1);
                        }
                    }
                }
            }

            string combination = Console.ReadLine();
            string combinationColour = combination.Split(" ")[0];
            string combinationProduct = combination.Split(" ")[1];

            foreach (var colour in dict)
            {
                Console.WriteLine(colour.Key + " clothes:");
                foreach (var clothing in colour.Value)
                {

                    if (colour.Key == combinationColour && clothing.Key == combinationProduct)
                    {
                        Console.WriteLine("* " + clothing.Key + " - " + clothing.Value + " (found!)");

                    }
                    else
                    {
                        Console.WriteLine("* " + clothing.Key + " - " + clothing.Value);
                    }


                }
            }
        }
    }
}
