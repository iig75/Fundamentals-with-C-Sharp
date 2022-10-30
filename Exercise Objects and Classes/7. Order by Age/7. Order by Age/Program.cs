using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while(true)
            {
                List<string> data = Console.ReadLine().Split().ToList();

                if (data[0] == "End")
                    break;

                bool exist = false;

                for(int i=0; i<persons.Count; i++)
                {
                    Person currentPerson = persons[i];

                    if(String.Equals(currentPerson.PersonID, data[1]))
                    {
                        currentPerson.PersonName = data[0];
                        currentPerson.PersonAge = int.Parse(data[2]);                        
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    Person person = new Person(data[0], data[1], int.Parse(data[2]));
                    persons.Add(person);
                }
            }



            persons = persons.OrderBy(x => x.PersonAge).ToList();

            for (int i=0; i<persons.Count; i++)
            {
                Person currentPerson = persons[i];

                Console.WriteLine($"{currentPerson.PersonName} with ID: {currentPerson.PersonID} is {currentPerson.PersonAge} years old.");
            }

        }
    }



    class Person
    {
        public Person(string personName, string personID, int personAge)
        {
            PersonName = personName;
            PersonID = personID;
            PersonAge = personAge;
        }

        public string PersonName { get; set; }

        public string PersonID { get; set; }

        public int PersonAge { get; set; }
    }
}
