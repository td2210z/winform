using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {

        static bool check(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }

            return n > 1;
        }
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            int[,] a = new int[n, m];
            for (int i =0;i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j =0; j < n; j++)
                {
                    a[i, j] = int.Parse(input[j]);
                }
            }
            int max_so = 0, min_so = 1000000;
            for (int i =0;i < n; i++)
            {
                for (int j =0;j < m; j++)
                {
                    if (a[i , j] >= max_so)
                    {
                        max_so = a[i, j];
                    }
                }
            }
            Console.WriteLine(max_so);
            for (int i = 0;i < n; i++)
            {
                for (int j =0;j < m; j++)
                {
                    if (a[i, j] == max_so)
                    {
                        Console.Write(i + 1 + " " + j + 1);
                    }
                }
                Console.WriteLine();
                
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < min_so)
                    {
                        min_so = a[i, j];
                    }
                }
            }
            Console.WriteLine(min_so);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] == min_so)
                    {
                        Console.Write(i +1 + " " + j + 1);
                    }
                    Console.WriteLine();
                }
                
            }

            //Console.WriteLine(cnt1 + " " + cnt2 + " " + cnt3 + cnt4+ "\n");
            Console.ReadKey();
        }
    }
}
