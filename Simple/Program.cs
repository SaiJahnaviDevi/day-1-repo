using System;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("age is above 18");
            }
            else
                Console.WriteLine("age is below 18");
        }
    }
}
