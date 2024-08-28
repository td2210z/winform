using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {
        static bool check(int[] a , int l , int r)
        {
            if (l >= r){
                return true;
            }
            else
            {
                if (a[l] != a[r])
                {
                    return false;

                }
                return check(a, l + 1, r - 1);
            }
        }
        

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split(' ');

            for (int i =0;i < n; i++)
            {
                a[i] = int.Parse(input[i]);   
            }
            if (check(a , 0 , n-1))
            {
                Console.WriteLine("ÝE");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
