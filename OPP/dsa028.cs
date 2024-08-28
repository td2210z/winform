using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void lon(int n)
        {
            if (n < 10)
            {
                Console.Write(n + ' ');
                return;
            }
            lon(n / 10);
            Console.Write(n % 10 + " ");

        }
        static void nho(int n)
        {
            if (n < 10)
            {
                Console.Write(n + " ");
                return;
            }
            Console.Write(n % 10 + " ");
            nho(n / 10);

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            lon(n);
            Console.WriteLine();
            nho(n); 
            Console.ReadKey();
        }
    }
}
