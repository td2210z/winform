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
            int x = int.Parse(Console.ReadLine());
            int cnt1 = 0; int cnt2= 0;
            for(int i =0;i < n ; i++) {
               for (int j = i + 1; j < n ; j++)
                {
                    if (a[i] + a[j] == x)
                    {
                        cnt1++;
                    }
                }
            }
            Console.WriteLine(cnt1);
            Console.ReadKey();
        }
    }
}

