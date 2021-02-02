using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

       // List<Person> people = new List<Person>();

        public Person(string name, int age)
        {
            Name = name;
            Age = age;         
        }
        //public void AddPerson(Person person)
        //{
        //    if(person.Age>=30)
        //    {
        //        people.Add(person);
        //    }
        //}

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

    }
}
