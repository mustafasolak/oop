using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim__1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Insan sınıfından ahmet adında bir nesne türettik
            Insan ahmet = new Insan();
            ahmet.ad = "Ahmet";
            ahmet.soyad = "Yandanbakar";
            ahmet.yas = 33;
            ahmet.boy = 186.0;
            ahmet.cinsiyet = "Diğer";
            
            ahmet.selamVer();

            // Ogretmen sınıfından Hamza adında bir öğretmen nesnesi türetelim
            Ogretmen hamza = new Ogretmen();

            hamza.ad = "Hamza";
            hamza.soyad = "YILMAZ";
            hamza.kilo = 76.5;
            hamza.brans = "İngilizce";

            hamza.selamVer();

            Console.Read();
        }
    }

    class Ogretmen : Insan
    {
        public string brans;
        public string okul;
        
        public Ogretmen()
        {
            Console.WriteLine("Ogretmen constructor worked.");
        }

        public void selamVer()
        {
            Console.WriteLine("Selam ben Öğretmen sinifindan");
        }

    }

    class Insan
    {
        public string ad;
        public string soyad;
        public int yas;
        public string cinsiyet;
        public double boy;
        public double kilo;

        public Insan()
        {
            Console.WriteLine("Insan constructor worked");
        }

        public void selamVer()
        {
            Console.WriteLine("Selam ben Insan sinifindan");
        }
    }
}
