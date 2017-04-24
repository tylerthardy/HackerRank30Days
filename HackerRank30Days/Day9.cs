using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day9
    {
        public static void Run()
        {
            int N = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(N));
        }

        private static int Factorial(int N)
        {
            if (N == 1)
                return N;
            else
                return N * Factorial(N - 1);
        }
    }
}
