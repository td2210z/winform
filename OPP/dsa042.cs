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

            
            
            for (int i =0;i < n ; i++) {
                if (i == 0)
                {
                    if (a[0] * a[1] < 0) {
                        Console.Write(a[0] + " ");
                    }
                    
                } else if (i == n - 1)
                {
                    if (a[n-1] * a[n-2] < 0)
                    {
                        Console.Write(a[n-1]+ " ");
                    }
                }
                else
                {
                    if (a[i] * a[i-1]  < 0 || a[i] * a[i+1] < 0) {
                        Console.Write(a[i]+ " ");}
                }
            }
            //Console.WriteLine(cnt1 + " " + cnt2 + " " + cnt3 + cnt4+ "\n");
            Console.ReadKey();
        }
    }
}
