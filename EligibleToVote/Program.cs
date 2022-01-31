using System;

namespace EligibleToVote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
                Console.WriteLine("Not eligible to vote");
        }
    }
}
