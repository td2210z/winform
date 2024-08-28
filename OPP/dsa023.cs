using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static void chuyen(int n)
        {
            if (n != 0)
            {
                chuyen(n / 2);
                Console.Write(n % 2 + " ");
            }
        }
       
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0){
                Console.WriteLine('0');
            }
            else
            {
                chuyen(n);
            }
            Console.ReadKey();
        }
    }
}
