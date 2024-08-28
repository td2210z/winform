using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Linq;

namespace ConsoleApp1
{
    class Person
    {
        public string ma { get; set; }
        public string name { get; set; }
        public string ns { get; set; }
        public string dc { get; set; }

        public Person(string ma, string name, string ns, string dc)
        {
            this.ma = ma;
            this.name = name;
            this.ns = ns;
            this.dc = dc;
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

        }

        public override string ToString()
        {
            return ma + " " + name + " " + ns + " " + dc;
        }



        class Hoc_sinh : Person
        {
            public string lop { get; set; }
            public float gpa { get; set; }

            public Hoc_sinh(string ma, string name, string ns, string dc, string lop, float gpa) : base(ma, name, ns, dc)
            {
                this.lop = lop;
                this.gpa = gpa;
            }
            public override string ToString()
            {
                return $"{ma} {name} {ns} {dc} {lop} {gpa:F2}";
            }
        }

        class Giao_Vien : Person
        {
            public string khoa { get; set; }
            public string luong { get; set; }
            public string lop { get; set; }

            public Giao_Vien(string ma, string name, string ns, string dc, string khoa, string luong, string lop) : base(ma, name, ns, dc)
            {
                this.khoa = khoa;
                this.luong = luong;
                this.lop = lop;

            }
            public override string ToString()
            {
                return ma + " " + name + " " + ns + " " + dc + " " + khoa + " " + luong + " " + lop;
            }
        }
        internal class Program
        {


            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                List<Person> list = new List<Person>();
                List<Giao_Vien> res = new List<Giao_Vien> ();
                List<Hoc_sinh> res2 = new List<Hoc_sinh>();
                for (int i =0;i < n; i++)
                {
                    string ma = Console.ReadLine();
                    string name = Console.ReadLine();
                    string ns = Console.ReadLine();
                    string dc = Console.ReadLine();
                    if (ma.StartsWith("GV"))
                    {
                        string khoa = Console.ReadLine();
                        string luong = Console.ReadLine();
                        string lop = Console.ReadLine();
                        Giao_Vien p = new Giao_Vien(ma, name, ns, dc, khoa, luong, lop);
                        p.chuan_hoa();
                        res.Add(p);
                    } else if (ma.StartsWith("SV"))
                    {
                        string lop = Console.ReadLine();
                        float gpa = float.Parse(Console.ReadLine());
                        Hoc_sinh z = new Hoc_sinh(ma, name, ns, dc, lop, gpa);
                        z.chuan_hoa();
                        res2.Add(z);
                    }
                }
                string Ten_lop = Console.ReadLine();
                Console.WriteLine("DANH SACH GIAO VIEN PHU TRACH LOP " + Ten_lop + ": ");
                foreach(Giao_Vien i in res)
                {
                    if (i.lop == Ten_lop)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
                Console.WriteLine("DANH SACH HOC SINH O LOP" + Ten_lop + " : ");
                foreach(Hoc_sinh i in res2)
                {
                    if (i.lop == Ten_lop)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }

                Console.ReadKey();
            }
        }
    }
}

