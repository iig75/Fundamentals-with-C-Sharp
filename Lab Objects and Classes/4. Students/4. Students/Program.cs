using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            
            while(true)
            {
                List<string> input = Console.ReadLine()
                                            .Split()
                                            .ToList();

                if (input[0] == "end")
                    break;

                Student students = new Student(input[0], input[1], int.Parse(input[2]), input[3]);

                student.Add(students);
            }

            string homeTown = Console.ReadLine();            

            for(int i=0; i<student.Count; i++)
            {
                Student currentStudents = student[i];

                if(currentStudents.Town == homeTown)
                {
                    Console.WriteLine($"{currentStudents.FirstName} {currentStudents.LastName} is {currentStudents.Age} years old.");
                }
            }
        }
    }



    class Student
    {
        public Student(string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Town = town;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }
    }



}
