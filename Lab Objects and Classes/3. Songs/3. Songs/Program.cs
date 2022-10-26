using System;
using System.Collections.Generic;

namespace _3._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for(int i=1; i<=n; i++)
            {
                string[] input = Console.ReadLine()
                                        .Split("_");

                Song song = new Song(input[0], input[1], input[2]);

                songs.Add(song);
            }

            string list = Console.ReadLine();

            for(int i=0; i<songs.Count; i++)
            {
                Song currentSong = songs[i];

                if (list == "all")
                {
                    Console.WriteLine($"{currentSong.Name}");
                }
                else if (currentSong.TypeList == list)
                {
                    Console.WriteLine($"{currentSong.Name}");
                }
            }
        }
    }



    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

}
