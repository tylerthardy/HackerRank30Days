using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day10
    {
        public static void Run()
        {
            Console.WriteLine(Conseq1s(Int32.Parse(Console.ReadLine())));
        }

        private static string ToBits(int N)
        {
            int rem = N % 2;
            int dividend = N / 2;
            if (dividend == 0)
                return rem.ToString();
            else
                return ToBits(dividend) + rem;
        }        

        private static int Conseq1s(int N)
        {
            int rem = -1;
            int max1s = 0;
            int curr1s = 0;
            while(N != 0)
            {
                rem = N % 2;
                N = N / 2;
                //Console.WriteLine("{0},{1},{2}", N, rem, curr1s);
                curr1s += rem;
                    if (curr1s > max1s)
                        max1s = curr1s;
                if(rem == 0)
                    curr1s = 0;
            }
            return max1s;
        }
    }
}
