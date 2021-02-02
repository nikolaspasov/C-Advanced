using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();

            while(command!="Revision")
            {
                string shop = command.Split(", ")[0];
                string product = command.Split(", ")[1];
                double price = double.Parse(command.Split(", ")[2]);

                if(dict.ContainsKey(shop))
                {
                    dict[shop].Add(product, price);
                }
                else
                {
                    dict.Add(shop, new Dictionary<string, double> { });
                    dict[shop].Add(product, price);
                }
                command = Console.ReadLine();
            }
           dict= dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in dict)
            {
                Console.WriteLine(shop.Key+"->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
