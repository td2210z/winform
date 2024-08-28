using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static double tong(double n)
        {
            if (n == 1) return 1;
            else return 1 / n + tong(n - 1);
        }
       
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            Console.WriteLine(tong(n).ToString("F3"));
            Console.ReadKey();
        }
    }
}
