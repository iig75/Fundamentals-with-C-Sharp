using System;

namespace _1._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                string str = Console.ReadLine();

                string name = str.Substring(str.IndexOf('@')+1,str.IndexOf('|') - str.IndexOf('@')-1);
                string age = str.Substring(str.IndexOf('#')+1, str.IndexOf('*') - str.IndexOf('#')-1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
