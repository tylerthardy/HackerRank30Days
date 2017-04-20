using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day7
    {
        public static void Run()
        {
            //Provided
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            ////////////////////////////

            //Easy method
            //Console.WriteLine(String.Join(" ", arr.Reverse()));

            //Alternative using loop
            for(int i = n-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
