using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day11
    {
        public static void Run()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }

            int max_hg = -9*7;
            //int max_x = -1, max_y = -1;
            //scan inner 5 rows
            for(int arr_i = 1; arr_i < 5; arr_i++)
            {
                //scan inner 5 columns
                for(int arr_j = 1; arr_j < 5; arr_j++)
                {
                    int hg_val = 0;
                    hg_val += arr[arr_i][arr_j];
                    for(int adj_i= -1; adj_i <= 1; adj_i++)
                    {
                        hg_val += arr[arr_i - 1][arr_j + adj_i]; //upper hourglass, side arr_j+adj_i
                        hg_val += arr[arr_i + 1][arr_j + adj_i]; //bottom hourglass, side arr_j+adj_i
                    }
                    if (hg_val > max_hg)
                    {
                        max_hg = hg_val;
                        //max_x = arr_j;
                        //max_y = arr_i;
                    }
                }
            }
            /*Console.WriteLine("{0} {1} {2}", arr[max_y - 1][max_x - 1], arr[max_y - 1][max_x], arr[max_y - 1][max_x + 1]);
            Console.WriteLine("  {0}", arr[max_y][max_x]);
            Console.WriteLine("{0} {1} {2}", arr[max_y + 1][max_x - 1], arr[max_y + 1][max_x], arr[max_y + 1][max_x + 1]);*/
            Console.WriteLine(max_hg);
        }
    }
}
