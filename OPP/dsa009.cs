using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            for (int i = 1;i <= n; i++) { 
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i =n;i >= 0 ;i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for(int i =0;i <= n;i++) {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            for (int i =0;i <= n; i+= 4) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i =0 ;i <= n;i++)
            {
                Console.Write((char)(i + 97) + " ");
            }
            Console.WriteLine();
            for (int i = 122- n + 1;i <= 123;i++) { 
                Console.Write((char)(i) + " ");
            }
            Console.ReadKey();
        }
    }
}

