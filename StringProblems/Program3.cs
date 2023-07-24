using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            string text, rev;
            Console.WriteLine("Enter any word");
            text= Console.ReadLine();
            rev=string.Join(" ",text.Reverse());
            if (text == rev)
            {
                Console.WriteLine("Given word is palindrome");
            }
            else
            {
                Console.WriteLine("Given word is not palindrome");
            }
        }
    }
}
