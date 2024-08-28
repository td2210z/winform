using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static int lon(int n)
        {
            if (n == 0) return 0;
            if (n % 2 == 0) return n % 10 + lon(n / 10);
            else return lon(n / 10);
;
        }
        static int nho(int n)
        {
            if (n == 0) return 0;
            if (n % 2 != 0) return n % 10 + nho(n / 10);
            else return nho(n / 10);

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(lon(n) + " "+ nho(n));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
