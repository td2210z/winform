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
            
            int cnt1 = 10^9 + 5; int cnt2= 0;
            for(int i =0;i < n ; i++) {
               for (int j = i + 1; j < n;j++)
                {
                    cnt1 = Math.Min(cnt1, Math.Abs(a[i] - a[j]));
                }
            }
            Console.WriteLine(cnt1);
            Console.ReadKey();
        }
    }
}
