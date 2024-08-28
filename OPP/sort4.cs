using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

   
    internal class Program
    {
        
        static int cuoi(int[] a, int l, int r, int x)
        {
            int res = -1;
            while (l <= r)
            {
                int m = (l + r) / 2;
                if (a[m] < x)
                {
                    res = m;
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[] a = new int[n];
            int[] b = new int[m];

            string[] inputA = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(inputA[i]);
            }
            int ans = 0;
            Array.Sort(a);
            for (int i = 0; i < n; i++){
                
                int p2 = cuoi(a, i + 1, n - 1, m - a[i]);
                if (p2 != -1)
                {
                    ans += p2 - i;
                }
            }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
