using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Transpose
    {
        static void Main2(String[] args)
        {
            int i, j, m, n;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            Console.Write("Enter no.of rows = ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no.of columns = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Set elements in the matrix...\n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("[{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nMatrix before Transpose:\n");
            for (i = 0; i < m; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {

                    arr2[j, i] = arr1[i, j];
                }
            }
            Console.Write("\n\nMatrix after Transpose:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }
            Console.Write("\n\n");
        }
    }
}
