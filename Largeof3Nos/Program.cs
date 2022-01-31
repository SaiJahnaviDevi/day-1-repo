using System;

namespace Largeof3Nos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("{0} is the largest!\n",num1);
                }
                else
                {
                    Console.Write("{0} is the largest!\n",num3);
                }
            }
            else if (num2 > num3)
                Console.Write("{0} is the largest!\n",num2);
            else
                Console.Write("(0) is the largest!\n",num3);
        }
    }
}
