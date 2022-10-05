using System;

namespace _2._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine(grade(n));
        }

        private static string grade(double n)
        {
            string str="";

            if ((n >= 2.00) && (n <= 2.99))
            {
                str = "Fail";
            }

            if ((n >= 3.00) && (n <= 3.49))
            {
                str = "Poor";
            }

            if ((n >= 3.50) && (n <= 4.49))
            {
                str = "Good";
            }

            if ((n >= 4.50) && (n <= 5.49))
            {
                str = "Very good";
            }

            if ((n >= 5.50) && (n <= 6.00))
            {
                str = "Excellent";
            }

            return str;
        }
    }
}
