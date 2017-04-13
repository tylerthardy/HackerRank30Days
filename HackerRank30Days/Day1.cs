using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day1
    {
        public static void Run()
        {
            //Already declared by website, don't copy over
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            //////////

            // Declare second integer, double, and String variables.
            int i2 = 12;
            double d2 = 4.0;
            string s2 = "is the best place to learn and practice coding!";

            // Read and save an integer, double, and String to your variables.
            int i3 = Int32.Parse(Console.ReadLine());
            double d3 = Double.Parse(Console.ReadLine());
            string s3 = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);

            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:0.0}", d + d2);

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);
        }
    }
}
