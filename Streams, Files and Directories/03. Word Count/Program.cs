using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader wordReader = new StreamReader("../../../Words.txt");
            List<string> wordsList = new List<string>();
            using(wordReader)
            {
                string inputWords = wordReader.ReadLine();
                 wordsList = inputWords.Split(" ").ToList();

            }
            StreamReader textReader = new StreamReader("../../../Words.txt");
            Dictionary<string, int> wordsDict = new Dictionary<string, int>();

            foreach (var word in wordsList)
            {
                wordsDict.Add(word, 0);
            }
            using (textReader)
            {
                string line = textReader.ReadLine();
                List<string> lineList = line.Split(" ").ToList();

                for (int i = 0; i < lineList.Count; i++)
                {
                    
                    if(lineList[i]==wordsList[0])
                    {
                        wordsDict[wordsList[0]] = wordsDict[wordsList[0]]++; 
                    }
                   else if(lineList[i]==wordsList[1])
                    {
                        wordsDict[wordsList[1]] = wordsDict[wordsList[1]]++;
                    }
                   else if(lineList[i]==wordsList[2])
                    {
                        wordsDict[wordsList[2]] = wordsDict[wordsList[2]]++;
                    }
                }

            }
            StreamWriter writer = new StreamWriter("../../../Output.txt");
            wordsDict = wordsDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            using(writer)
            {
                foreach (var element in wordsDict)
                {
                    writer.WriteLine(element.Key+ " - "+element.Value);
                }
            }



                
        }
    }
}
