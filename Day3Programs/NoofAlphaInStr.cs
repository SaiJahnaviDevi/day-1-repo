using System;

namespace Day3Programs
{
    class NoofAlphaInStr
    {
        static void Main1(string[] args)
        {
            String str;
            int alpha=0, digit=0, splchar=0, i=0,l;
            Console.WriteLine("Enter String:");
            str = Console.ReadLine();
            l = str.Length;
            while (i < l)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                    alpha++;
                else if (str[i] >= '0' && str[i] <= '9')
                    digit++;
                else
                    splchar++;
                i++;
            }
            Console.WriteLine("No. of alphabets in {0} are {1}", str, alpha);
            Console.WriteLine("No. of digits in {0} are {1}", str, digit);
            Console.WriteLine("No. of special characters in {0} are {1}", str, splchar);
        }
    }
}
