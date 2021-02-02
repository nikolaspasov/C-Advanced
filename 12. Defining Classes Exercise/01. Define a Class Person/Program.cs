using DefiningClasses;
using System;
using System.Collections.Generic;

namespace DefiningClasses
{
  public class StartUp
    {
       public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person pesho = new Person("Pesho",26);
            people.Add(pesho);
            

            Person gosho = new Person("Gosho",12);
            people.Add(gosho);
            

            Person gogo = new Person("Gogo",40);
            people.Add(gogo);


            foreach (var person in people)
            {
                Console.WriteLine(person.Name+" "+person.Age);
            }
        }
    }
}
