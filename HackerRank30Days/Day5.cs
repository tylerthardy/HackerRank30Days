﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day5
    {
        public static void Run()
        {
            // Provided
            int n = Convert.ToInt32(Console.ReadLine());
            /////////////////////////////

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}
