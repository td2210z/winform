using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static int tong(int n)
        {
            if (n == 1) return -1;
            else if (n % 2 == 0) return n + tong(n - 1);
            else return tong(n-1) - n;
        }
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            Console.WriteLine(tong(n));
            Console.ReadKey();
        }
    }
}

