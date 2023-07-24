using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            string[] name = new string[5] { "Vidyashree", "Manali", "Pooja", "Prajakta", "Anjali" };
           foreach (string s in name)
            {
                Console.WriteLine(s);
                
            }
           Array.Sort(name);
       foreach (string s in name)
            {
                Console.WriteLine(s);
            }


        }
    }
}
