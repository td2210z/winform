using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static int tong(int n ,int k)
        {
           if (k == 0 || n == k) return 1;
            return tong(n -1, k) + tong(n - 1, k - 1);
        }
        static void Main(string[] args)
        {
            string[] ab = Console.ReadLine().Split(' ');
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            Console.WriteLine(tong(a, b));
            Console.ReadKey();
        }
    }
}
