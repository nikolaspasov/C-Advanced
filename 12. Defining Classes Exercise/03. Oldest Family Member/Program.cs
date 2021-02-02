using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
           
            Family family = new Family();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string name = input.Split(" ")[0];
                int age = int.Parse(input.Split(" ")[1]);
                Person newPerson = new Person(name, age);

                family.AddMember(newPerson);
            }
            Person oldest = family.GetOldest();
            Console.WriteLine(oldest.Name +" "+oldest.Age);



        }
    }
}
