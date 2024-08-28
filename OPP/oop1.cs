using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{


    class PhanSo {
        private int tu;
        private int mau;

        public PhanSo(int tuso, int mauso)
        {
            tu = tuso;
            mau = mauso;
        }
        public int uoc(int a,int b)
        {
            while (b != 0)
            {
                a = b;
                b = a % b;
            }
            return a;
        }
        public void rg()
        {
            int uc = uoc(tu, mau);
            tu /= uc;
            mau /= uc;
        }
        public override string ToString()
        {
            return tu + "/" + mau;
        }
    }


    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string[] tm = Console.ReadLine().Split(' ');
            int t = int.Parse(tm[0]);
            int m = int.Parse(tm[1]);
            PhanSo p = new PhanSo(t, m);
            p.rg();
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
