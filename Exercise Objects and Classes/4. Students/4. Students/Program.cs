using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for(int i=1; i<=n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                Student student = new Student(input[0], input[1], double.Parse(input[2]));

                students.Add(student);

                students = students.OrderByDescending(x => x.Grade).ToList();
            }

            for(int i=0; i<students.Count; i++)
            {
                Student currentStudent = students[i];

                Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName}: {currentStudent.Grade:f2}");
            }
        }
    }



    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
}
