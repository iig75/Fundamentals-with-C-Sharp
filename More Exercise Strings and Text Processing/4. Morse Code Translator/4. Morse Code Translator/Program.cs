using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> morz = new Dictionary<string, string>();

            morz.Add(".-", "A");
            morz.Add("-...", "B");
            morz.Add("-.-.", "C");
            morz.Add("-..", "D");
            morz.Add(".", "E");
            morz.Add("..-.", "F");
            morz.Add("--.", "G");
            morz.Add("....", "H");
            morz.Add("..", "I");
            morz.Add(".---", "J");
            morz.Add("-.-", "K");
            morz.Add(".-..", "L");
            morz.Add("--", "M");
            morz.Add("-.", "N");
            morz.Add("---", "O");
            morz.Add(".--.", "P");
            morz.Add("--.-", "Q");
            morz.Add(".-.", "R");
            morz.Add("...", "S");
            morz.Add("-", "T");
            morz.Add("..-", "U");
            morz.Add("...-", "V");
            morz.Add(".--", "W");
            morz.Add("-..-", "X");
            morz.Add("-.--", "Y");
            morz.Add("--..", "Z");
            morz.Add("-----", "0");
            morz.Add(".----", "1");
            morz.Add("...--", "2");
            morz.Add("....-", "4");
            morz.Add(".....", "5");
            morz.Add("-....", "6");
            morz.Add("--...", "7");
            morz.Add("---..", "8");
            morz.Add("----.", "9");
            morz.Add("|", " ");

            List<string> list1 = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

            for (int i=0; i<list1.Count; i++)
            {
                Console.Write($"{morz[list1[i]]}");
            }
        }
    }
}
