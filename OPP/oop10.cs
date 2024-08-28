using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{

    class nhanvien
    {
        private static int dem = 1;
        public string ma { get; }
        public string name { get; set; }
        public string gt { get; set; }
        public string ns { get; set; }
        public string dc { get; set; }
        public string mst { get; set; }
        public string nkhd { get; set; }

        public nhanvien( string name, string gt, string ns, string dc, string mst, string nkhd)
        {
            this.ma = dem++.ToString("D5");
            this.name = name;
            this.gt = gt;
            this.ns = ns;

            this.dc = dc;

            this.mst = mst;
            this.nkhd = nkhd;

        }
        public void chuan_hoa()
        {
            if (ns[1] == '/')
            {
                ns = "0" + ns;
            }
            if (ns[4] == '/')
            {
                ns.Insert(3, "0");
            }
            this.name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(this.name.ToLower()); 
            if (nkhd[1] == '/')
            {
                nkhd = "0" + nkhd;
            }
            if (nkhd[4] == '/')
            {
                nkhd.Insert(3 , "0");
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6}", ma, name, gt, ns, dc, mst, nkhd);
        }
    }

    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<nhanvien> p = new List<nhanvien>();
            for (int i =0;i < n; i++)
            {
                string name = Console.ReadLine();
                string gt = Console.ReadLine();
                string ns = Console.ReadLine();
                string dc = Console.ReadLine();
                string mst = Console.ReadLine();
                string nkhd = Console.ReadLine();

                nhanvien res = new nhanvien(name, gt, ns, dc, mst, nkhd);
                res.chuan_hoa();
                p.Add(res);
            }
            //p.Sort();
            foreach (nhanvien i in p)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
