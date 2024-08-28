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
            if (n <= s / 2)
            {
                Console.WriteLine(m * n);
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(m / 2 * s);
                }
                else
                {
                    Console.WriteLine((m-1) / 2 * s + n);
                }
            }
            
            Console.ReadKey();
        }
    }
}

