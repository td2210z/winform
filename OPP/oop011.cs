using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ConsoleApp1
{

    class Quannet : IComparable<Quannet>
    {
        public string user { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string giovao { get; set; }
        public string giora { get; set; }

        public Quannet(string user , string password , string name , string giovao , string giora)
        {
            this.user = user;
            this.password = password;
            this.name = name;
            this.giovao = giovao;
            this.giora = giora;

        }
        public int thoi_gian
        {
            get
            {
                int h1 = int.Parse(giovao.Substring(0 , 2));
                int h2 = int.Parse(giovao.Substring(3));
                int m1 = int.Parse(giora.Substring(0, 2));
                int m2 = int.Parse(giora.Substring(3));
                int time1 = h1 * 60 + h2;
                int time2 = m1 * 60 + m2;
                return time2 - time1;
            }
        }

        public int CompareTo(Quannet oder)
        {
            
            int ans = oder.thoi_gian.CompareTo(this.thoi_gian);
            if (ans == 0)
            {
                return oder.user.CompareTo(this.user);
            }
            return ans;

        }
        public override string ToString()
        {
            int ans = thoi_gian;
            int gio = ans / 60;
            int phut = ans % 60;
            return $"{user} {password} {name} {gio} gio {phut} phut";
        }

        internal class Program
    {
        
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Quannet> p = new List<Quannet>();
            for (int i =0 ;i < n; i++)
            {
                string user = Console.ReadLine();
                string pass = Console.ReadLine();
                string name = Console.ReadLine();
                string den = Console.ReadLine();
                string di = Console.ReadLine();
                Quannet res = new Quannet(user, pass, name, den, di);
                p.Add(res);
            }
            p.Sort();
            foreach (Quannet i in p)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}


}