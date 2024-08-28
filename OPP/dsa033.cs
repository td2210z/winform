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
            int cnt = 0;
            int min_vl = 0;
            for(int i =0;i < n ; i++) {
                min_vl = Math.Min(min_vl, a[i]);
            }
            foreach (int i in a)
            {
                if (i ==min_vl) cnt++;
            }
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}
