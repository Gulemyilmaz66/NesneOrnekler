using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_106
{
    public abstract class Kutupane
    {
        public string  kitap { get; set; }
        public string Dergi { get; set; }
        public string Ansiklopedi { get; set; }

        public abstract void Oku();
    }

    public class kitap : Kutupane
    {

        public override void Oku()
        {
            Console.WriteLine("Kitap Oku");
            Console.WriteLine("Dergi Oku");
            Console.WriteLine("Ansiklopedi Oku");
        }   }
    class Program
    {
        static void Main(string[] args)
        {
                kitap ktp = new kitap
                {
                    kitap = "Aşkın Gezegeni"
                };
            Console.Write("{0} adlı", ktp.kitap);
            Console.ReadLine();
        }
    }
}
