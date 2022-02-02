using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Programs
{
    class ExtractSubstring
    {
        static void Main2(string[] args)
        {
            String str;
            char[] arr;
            int l,pos,ln, c = 0;
            Console.WriteLine("Enter String:");
            str = Console.ReadLine();
            l = str.Length;
            arr = str.ToCharArray(0, l);
            Console.Write("Enter start position:");
            pos =int.Parse( Console.ReadLine());
            Console.Write("Input the length of substring :");
            ln = Convert.ToInt32(Console.ReadLine());

            Console.Write("The substring extracted from the string is : ");
            while (c < ln)
            {
                Console.Write(arr[pos + c - 1]);
                c++;
            }
            Console.WriteLine("\n");
        }
    }
    
}
