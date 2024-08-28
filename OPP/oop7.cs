using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{
    class SinhVien
    {
        private string ma;
        private string name;
        private float a;
        private float b;
        private float c;

        public SinhVien(string ma, string name, float a, float b, float c)
        {
            this.ma = ma;
            this.name = name;
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string LayKhuVuc
        {
            get
            {
                char kv = this.ma[2];
                return kv.ToString();
            }
        }

        public float TongDiem
        {
            get
            {
                float tong = a + b + c;
                int res = int.Parse(LayKhuVuc);
                if (res == 1)
                {
                    return tong + 0.5f;
                }
                else if (res == 2)
                {
                    return tong + 1.0f;
                }
                else
                {
                    return tong + 2.5f;
                }
            }
        }

        public string KQ
        {
            get
            {
                float ans = TongDiem;
                if (ans >= 24)
                {
                    return "TRUNG TUYEN";
                }
                else
                {
                    return "TRUOT";
                }
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", ma, name, LayKhuVuc, TongDiem, KQ);
        }
    }


    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string ma = Console.ReadLine();
            string name = Console.ReadLine();
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            SinhVien p = new SinhVien(ma, name, a, b, c);
            Console.Write(p.ToString());
            Console.ReadKey();
        }
    }
}
