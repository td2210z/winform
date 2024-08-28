using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class CuaHang
    {
        public string ma { get; set; }
        public string name { get; set; }    
        public string hang { get; set; }
        public string mausac { get; set; }

        public CuaHang(string ma , string name ,string hang ,string mausac)
        {
            this.ma = ma;
            this.name = name;
            this.hang = hang;
            this.mausac = mausac;

        }
        public override string ToString()
        {
            return ma + " " + name + " " + hang + " " + mausac;
        }
    }

    class Xe_May : CuaHang
    {
        public int tocdo { get; set; }
        public int gia { get; set; }
        public Xe_May(string ma, string name, string hang, string mausac, int tocdo, int gia) : base(ma, name, hang, mausac)
        {
            this.tocdo = tocdo;
            this.gia = gia;

        }
        public override string ToString()
        {
            return ma + " " + name + " " + hang + " " + mausac + " " + tocdo + " " + gia;
        }
    }

    class Oto : CuaHang
    {
        public int maluc { get; set; }
        public int giaban { get; set; }
        public Oto(string ma, string name, string hang, string mausac, int maluc, int giaban) : base(ma, name, hang, mausac)
        {
            this.maluc = maluc;
            this.giaban = giaban;

        }
        public override string ToString()
        {
            return ma + " " + name + " " + hang + " " + mausac + " " + maluc + " " + giaban;
        }
    }
        internal class Program
        {


            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                List<CuaHang> cd = new List<CuaHang>(); 
                List<Xe_May> p  = new List<Xe_May>();
                List<Oto> z = new List<Oto>();
                for (int i =0; i < n; i++)
            {
                string ma = Console.ReadLine();
                string name = Console.ReadLine();
                string hang = Console.ReadLine();
                string mausac = Console.ReadLine();
                if (ma.StartsWith("OT"))
                {
                    int maluc = int.Parse(Console.ReadLine());
                    int giaban = int.Parse(Console.ReadLine());
                    Oto ans = new Oto(ma, name, hang, mausac , maluc , giaban);
                    cd.Add(ans);
                } else if (ma.StartsWith("XM"))
                {
                    int tocdo = int.Parse(Console.ReadLine());
                    int gia = int.Parse(Console.ReadLine());
                    Xe_May res = new Xe_May(ma , name , hang , mausac , tocdo, gia);
                    cd.Add(res);
                }
            }
                string Hang_xe = Console.ReadLine();
                Console.WriteLine("DANH SACH XE " + Hang_xe + ":");
                foreach (CuaHang i in cd)
                {
                    if (i is Oto && i.name == Hang_xe)
                    {
                         Console.WriteLine(i.ToString());
                    }
                }
                Console.WriteLine("DANH SACH XE MAY LA " + Hang_xe + " : ");
                foreach (CuaHang i in cd)
                {
                    if (i is Xe_May && i.name == Hang_xe)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }


            Console.ReadKey();
            }
        }
    }




