using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dict 
                = new Dictionary<string, Dictionary<string,List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string continent = input.Split(" ")[0];
                string country = input.Split(" ")[1];
                string city = input.Split(" ")[2];

                if(dict.ContainsKey(continent))
                {
                    if(dict[continent].ContainsKey(country))
                    {
                        dict[continent][country].Add(city);              
                    }
                    else
                    {
                        dict[continent].Add(country, new List<string>());
                        dict[continent][country].Add(city);
                    }
                }
                else
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                    dict[continent].Add(country, new List<string>());
                    dict[continent][country].Add(city);
                }
            }
            
            foreach (var continent in dict)
            {
                Console.WriteLine(continent.Key+":");
                foreach (var country in continent.Value)
                {
                    Console.Write("  "+country.Key+" -> ");
                    int index = country.Value.Count;
                    int counter = 0;
                    foreach (var city in country.Value)
                    {
                        Console.Write(city);
                        if (counter==index-1)
                        {

                        }
                        else
                        {
                            Console.Write(", ");
                        }
                            counter++;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
