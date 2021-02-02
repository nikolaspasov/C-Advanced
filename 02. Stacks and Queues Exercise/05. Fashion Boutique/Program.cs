using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> clothes = new Stack<int>(array);

            int rackCapacity = int.Parse(Console.ReadLine());

            int rackNum = 1;
            int currentNum = 0;

            for (int i = 0; i < clothes.Count; i++)
            {
                currentNum += clothes.Peek();
                if(currentNum>rackCapacity)
                {
                    rackNum++;
                    
                    currentNum = clothes.Pop();
                }
                else
                {
                    clothes.Pop();
                }
                i--;
            }
            Console.WriteLine(rackNum);
        }
       
    }
}
