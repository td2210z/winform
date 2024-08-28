using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{

    class sinhvien
    {
        private string name;
        private string ns;
        private float d1;
        private float d2;
        private float d3;

        public sinhvien(string name, string ns, float d1, float d2, float d3)
        {
            this.name = name;
            this.ns = ns;
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
        }
        
        public override string ToString()
            
        {
            float tong = this.d1 + this.d2 + this.d3;
            return this.name + " " + this.ns + " " + tong.ToString("F2");
        }
    }
    

    
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string ns = Console.ReadLine();
            float d1 = float.Parse(Console.ReadLine());
            float d2 = float.Parse(Console.ReadLine());
            float d3 = float.Parse(Console.ReadLine());

            sinhvien s = new sinhvien(name , ns , d1 , d2 , d3);
            Console.WriteLine(s.ToString());
            Console.ReadKey();

        }
    }
}
