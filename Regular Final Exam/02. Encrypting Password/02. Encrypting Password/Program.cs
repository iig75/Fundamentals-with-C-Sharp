using System;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {

                string passwd = Console.ReadLine();

                string pattern1 = @"(.+)(\>)(?<pass>\d{3}\|[a-z]{3}\|[A-Z]{3}\|[^><]{3})(\<)(\1)";

                Regex regex1 = new Regex(pattern1);

                if(regex1.IsMatch(passwd))
                {
                    var matches = regex1.Matches(passwd);

                    foreach(Match m in matches)
                    {
                        string pass = m.Groups["pass"].Value;

                        pass = pass.Replace("|", "");

                        Console.WriteLine("Password: " + pass);
                    }
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
