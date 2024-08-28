using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("ÝEs");
            } else { Console.WriteLine("NO"); }

            if (n % 3 == 0 && n % 5 == 0) {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (n % 3 == 0 && n % 7 != 0) {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if (n % 3 == 0 || n % 7 == 0)
            {
                Console.WriteLine("YES");

            }
            else
            {
                Console.WriteLine("NO");
            }

            if (n >= 30 && n <= 50)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if(n <= 30 && (n % 2 == 0 || n % 3 == 0|| n % 5 == 0))
            {
                Console.WriteLine("YES");

            }
            else
            {
                Console.WriteLine("NO");
            }
            int r = n % 10;
            if ((n >= 10) && (n <= 90) && (r == 2 || r == 3 || r == 5 || r == 7)){
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            if (n <= 100 && n % 23 == 0)
            {
                Console.WriteLine("YES");

            }
            else
            {
                Console.WriteLine("NO");
            }
            if (n < 10 || n > 20)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("nO");
            }
            if (r % 3 == 0)
            {
                Console.WriteLine("YES");

            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
