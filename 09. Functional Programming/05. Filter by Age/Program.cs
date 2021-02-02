using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _05._Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> names = new Dictionary<string, int>();



            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string name = input.Split(", ")[0];
                int age =int.Parse(input.Split(", ")[1]);

                names.Add(name, age);
            }
            string condition = Console.ReadLine();
            int conditionAge = int.Parse(Console.ReadLine());
            string filter = Console.ReadLine();
            List<string> validPeople = new List<string>();

            foreach (var name in names)
            {
                string currName = name.Key;
                int currAge =int.Parse(name.Value.ToString());

                
            }


        }
    }
}
