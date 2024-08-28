using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
       
        
        static bool check(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return n > 1;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i =0;i < n; i++) {
                a[i] = int.Parse(input[i]);
            }

            
            
            for (int i =0;i < n ; i++) {
                int l = 0;
                for (int j =0; j < i; j++)
                {
                    l += a[j];
                }
                int r = 0;
                for (int j = i +1; j < n; j++)
                {
                    r += a[j];
                }
                if (check(l) && check(r))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
