using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S77
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapını giriniz: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Daire daire = new Daire(r);
            Console.WriteLine("Dairenin alanı : " + daire.alanhesapla());
            Console.WriteLine("dairenin çevresi : " + daire.cevrehesapla());
            Console.ReadLine();

        }
    }

    class Daire
    {
        private int r;
        private double pi = 3.14;

        public Daire(int r)
        {
            this.r = r;
        }
        public double alanhesapla()
        {
            return pi * r * r;
        }
        public double cevrehesapla()
        {
            return 2 * pi * r;
        }
    }

}





