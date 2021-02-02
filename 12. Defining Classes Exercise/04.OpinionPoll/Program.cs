using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> peopleList = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string name = input.Split(" ")[0];
                int age = int.Parse(input.Split(" ")[1]);
                Person newPerson = new Person(name, age);
                peopleList.Add(newPerson);


            }
            peopleList = peopleList.Where(x=>x.Age>30).OrderBy(x => x.Name).ToList();

            foreach (var person in peopleList)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
