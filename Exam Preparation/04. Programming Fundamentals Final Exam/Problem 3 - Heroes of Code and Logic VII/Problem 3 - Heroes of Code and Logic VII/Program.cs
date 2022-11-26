using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();

            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                List<string> input = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .ToList();

                Hero hero = new Hero(input[0], int.Parse(input[1]), int.Parse(input[2]));

                heroes.Add(hero);
            }



            while(true)
            {
                List<string> command = Console.ReadLine()
                                        .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

                if (command[0] == "End")
                    break;

                if(command[0] == "CastSpell")
                {
                    foreach (Hero h in heroes)
                    {
                        if(h.HeroName==command[1])
                        {
                            if(h.HeroMP >= int.Parse(command[2]))
                            {
                                h.HeroMP -= int.Parse(command[2]);
                                Console.WriteLine($"{h.HeroName} has successfully cast {command[3]} and now has {h.HeroMP} MP!");
                            }
                            else
                            {
                                Console.WriteLine($"{h.HeroName} does not have enough MP to cast {command[3]}!");
                            }
                        }
                    }
                }



                if (command[0] == "TakeDamage")
                {
                    foreach (Hero h in heroes)
                    {
                        if (h.HeroName == command[1])
                        {
                            h.HeroHP -= int.Parse(command[2]);

                            if (h.HeroHP > 0)
                            {
                                Console.WriteLine($"{h.HeroName} was hit for {command[2]} HP by {command[3]} and now has {h.HeroHP} HP left!");
                            }
                            else
                            {
                                Console.WriteLine($"{h.HeroName} has been killed by {command[3]}!");
                                heroes.Remove(h);
                                break;
                            }
                        }
                    }
                }



                if(command[0] == "Recharge")
                {
                    foreach (Hero h in heroes)
                    {
                        if (h.HeroName == command[1])
                        {
                            if(h.HeroMP+int.Parse(command[2]) > 200)
                            {
                                int sizeMP = 200 - h.HeroMP;
                                h.HeroMP = 200;

                                Console.WriteLine($"{h.HeroName} recharged for {sizeMP} MP!");
                            }
                            else
                            {
                                h.HeroMP += int.Parse(command[2]);

                                Console.WriteLine($"{h.HeroName} recharged for {command[2]} MP!");
                            }
                        }
                    }
                }



                if(command[0] == "Heal")
                {
                    foreach (Hero h in heroes)
                    {
                        if (h.HeroName == command[1])
                        {
                            if (h.HeroHP + int.Parse(command[2]) > 100)
                            {
                                int sizeHP = 100 - h.HeroHP;
                                h.HeroHP = 100;

                                Console.WriteLine($"{h.HeroName} healed for {sizeHP} HP!");
                            }
                            else
                            {
                                h.HeroHP += int.Parse(command[2]);

                                Console.WriteLine($"{h.HeroName} healed for {command[2]} HP!");
                            }
                        }
                    }
                }
            }



            foreach(Hero h in heroes)
            {
                Console.WriteLine($"{h.HeroName}");
                Console.WriteLine($"HP: {h.HeroHP}");
                Console.WriteLine($"MP: {h.HeroMP}");
            }
        }
    }



    class Hero
    {
        public Hero(string heroName, int heroHP, int heroMP)
        {
            HeroName = heroName;
            HeroHP = heroHP;
            HeroMP = heroMP;
        }

        public string HeroName { get; set; }

        public int HeroHP { get; set; }

        public int HeroMP { get; set; }
    }



}
