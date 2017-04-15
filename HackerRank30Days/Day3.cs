using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day3
    {
        public static void Run()
        {
            //Already declared by website, don't copy over
            int N = Convert.ToInt32(Console.ReadLine());
            //////////
            
            string result = "Weird";
            if (N % 2 == 0) // even
                if (N >= 2 && N <= 5 || N > 20)
                    result = "Not Weird";
            else //odd
                result = "Weird";

            Console.WriteLine(result);
        }
    }
}
