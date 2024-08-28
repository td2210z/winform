using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static List<int> fibo = new List<int>();

        static bool IsFibonacci(int n)
        {
            int a = 0, b = 1;
            while (b < n)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }
            return b == n;
        }

        static void Main(string[] args)
        {
            fibo.Add(0);
            fibo.Add(1);
            int i = 2;
            while (fibo[i - 1] < int.MaxValue - fibo[i - 2])
            {
                fibo.Add(fibo[i - 1] + fibo[i - 2]);
                i++;
            }

            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                a[j] = int.Parse(input[j]);
            }

            for (int j = 0; j < n; j++)
            {
                if (IsFibonacci(a[j]))
                {
                    Console.WriteLine(a[j]);
                }
            }
            Console.ReadKey();
        }
    }
}
