using System;

namespace FactUsingFunctions
{
    class Program
    {
        public int Fact(int a)
        {
            int fact = 1;
            for(int i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();
            Console.WriteLine("factorial of {0} is {1}",n,program.Fact(n));
        }
    }
}
