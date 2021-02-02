using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();

            string listedPeople = Console.ReadLine();

            while(listedPeople!="PARTY")
            {
                char firstLetter = listedPeople[0];
                
                if(char.IsDigit(firstLetter)==true)
                {
                    vip.Add(listedPeople);
                }
                else if (listedPeople.Length == 8)
                {
                    regular.Add(listedPeople);
                }
                listedPeople = Console.ReadLine();
            }
            string guests = Console.ReadLine();

            while(guests!="END")
            {
                if(vip.Contains(guests))
                {
                    vip.Remove(guests);
                }
                else if(regular.Contains(guests))
                {
                    regular.Remove(guests);
                }
                guests = Console.ReadLine();
            }
            Console.WriteLine(vip.Count+regular.Count);

            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
