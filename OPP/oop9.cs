using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{

    class hocsinh : IComparable<hocsinh>
    {
        private static int dem = 1;
        public string ma { get;  }
        public string name { get; set; }
        public string lop { get; set; }
        public string ns { get; set; }
        public float gpa { get; set; }

        public hocsinh( string name, string lop, string ns, float gpa)
        {
            this.ma = "SV" + dem++.ToString("D3");
            this.name = name;
            this.lop = lop;
            this.ns = ns;
            this.gpa = gpa;
        }
        public void chuan_hoa()
        {
            if (ns[1] == '/')
            {
                ns = "0" + ns;
            }
            if (ns[4] == '/')
            {
                ns = ns.Insert(3 , "0");
            }
            this.name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.name.ToLower()); 
        }
        public int CompareTo(hocsinh oder)
        {
            int ans = oder.gpa.CompareTo(this.gpa);
            if (ans == 0)
            {
                return this.ma.CompareTo(oder.ma);
            }
            return ans;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", ma, name, lop, ns, gpa.ToString("F2"));
        }
    }

    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<hocsinh> p = new List<hocsinh>();
            for (int i =0;i < n; i++)
            {
                string name = Console.ReadLine();
                string lop = Console.ReadLine();
                string ns = Console.ReadLine();
                float gpa = float.Parse(Console.ReadLine());
                hocsinh res = new hocsinh(name, lop, ns, gpa);
                res.chuan_hoa();
                p.Add(res);
            }
            p.Sort();
            foreach (hocsinh i in p)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
