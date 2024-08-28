using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
       
        


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i =0;i < n; i++) {
                a[i] = int.Parse(input[i]);
            }

            int[] cnt = new int[1000000];
            for(int i =0;i < n ; i++) {
                cnt[a[i]] += 1;
            }
            for (int i =0;i < n ; i++) { 
                if (cnt[a[i]] != 0)
                {
                    Console.Write(a[i] + " ");
                }
                cnt[a[i]] = 0;
            }
            Console.ReadKey();
        }
    }
}
