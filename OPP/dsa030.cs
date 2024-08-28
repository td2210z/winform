using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static bool lon(int n)
        {
            if (n == 0) return true;
            if (n % 2 != 0) return false;
            else return lon(n / 10);
;
        }
        

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (lon(n))
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("no");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
