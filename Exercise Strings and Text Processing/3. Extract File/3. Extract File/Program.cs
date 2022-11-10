using System;

namespace _3._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string filename = str.Substring(str.LastIndexOf('\\')+1, str.LastIndexOf('.') - 1 - str.LastIndexOf('\\'));

            string ext = str.Substring(str.LastIndexOf('.')+1, str.Length-1 - str.LastIndexOf('.'));

            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}
