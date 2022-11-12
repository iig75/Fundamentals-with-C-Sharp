using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();

            string content = Console.ReadLine();

            List<string> comments = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of comments")
                    break;
                else
                    comments.Add(command);
            }

            Console.WriteLine($"<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine($"</h1>");

            Console.WriteLine($"<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine($"</article>");

            for(int i=0; i<comments.Count; i++)
            {
                Console.WriteLine($"<div>");
                Console.WriteLine($"    {comments[i]}");
                Console.WriteLine($"</div>");
            }
                
        }
    }
}
