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
                chuyen(n / 16);
                int r = n % 16;
                if (r < 10)
                {
                    Console.Write(r.ToString());
                }
                else
                {
                    Console.Write(Convert.ToChar(r + 55));
                }
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
