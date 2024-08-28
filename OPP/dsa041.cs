using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    internal class Program
    {

        static int check(int n)
        {
            if (n < 2) return 0;
            for (int i =2;i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return 0;
            }
            return 1;
        }
        static int stn(int n)
        {
            int tmp = n;
            int rev = 0;
            while (n != 0)
            {
                rev = rev * 10 + n % 10;
                n /= 10;
            }
            if (rev == tmp) return 1;
            else return 0;
        }
        static int scp(int n)
        {
            int z = (int)Math.Sqrt(n);
            if (z * z == n){
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static int tong(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10; 
            }
            return check(sum);
        }
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i =0;i < n; i++) {
                a[i] = int.Parse(input[i]);
            }
            int cnt1 =0 , cnt2 = 0, cnt3 = 0 , cnt4 = 0;

            
            
            for (int i =0;i < n ; i++) {
                if (check(a[i]) == 1)
                {
                    cnt1 += 1;
                }
                if (stn(a[i]) == 1)
                {
                    cnt2 += 1;
                }
                if (scp(a[i]) == 1)
                {
                    cnt3 += 1;
                }
                if (tong(a[i]) == 1)
                {
                    cnt4 += 1;
                }
            }
            Console.WriteLine(cnt1 + " " + cnt2 + " " + cnt3 + cnt4+ "\n");
            Console.ReadKey();
        }
    }
}
