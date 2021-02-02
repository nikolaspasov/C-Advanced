using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._Streams__Files_and_Directories_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader("../../../input.txt");
            using (reader)
            {
                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    string text = reader.ReadLine();

                    int counter = 0;

                    while (text != null)
                    {
                        text = text.Replace('-', '@');
                        text = text.Replace(',', '@');
                        text = text.Replace('.', '@');
                        text = text.Replace('!', '@');
                        text = text.Replace('?', '@');

                        if (counter % 2 == 0)
                        {
                            List<string> array = text.Split().Reverse().ToList();
                            Console.WriteLine(string.Join(" ",array));
                        }
                        text = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
