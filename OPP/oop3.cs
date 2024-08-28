using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{

    class nhanvien {
        private string ma;
        private string name;
        private string gt;
        private string ns;
        private string dc;
        private string mst;
        private string nkhd;

        public nhanvien(string ma , string name , string gt , string ns , string dc , string mst , string nkhd) {
            this.ma = ma;
            this.name = name;
            this.gt = gt;
            this.ns = ns;
            this.dc = dc;
            this.mst = mst;
            this.nkhd = nkhd;
        }
        public void chuan_hoa()
        {
            if (this.ns[1] == '/')
            {
                this.ns = "0" + this.ns;
            }
            if (this.ns[4] == '/')
            {
                this.ns = this.ns.Insert(3, "0");
            }

            if (this.nkhd[1] == '/')
            {
                this.nkhd = "0" + this.nkhd;
            }
            if (this.nkhd[4] == '/')
            {
                this.nkhd = this.nkhd.Insert(3, "0");
            }   
        }
        public override string ToString()
        {
            return this.ma + " " + this.name + " " + this.gt + " " + this.ns + " " + this.dc + " " + this.mst + " " + this.nkhd;
        }

    }




    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string ma = "00001";
            string name = Console.ReadLine();
            string gt = Console.ReadLine();
            string ns = Console.ReadLine();
            string dc = Console.ReadLine();
            string mst = Console.ReadLine();
            string nkhd = Console.ReadLine();

            nhanvien p = new nhanvien(ma, name, gt, ns, dc , mst , nkhd);
            p.chuan_hoa();
            Console.Write(p.ToString());
            Console.ReadKey();
        }
    }
}
