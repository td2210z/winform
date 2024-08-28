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
            int[,] a = new int[n + 1, n + 1];
            int cnt = 1;
            for (int i =0;i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' '); 
                for (int j =0;j < n; j++)
                {
                    a[i, j] = int.Parse(input[j]); 
                }
            }
            int h1 = 0, h2 = n - 1, c1 = 0, c2 = n - 1;
            while (h1 <= h2 && c1 <= c2)
            {
                // xay dung hang dau tien
                for (int i = c1; i <= c2; i++)
                {
                    a[h1, i] = cnt;
                    cnt++;
                }
                h1++;
                for (int i = h1; i <= h2; i++)
                {
                    a[i, c2] = cnt;
                    cnt++;
                }
                c2--;
                if(h1 <= h2)
                {
                    for (int i = c2; i >= c1; i--)
                    {
                        a[h2, i] = cnt;
                        cnt++;
                    }
                    h2--;
                }
                if (c1 <= c2)
                {
                    for (int i = h2;i >= h1; i--)
                    {
                        a[c1, i] = cnt;
                        cnt++;
                    }
                    c1++;
                }
            }
            for (int i =0;i < n; i++)
            {
                for (int j =0;j < n; j++)
                {
                    Console.Write(a[i,j] + ' ');
                }
                Console.WriteLine();
            }
            //Console.WriteLine(cnt1 + " " + cnt2 + " " + cnt3 + cnt4+ "\n");
            Console.ReadKey();
        }
    }
}

