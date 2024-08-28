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
        private int luong;
        private int ngaycong;
        private string chucvu;


        public nhanvien(string ma, string name, int luong, int ngaycong, string chucvu)
        {
            this.ma = ma;
            this.name = name;
            this.luong = luong;
            this.ngaycong = ngaycong;
            this.chucvu = chucvu;
        }
        public int luong_co_ban
        {
            get { return this.luong * this.ngaycong; }
        }
        public int thuong
        {
            get {
                int ans = luong_co_ban;
                if (this.ngaycong >= 25)
                {
                    return (int)(ans * 0.2);
                } else if (this.ngaycong >= 22)
                {
                    return (int)(ans * 0.1);
                }
                else
                {
                    return 0;
                }
            }
        }
        public int phucap
        {
            get
            {
                switch (this.chucvu) {
                    case "GD":
                        return 250000;
                    case "PGD":
                        return 200000;
                    case "TP":
                        return 180000;
                    case "NV":
                        return 150000;
                    default:
                        return 0;
                }

            }
        }

        public int thu_nhap {
            get
            {
                return thuong + luong_co_ban + phucap;
            }

        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", ma, name, luong_co_ban, thuong, phucap, thu_nhap);
        }

    }





    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string ma = "NV01";
            string name = Console.ReadLine();
            int luong = int.Parse(Console.ReadLine());
            int ngaycong = int.Parse(Console.ReadLine());
            string chucvu = Console.ReadLine();

            nhanvien p = new nhanvien(ma, name, luong, ngaycong, chucvu);
            Console.Write(p.ToString());
            Console.ReadKey();
        }
    }
}
