using System;

namespace SumofNterms
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First {0} natural numbers are:", n);
            for(int i = 1; i <= n; i++)
            {
                Console.Write(i+"\t");
                sum = sum + i;
            }
            Console.WriteLine("\nsum of {0} natural numbers= {1}",n,sum);
        }
    }
}
