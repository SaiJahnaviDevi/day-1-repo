using System;

namespace ConsoleApp2
{
    class SencondLargest 
    {
        static void Main1(string[] args)
        {
            int i,j=0,lar,lar2;
            int[] a = new int[100];
            Console.WriteLine("Enter size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            lar = 0;
            for (i = 0; i < n; i++)
            {
                if (lar < a[i])
                {
                    lar = a[i];
                    j = i;
                }
            }
            lar2 = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (lar2 < a[i])
                        lar2 = a[i];
                }
            }
            Console.WriteLine("second largest element is : {0}", lar2);
        }
    }
}
