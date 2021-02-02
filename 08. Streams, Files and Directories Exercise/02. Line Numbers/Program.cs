using System;
using System.Collections.Generic;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../Input.txt");
            int count = 0;
            int letters = 0;
            int symbols = 0;
            List<string> allLines = new List<string>();
            using(reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '-' || line[i] == ':' || line[i] == ',' || line[i] == '.' ||
                            line[i] == '_' || line[i] == '?' || line[i] == '!' || line[i] == ';')
                        {
                            symbols++;
                        }
                        else if (line[i] == ' ')
                        {

                        }
                        else
                        {
                            letters++;
                        }
                    }
                   
                    allLines.Add($"Line {count + 1}: {line} ({letters})({symbols})");


                    letters = 0;
                    symbols = 0;
                    count++;
                    line = reader.ReadLine();
                }
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    foreach (var element in allLines)
                    {
                        writer.WriteLine(element);
                    }
                }


            }
        }
    }
}
