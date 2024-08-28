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
            // tinh tong hang

            for (int i = 0;i < n; i++)
            {
                int sum = 0;
                for (int j =0;j < m; j++)
                {
                    sum += a[i, j];
                }
                Console.Write(sum + " ");
            }
            Console.ReadLine();
            for (int i = 0;i < n; i++)
            {
                int ans = 0;
                for (int j =0;j < m; j++)
                {
                    ans += a[j, i];
                }
                Console.Write(ans + " ");
            }
            //Console.WriteLine(cnt1 + " " + cnt2 + " " + cnt3 + cnt4+ "\n");
            Console.ReadKey();
        }
    }
}

