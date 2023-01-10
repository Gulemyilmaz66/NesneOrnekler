using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_100
{
    class Okulpersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    class Ogretmen:Okulpersoneli 
    {
        public string Brans { get; set; }

    }
    

    
    class Program
    {
        static void Main(string[] args)
        {
            Okulpersoneli per = new Okulpersoneli();
            Ogretmen ogrt = new Ogretmen();

            ogrt.Ad = "gülem";
            ogrt.Soyad = "yılmaz";
            ogrt.Brans = "polis";
            Console.WriteLine("Ogretmen Sınıfından Türetilen {0} {1} {2}", ogrt.Ad, ogrt.Soyad, ogrt.Brans);

            per.Ad = "Kardelen";
            per.Soyad = "Özkan";
            Console .WriteLine (" Okulpersoneli  Sınıfından Türetilen {0} {1}", per.Ad, per.Soyad );
            Console.ReadLine();
        }
    }
}
