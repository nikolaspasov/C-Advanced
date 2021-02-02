using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numberDict = new Dictionary<int, int>();



            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(numberDict.ContainsKey(number))
                {
                    numberDict[number]++;

                    
                }
                else
                {
                    numberDict.Add(number, 1);
                }
            }
            foreach (var number in numberDict)
            {
                if(number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                    return;
                }
            }
            
        }
    }
}
