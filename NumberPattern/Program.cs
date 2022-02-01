using System;

namespace NumberPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0}\t",k);
                    k++;
                }
                Console.WriteLine("");
            }
        }
    }
}
