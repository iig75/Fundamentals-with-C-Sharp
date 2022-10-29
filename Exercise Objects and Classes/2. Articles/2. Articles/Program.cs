using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();

            Articles article = new Articles(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for(int i =1; i<=n; i++)
            {
                List<string> command = Console.ReadLine().Split(":").ToList();

                switch(command[0])
                {
                    case "Edit":
                        Edit(article, command);
                        break;

                    case "ChangeAuthor":
                        ChangeAuthor(article, command);
                        break;

                    case "Rename":
                        Rename(article, command);
                        break;
                }

            }

            Console.WriteLine(article.ToString());

        }

        private static void Rename(Articles article, List<string> command)
        {
            article.Title = command[1];
        }

        private static void ChangeAuthor(Articles article, List<string> command)
        {
            article.Author = command[1];
        }

        private static void Edit(Articles article, List<string> command)
        {
            article.Content = command[1];
        }
    }



    class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} -{this.Content}:{this.Author}";
        }
    }

}
