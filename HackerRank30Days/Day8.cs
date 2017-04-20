using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank30Days
{
    class Day8
    {

        public static void Run()
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] data_temp = Console.ReadLine().Split(' ');
                phonebook.Add(data_temp[0], data_temp[1]);
            }
            while (true)
            {
                string name = Console.ReadLine();
                if ( name == "exit" )//line == null ||
                {
                    break;
                }
                
                try
                {
                    Console.WriteLine("{0}={1}",name,phonebook[name]);
                }
                catch (KeyNotFoundException) { 
                    Console.WriteLine("Not found");
                }
            }

        }
    }
}
