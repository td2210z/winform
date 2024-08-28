using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i =1; i <= Math.Sqrt(n);i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i != n / i)
                    {
                        sum += n / i;
                    }
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}

