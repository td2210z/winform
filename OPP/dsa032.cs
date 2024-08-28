using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void check(int[] a , int n)
        {
            if (n >= 1)
            {
                Console.Write(a[n - 1] + " ");
                check(a, n - 1);
            }
        }
        static void check2(int[] a, int n)
        {
            if (n >= 1)
            {
                check2(a, n - 1);
                Console.Write(a[n - 1] + " ");
            }
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0;i < n; i++)
            {
                a[i] = int.Parse(input[i]);
            }
            check(a, n);
            Console.WriteLine();
            check2(a, n);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
