using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day6
    {
        public static void Run()
        {
            int T = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= T; i++)
            {
                string S = Console.ReadLine();
                char[] chars = S.ToCharArray();

                string even = "";
                string odd = "";
                for (int c = 0; c < chars.Length; c++)
                {
                    if (c % 2 == 0) //even
                        even += chars[c];
                    else //odd
                        odd += chars[c];
                }

                Console.WriteLine("{0} {1}", even, odd);
            }
        }
    }
}
