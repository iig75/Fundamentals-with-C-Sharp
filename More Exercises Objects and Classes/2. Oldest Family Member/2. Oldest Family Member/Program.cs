using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Family family = new Family();

            family.addMember(N);

            family.GetOldestMember();

        }
    }



    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }



    class Family
    {
        public List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }

        public List<Person> FamilyMembers
            => this.members;

        public void addMember(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string personName = input[0];
                int personAge = int.Parse(input[1]);

                Person person = new Person(personName, personAge);

                this.members.Add(person);
            }
        }



        public void GetOldestMember()
        {
            foreach (var val in this.members.OrderByDescending(x => x.Age))
            {
                Console.WriteLine($"{val.Name} {val.Age}");
                break;
            }
        }


    }
}



