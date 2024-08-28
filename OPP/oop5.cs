using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{

    class giaovien
    {
        private string ma;
        private string name;
        private int luong;

        public giaovien(string ma, string name, int luong)
        {
            this.ma = ma;
            this.name = name;
            this.luong = luong;
        }
        public string get_ma { 
            get { return ma; } set { ma = value; }
        }
        public string get_name
        {
            get { return name; } set { name = value;}

        }
        public int get_luong
        {
            get { return luong; }
            set
            {
                luong = value;
            }
        }
        public int Lay_Luong
        {
            get { return int.Parse(ma.Substring(2)); }
        }
        public int phucap
        {
            get
            {

                switch (ma.Substring(0, 2)) {
                    case "HT":
                        return 2000000;
                    case "HP":
                        return 900000;
                    case "GV":
                        return 500000;
                    default:
                        return 0;
                }

            }
        }
        public int get_thu_nhap
        {
            get
            {
                return this.luong * Lay_Luong + phucap;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", ma, name, Lay_Luong, get_thu_nhap);
        }
    }

        




    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string ma = Console.ReadLine();
            string name = Console.ReadLine();
            int luong = int.Parse(Console.ReadLine());
            giaovien p = new giaovien(ma, name, luong);
            Console.Write(p.ToString());
            Console.ReadKey();

        }
    }
}
