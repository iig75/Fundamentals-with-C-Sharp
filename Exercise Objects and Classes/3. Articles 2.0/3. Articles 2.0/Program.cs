using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Articles> articles = new List<Articles>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                List<string> input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();

                Articles article = new Articles(input[0], input[1], input[2]);

                articles.Add(article);

            }

            for(int i=0; i<articles.Count; i++)
            {
                Articles currentArticle = articles[i];

                Console.WriteLine($"{currentArticle.Title} -{currentArticle.Content}:{currentArticle.Author}");
            }
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
    }
}
