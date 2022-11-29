using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piece> pieces = new List<Piece>();

            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                List<string> input = Console.ReadLine()
                                            .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();
                bool exist = false;

                foreach(Piece p in pieces)
                {
                    if(p.PieceName==input[0])
                    {
                        p.PieceName = input[0];
                        p.Composer = input[1];
                        p.Key = input[2];
                        exist = true;
                        break;
                    }
                }

                if(!exist)
                {
                    Piece piece = new Piece(input[0], input[1], input[2]);
                    pieces.Add(piece);
                }
            }



            while(true)
            {
                List<string> command = Console.ReadLine()
                                              .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

                if (command[0] == "Stop")
                    break;



                if (command[0] == "Add")
                {
                    bool exist = false;

                    foreach (Piece p in pieces)
                    {
                        if (p.PieceName == command[1])
                        {
                            Console.WriteLine($"{p.PieceName} is already in the collection!");
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        Piece piece = new Piece(command[1], command[2], command[3]);
                        pieces.Add(piece);
                        Console.WriteLine($"{command[1]} by {command[2]} in {command[3]} added to the collection!");
                    }
                }



                if (command[0] == "Remove")
                {
                    bool exist = false;

                    foreach (Piece p in pieces)
                    {
                        if (p.PieceName == command[1])
                        {
                            pieces.Remove(p);
                            Console.WriteLine($"Successfully removed {p.PieceName}!");
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                    }
                }



                if (command[0] == "ChangeKey")
                {
                    bool exist = false;

                    foreach (Piece p in pieces)
                    {
                        if (p.PieceName == command[1])
                        {
                            p.Key = command[2];
                            Console.WriteLine($"Changed the key of {p.PieceName} to {p.Key}!");
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                    }
                }

            }



            foreach(Piece p in pieces)
            {
                Console.WriteLine($"{p.PieceName} -> Composer: {p.Composer}, Key: {p.Key}");
            }

        }
    }



    class Piece
    {
        public Piece(string pieceName, string composer, string key)
        {
            PieceName = pieceName;
            Composer = composer;
            Key = key;
        }

        public string PieceName { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
