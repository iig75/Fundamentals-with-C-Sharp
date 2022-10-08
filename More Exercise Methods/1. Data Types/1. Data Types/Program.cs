using System;

namespace _1._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            if(str1=="int")
            {
                Console.WriteLine(DataType(int.Parse(str2)));
            }

            if (str1 == "real")
            {
                double res = DataType(double.Parse(str2));
                Console.WriteLine($"{res:f2}");
            }

            if (str1 == "string")
            {
                Console.WriteLine(DataType(str2));
            }
        }



        private static int DataType(int str2)
        {
            int res = 0;
            res = str2 * 2;

            return res;
        }



        private static double DataType(double str2)
        {
            double res = 0;
            res = str2 * 1.5;

            return res;
        }



        private static string DataType(string str2)
        {
            string res = string.Empty;
            res = "$" + str2 + "$";

            return res;
        }
    }
}
