using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> PeopleList = new List<Person>();
        public void AddMember(Person newPerson)
        {
           this.PeopleList.Add(newPerson);
        }

        public Person GetOldest()
        {
            int maxAge = int.MinValue;
            Person person = null;

            foreach (var currPerson in PeopleList)
            {
                var currAge = currPerson.Age;
                if (currAge > maxAge)
                {
                    maxAge = currAge;
                    person = currPerson;
                }
            }
            return person;
        }

    }
}
