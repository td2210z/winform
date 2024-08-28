using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

   
    internal class Program
    {
        static int check(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0;i < n; i++)
            {
                a[i] = int.Parse(input[i]);
            }
            Array.Sort(a, (x, y) =>
            {
                int res1 = check(x);
                int res2 = check(y);
                if (res1 == res2)
                {
                    return res1 - res2;
                } else
                {
                    return res1 - res2;
                }
            });
            foreach(int x in a)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }
    }
}
