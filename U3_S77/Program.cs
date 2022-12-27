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
            Diktorgen.diktorgen = new diktorgen(8, 10);

            console.WirtelLine("Diktörgenin Alanı:" + Diktorgen.AlanHesapla());
            console.WirtelLine("Diktörgenin çevresi:" + Diktorgen.CevreHesapla());


            console.ReadLine();
        }
    }

        

    class Diktorgen
    {
        private int a, b;

        public Diktorgen()
        {
            this.a = a;
            this.b = b;
        }
        public int AlanHesapla();
        {
        return a* b;
        }

    public int CevreHesapla();
         {
           2*(a+b);
         } 
     }
 

