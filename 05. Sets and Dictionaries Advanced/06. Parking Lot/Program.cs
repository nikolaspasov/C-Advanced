using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            HashSet<string> hashSet = new HashSet<string>();
            while(command!="END")
            {
                string action = command.Split(", ")[0];
                string number = command.Split(", ")[1];
                if (action == "IN")
                {
                    hashSet.Add(number);
                }
                else if (hashSet.Contains(number))
                {
                    hashSet.Remove(number);
                    
                }

                command = Console.ReadLine();
            }
            if(hashSet.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in hashSet)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
