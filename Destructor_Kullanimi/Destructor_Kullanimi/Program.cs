using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor_Kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı.");

            Ogrenci ogrenci1 = new Ogrenci("Ali",15);
            ogrenci1.bilgi();
        

            Console.WriteLine("Program bitti.");
            Console.Read();

        }
    }

    class Ogrenci
    {
        string adi;
        int numarasi;
        // Yapıcı metot
        public Ogrenci(string _adi, int _numarasi)
        {
            this.adi = _adi;
            this.numarasi = _numarasi;
            Console.WriteLine("Yapıcı fonksiyon çalıştı.");
        }
        // Yıkıcı Metot
        ~Ogrenci()
        {
            Console.WriteLine("Yıkıcı fonksiyon çalıştı.");
        }

        public void bilgi()
        {
            Console.WriteLine(
                "Adı :" + 
                this.adi + 
                "\nNumarası :" + 
                this.numarasi.ToString());
        }

       
    }
}
