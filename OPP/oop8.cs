using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{
    
    class MatHang : IComparable<MatHang>
    {
        private static int nextID = 1;
        public string ma { get; }
        public string name { get; set; } 
        public string DonVi { get; set; }
        public int GiaBan { get; set; }
        public int GiaMua { get; set; }

        public MatHang(string name, string donVi, int giaBan, int giaMua)
        {
            this.ma = "MH" + nextID++.ToString("D4");
            this.name = name;
            DonVi = donVi;
            GiaBan = giaBan;
            GiaMua = giaMua;
        }
        public int Loi_nhuan
        {
            get
            {
                return GiaMua - GiaBan;
            }
        }
        public int CompareTo(MatHang order)
        {
            int res = order.Loi_nhuan.CompareTo(this.Loi_nhuan);
            if (res == 0)
            {
                return this.ma.CompareTo(order.ma);
            }
            return res;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", ma, name, GiaBan, GiaMua, Loi_nhuan);
        }
    }

    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<MatHang> p = new List<MatHang>();
            for (int i =0;i < n; i++)
            {
                string name = Console.ReadLine();
                string DonVi = Console.ReadLine();
                int GiaBan = int.Parse(Console.ReadLine());
                int GiaMua = int.Parse(Console.ReadLine());
                p.Add(new MatHang(name, DonVi, GiaBan, GiaMua));
            }
            p.Sort();
            foreach(MatHang i in p)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}
