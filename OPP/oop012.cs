using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{

    class sinhvien1 : ICompareble<sinhvien1>
    {
        public string ma { get; set; }
        public string name { get; set; }
        public string lop { get; set; }
        public string email { get; set; }
        public sinhvien1(string ma , string name , string lop , string email)
        {
            this.ma = ma;
            this.name = name;
            this.lop = lop;
            this.email = email;

        }
        public int lay_lop
        {
            get
            {
                int ans = int.Parse(lop.Substring(4));
                return ans;
            }
        }
        public int CompateTo(sinhvien1 oder)
        {
            int ans = oder.lay_lop.CompareTo(this.lay_lop);
            if (ans == 0)
            {
                return oder.ma.CompareTo(this.ma);
            }
            return ans;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}" , ma , name , lop , email);
        }
    }

        internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<sinhvien1> p = new List<sinhvien1>();
            for (int i =0 ;i < n; i++)
            {
                string ma = Console.ReadLine();
                string name = Console.ReadLine();
                string lop = Console.ReadLine();
                string email = Console.ReadLine();
                
                sinhvien1 res = new sinhvien1(ma , name , lop , email);
                p.Add(res);
            }
            p.Sort();
            foreach (Quannet i in p)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
