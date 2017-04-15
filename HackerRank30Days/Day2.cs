using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day2
    {
        public static void Run()
        {
            double mealCost;
            double tipPercent;
            double taxPercent;

            // Read in bill, tip, and tax info
            mealCost = double.Parse(Console.ReadLine());
            tipPercent = double.Parse(Console.ReadLine());
            taxPercent = double.Parse(Console.ReadLine());

            // Calculate + Output
            Console.WriteLine("The total meal cost is {0} dollars.", NearestDollar(GetMealCost(mealCost, tipPercent, taxPercent)));
        }

    private static double GetMealCost(double mealCost, double tipPercent, double taxPercent)
        {
            return mealCost + tipPercent / 100 * mealCost + taxPercent / 100 * mealCost;
        }

        private static int NearestDollar(double n)
        {
            double dec = n % 1;
            if (dec >= 0.5)
                return (int)Math.Ceiling(n);
            else
                return (int)Math.Floor(n);
        }
    }
}
