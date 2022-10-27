using System;
using System.Collections.Generic;

namespace _5._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while(true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                    break;

                Student student = new Student(input[0], input[1], int.Parse(input[2]), input[3]);

                bool exist = false;

                foreach(Student st in students)
                {

                    //Console.WriteLine($"{st.FirstName}{input[0]}");
                    //Console.WriteLine($"{st.LastName}{input[1]}");

                    if ((st.FirstName==input[0]) && (st.LastName==input[1]))
                    {
                        st.FirstName = input[0];
                        st.LastName = input[1];
                        st.Age = int.Parse(input[2]);
                        st.Town = input[3];

                        exist = true;
                    }

                }

                if (!exist)
                {
                    students.Add(student);
                }
            }

            string homeTown = Console.ReadLine();
            
            for(int i=0; i<students.Count; i++)
            {
                Student currentStudent = students[i];

                if(currentStudent.Town==homeTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
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
