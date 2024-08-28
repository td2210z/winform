using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mns = Console.ReadLine().Split(' ');
            int m = int.Parse(mns[0]);
            int n = int.Parse(mns[1]);
            int s = int.Parse(mns[2]);
            if ((m > 0 && n > 0 && s > 0) && (m + n > s || n + s > m || s + m > n))
            {
                if (m == n && m == s)
                {
                    Console.WriteLine("1");
                }
                else if (m == n && n == s && s == m)
                {
                    Console.WriteLine("2");
                }
                else if ((m ^ 2) + (n ^ 2) == (s ^ 2) || (n ^ 2) + (s ^ 2) == (m ^ 2) || (m ^ 2) + (n ^ 2) == (s ^ 2))
                {
                    Console.WriteLine("3");
                }
                else
                {
                    Console.WriteLine("4");
                }
            }
            else
            {
                Console.WriteLine("INVALID");
            }
            Console.ReadKey();
        }
    }
}
