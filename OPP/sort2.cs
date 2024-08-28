using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

   
    internal class Program
    {
        
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

            string[] inputB = Console.ReadLine().Split();
            for (int i = 0; i < m; i++)
            {
                b[i] = int.Parse(inputB[i]);
            }
            Array.Sort(a);
            Array.Sort(b);
            int cnt = 0;
            int i = 0, j = 0;
            while (i < m && j < n)
            {
                if (a[i] <= b[j])
                {
                    j++;
                } else
                {
                    cnt++;
                    i++; j++;
                }
            }
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}
