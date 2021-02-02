using System;
using System.IO;

namespace Streams__Files_and_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../Input.txt");
            int counter = 0;
            string line = "";
            using (reader)
            {
                line = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
