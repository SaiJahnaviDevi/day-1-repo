﻿using System;

namespace StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*\t");

                }
                Console.WriteLine("");
            }
        }
    }
}
