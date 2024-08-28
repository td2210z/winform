using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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

    }

    class Hoc_Sinh : Person
    {
        public string lop { get; set; }
        public float gpa { get; set; }
        public Hoc_Sinh(string ma, string name, string ns, string dc, string lop, float gpa) : base(ma, name, ns, dc)
        {
            this.lop = lop;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return ma + " " + name + " " + ns + " " + dc + " " + lop + " " + gpa;
        }

    }


    class Giao_Vien : Person
    {
        public string khoa { get; set; }
        public string luong { get; set; }
        public Giao_Vien(string ma, string name, string ns, string dc, string khoa, string luong) : base(ma, name, ns, dc)
        {
            this.khoa = khoa;
            this.luong = luong;

        }
        public override string ToString()
        {
            return ma + " " + name + " " + ns + " " + dc + " " + khoa + " " + luong;
        }
        internal class Program
        {


            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                List<Person> list = new List<Person>();
                for (int i = 0; i < n; i++)
                {
                    string ma = Console.ReadLine();
                    string name = Console.ReadLine();
                    string ns = Console.ReadLine();
                    string dc = Console.ReadLine();

                    if (ma.StartsWith("SV"))
                    {
                        string lop = Console.ReadLine();
                        float gpa = float.Parse(Console.ReadLine());
                        Hoc_Sinh p = new Hoc_Sinh(ma, name, ns, dc, lop, gpa);
                        p.chuan_hoa();
                        list.Add(p);
                    }
                    else if (ma.StartsWith("GV"))
                    {
                        string khoa = Console.ReadLine();
                        string luong = Console.ReadLine();
                        Giao_Vien z = new Giao_Vien(ma, name, ns, dc, khoa, luong);
                        z.chuan_hoa();
                        list.Add(z);
                    }

                }
                Console.WriteLine("DANH SACH SINH VIEN");
                foreach (Person p in list)
                {
                    if (p is Hoc_Sinh)
                    {
                        Console.WriteLine(p.ToString());
                    }
                }
                Console.WriteLine("DANH SACH GIAO VIEN");
                foreach (Person z in list)
                {
                    if (z is Giao_Vien)
                    {
                        Console.WriteLine(z.ToString());
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
