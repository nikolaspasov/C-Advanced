using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> lettersDict = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(lettersDict.ContainsKey(input[i]))
                {
                    lettersDict[input[i]]++;
                }
                else
                {
                    lettersDict.Add(input[i], 1);
                }
            }
            foreach (var letter in lettersDict)
            {
                Console.WriteLine(letter.Key+": "+letter.Value +" time/s");
            }
        }
    }
}
