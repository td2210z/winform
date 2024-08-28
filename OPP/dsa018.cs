using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static int tong(int n)
        {
           if (n == 1) return 0;
           if (n == 2) return 1;
           return tong(n - 1) + tong(n - 2);
        }
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            Console.WriteLine(tong(n));
            Console.ReadKey();
        }
    }
}
