using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class DuplicateElements
    {
        static void Main(String[] args)
        {
            int[] a = new int[100];
            int i, j, n, c = 0;
            Console.WriteLine("Enter size of the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        c++;
                        break;
                    }
                }
            }
            Console.WriteLine("\nNumber of duplicate elements found in array: {0}" ,c);
        }
    }
}
