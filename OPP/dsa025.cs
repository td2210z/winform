using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static int chuyen(int n)
        {
            if (n < 10)
            {
                return n;
            }
            return n % 10 + chuyen(n / 10);

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(chuyen(n));
            Console.ReadKey();
        }
    }
}
