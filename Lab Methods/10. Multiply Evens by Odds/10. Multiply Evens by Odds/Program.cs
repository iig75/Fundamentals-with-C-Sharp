using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = Math.Abs(int.Parse(Console.ReadLine()));

            int res1 = 0;
            int res2 = 0;

            res1 = GetSumOfEvenDigits(n1);
            res2 = GetSumOfOddDigits(n1);

            Console.WriteLine($"{GetMultipleOfEvenAndOdds(res1, res2)}");
        }

        static int GetSumOfEvenDigits(int x)
        {
            string str = x.ToString();
            int sumEven = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]%2==0)
                {
                    sumEven += int.Parse(str[i].ToString());
                }
            }

            return sumEven;
        }



        static int GetSumOfOddDigits(int x)
        {
            string str = x.ToString();
            int sumOdd = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] % 2 != 0)
                {
                    sumOdd += int.Parse(str[i].ToString());
                }
            }

            return sumOdd;
        }


        static int GetMultipleOfEvenAndOdds(int x, int y)
        {
            int res = x * y;
 
            return res;
        }
    }
}
