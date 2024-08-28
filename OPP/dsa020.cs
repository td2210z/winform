using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static int tong(int n ,int k)
        {
           if (k == 0)
            {
                return n;
            }
            return tong(k, n % k);
        }
        static int boi(int n ,int k)
        {
            return n * k / tong(n , k);
        }
        static void Main(string[] args)
        {
            string[] ab = Console.ReadLine().Split(' ');
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            Console.WriteLine(tong(a, b));
            Console.WriteLine(boi(a, b));
            Console.ReadKey();
        }
    }
}
