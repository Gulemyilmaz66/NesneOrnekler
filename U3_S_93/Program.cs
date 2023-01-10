using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_93
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Başladı");
            Kisi k = new Kisi();
            Console.WriteLine("Adı {0}, yaşı {1}", k.Ad, k.Yas);
            Console.WriteLine("Program Bitti");
            Console.ReadLine();
        }
    }
    class Kisi
    {
        int yas;
        string ad;
        public Kisi()
        {
            yas = 16;
            ad = "GÜLEM";
            Console.WriteLine("Yapıcı Metod Çalıştı");
        }
        public int Yas
        {
            get
            {
                return yas;

            }
        }
        public string Ad
        {
            get
            {
                return ad;

            }
        }

    }

    }
