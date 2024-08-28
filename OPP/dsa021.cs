using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static int tong(int n ,int k)
        {
            if (k == 0) return 1;
            int tmp = tong(n, k / 2);
            if (k % 2 == 1) return tmp * tmp *n;
            else return tmp * tmp;
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

