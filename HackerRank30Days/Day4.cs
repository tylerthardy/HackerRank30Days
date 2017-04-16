using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day4
    {
        public static void Run()
        {
            //Already declared by website, don't copy over;
            //this is my own reproduced copy based on the instructions, not copied from the website
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= T; i++)
            {
                int age = Int32.Parse(Console.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 1; j <= 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
            //////////
        }
    }

    class Person
    {
        private int age;
        public Person(int initialAge)
        {
            if (initialAge >= 0)
                this.age = initialAge;
            else
            {
                this.age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }

        public void yearPasses()
        {
            age += 1;
        }

        public void amIOld()
        {
            if(age < 13)
                Console.WriteLine("You are young.");
            else if(age < 18)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are old.");
        }
    }
}
