using System;
using System.Collections.Generic;

namespace _6._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string studentsName = Console.ReadLine();
                double studentsGrade = double.Parse(Console.ReadLine());

                if(!students.ContainsKey(studentsName))
                {
                    students.Add(studentsName, new List<double>());
                    students[studentsName].Add(studentsGrade);
                }
                else
                {
                    students[studentsName].Add(studentsGrade);
                }
            }

            foreach(var val in students)
            {
                double sum = 0;
                int i = 0;

                foreach(var grade in val.Value)
                {
                    sum += grade;
                    i++;
                }
                
                if((sum / i)>=4.5)
                {
                    Console.WriteLine($"{val.Key} -> {(sum / i):f2}");
                }
            }
        }
    }
}
