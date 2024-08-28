using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{

    class person
    {
        public string name { get; set; }
        public string ms { get; set; }
        public string diachi { get; set; }

        public person(string name , string ms , string diachi) {
            this.name = name;
            this.ms = ms;
            this.diachi = diachi;
        }
        public override string ToString()
        {
            return $"{name} {ms} {diachi}";
        }


        class Student : person {
            private static int dem = 1;
            public string ma { get; }
            public float gpa
            {
                get; set;
            }
            public string lop { get; set; }


            public Student(string name , string ms , string diachi , string lop , float gpa) : base(name , ms ,diachi) {
                this.ma = dem++.ToString("D4");
                this.gpa = gpa;
                this.lop = lop;

            }
            public override string ToString()
            {
                return $"{ma} {name} {ms} {diachi} {lop} {gpa:2F}";
            }

        }

        internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> s = new List<Student>();
            for (int i =0;i < n; i++)
                {
                    string name = Console.ReadLine();
                    string ns = Console.ReadLine();
                    string dc = Console.ReadLine();
                    string lop = Console.ReadLine();
                    float gpa = float.Parse(Console.ReadLine());
                    Student p = new Student(name , ns , dc , lop , gpa);
                    s.Add(p);
                }
            
            foreach (Student i in s)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
}
