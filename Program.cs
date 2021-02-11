using System;

namespace LeetCode_1688
{
    class Program
    {
        static void Main(string[] args)
        {
            //SUCCESSFUL
            Console.WriteLine("Welcome to LeetCode 1688");
            int totalMatches = NumberOfMatches(7);
            Console.WriteLine($"Output: {totalMatches}");

        }

        private static int NumberOfMatches(int n)
        {
            int totalMatches = 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    totalMatches += n;
                }
                else
                {
                    n = (n - 1) / 2 + 1;
                    totalMatches += (n - 1);
                }
            }
            return totalMatches;
        }
    }
}


