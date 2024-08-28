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
            float res1 = n * 2 * 3.14f;
            float res2 = n * n * 1.14f;
            Console.WriteLine(res1.ToString("F4"));
            Console.WriteLine(res2.ToString("F4"));

            Console.ReadKey();
        }
    }
}
