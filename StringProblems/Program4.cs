using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{
    internal class Program4
    {
        static void Main(string[] args) {

            //{
            //    Console.WriteLine("Enter sentence");
            //    string sentenece = Console.ReadLine();

            //    Console.WriteLine("Enter word to find");
            //    String findword = Console.ReadLine();

            //    //string[] words = 
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        if (words[i] == findword)
            //        {
            //            Console.WriteLine(words);
            //        }

            //    }

            //    string str = "hello good evening";
            //    int index1=str.IndexOf('g');
            //    Console.WriteLine("The index value of character 'g'is "+index1);
            //    int index2 = str.IndexOf('e');
            //    Console.WriteLine("The index value of character 'e' is"+index2);
            //    Console.ReadLine();



            string str = "hello good evening";
            Console.WriteLine("enter any character");
            char ch = Convert.ToChar(Console.ReadLine());
            char[]arr=str.ToCharArray();
            int count =0;
            for(int i=0;i<arr.Length; i++)
            {
                if(ch == arr[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);








        }
    }
}
