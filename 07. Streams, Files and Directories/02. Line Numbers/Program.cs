using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader("../../../Input.txt");

            using(reader)
            {
                string line = reader.ReadLine();
                int counter = 1;

                using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
                {
                    while (line != null)
                    {

                        writer.WriteLine(counter + ". " + line);
                        line = reader.ReadLine();
                        counter++;
                    }
                }
               
               
            }
        }
    }
}
