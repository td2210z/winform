using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            float sum =0;
            for (int i =1;i <= n; i++)
            { 
                sum += 1/ i;

            }
            Console.WriteLine(sum.ToString("F3"));
            Console.ReadKey();
        }
    }
}
