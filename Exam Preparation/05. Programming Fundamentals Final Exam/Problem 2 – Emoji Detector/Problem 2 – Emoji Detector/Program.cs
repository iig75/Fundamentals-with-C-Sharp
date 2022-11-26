using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Problem_2___Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternEmoji = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})(\1)";

            string patternDigit = @"(?<digits>[0-9]+)";

            string input = Console.ReadLine();

            BigInteger coolthreshold = 1;

            MatchCollection matchesDigit = Regex.Matches(input, patternDigit);

            string numbers = String.Empty;

            foreach(Match matchDigit in matchesDigit)
            {
                numbers += matchDigit.Value;
            }

            for(int i=0; i<numbers.Length; i++)
            {
                coolthreshold *= int.Parse(numbers[i].ToString());
            }

            Console.WriteLine($"Cool threshold: {coolthreshold}");

            MatchCollection matchesEmoji = Regex.Matches(input, patternEmoji);

            Console.WriteLine($"{matchesEmoji.Count} emojis found in the text. The cool ones are:");

            foreach(Match matchEmoji in matchesEmoji)
            {

                int sum = 0;

                for(int i=0; i<matchEmoji.Value.Length; i++)
                {
                    if(Char.IsLetter(matchEmoji.Value[i]))
                    {
                        sum += (matchEmoji.Value[i]);
                    }
                }

                if(sum > coolthreshold)
                {
                    Console.WriteLine($"{matchEmoji.Value}");
                }
                
            }
            
        }
    }
}
