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
            using (wordReader)
            {
                while (wordReader != null)
                {
                    string inputWords = wordReader.ReadLine();
                    if (inputWords == null)
                    {
                        break;
                    }
                    wordsList.Add(inputWords);
                    
                }

            }
            StreamReader textReader = new StreamReader("../../../Text.txt");
            Dictionary<string, int> wordsDict = new Dictionary<string, int>();

            foreach (var word in wordsList)
            {
                wordsDict.Add(word, 0);
            }
            using (textReader)
            {
                while (textReader != null)
                {
                    string line = textReader.ReadLine();
                    if(line==null)
                    {
                        break;

                    }
                    List<string> lineList = line.ToLower().Split(new char[] { ',', '.', '-', ' ' }).ToList();

                    for (int i = 0; i < lineList.Count; i++)
                    {

                        if (lineList[i] == "quick")
                        {
                            wordsDict["quick"] += 1;
                        }
                        else if (lineList[i] == "is")
                        {
                            wordsDict["is"]+=1;
                        }
                        else if (lineList[i] == "fault")
                        {
                            wordsDict["fault"] +=1;
                        }
                    }
                }

            }

            wordsDict = wordsDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                foreach (var element in wordsDict)
                {
                    writer.WriteLine(element.Key + " - " + element.Value);
                }
            }
              
        
        
        
        
        }
    }
}
  

        

    



