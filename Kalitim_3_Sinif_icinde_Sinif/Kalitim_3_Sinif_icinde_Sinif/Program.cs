using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_3_Sinif_icinde_Sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ders sınıfından ders1 adında bir nesne oluşturun
            Ders ders1 = new Ders();
            ders1.dersAdi = "Matematik";
            ders1.kacSaat = 5;

            // Ogrenci sınıfından ogrenci1 adında bir nesne türetin
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.adi = "Ahmet";
            ogrenci1.okulNo = 55;
            ogrenci1.sinif = "10/F";
            ogrenci1.dersler = ders1;

            // ekrana öğrencinin bilgilerini yazdıralım
            ogrenci1.bilgi();

            //Ogrenci sınıfından ogrenci2 adında bir nesne oluştur
            Ogrenci ogrenci2 = new Ogrenci();

            // Ders sınıfından ders2 adında bir nesne oluşturun
            Ders ders2 = new Ders();

            // ders2 nesnesinin ders adını Fizik yapalım
            ders2.dersAdi = "Fizik";

            //ders2 nesnesinin ders saatini 3 yapalım
            ders2.kacSaat = 3;

            // Ders sınıfından ders3 adında bir nesne oluştur
            Ders ders3 = new Ders();












            Console.Read();
        }
    }

    class Ogrenci
    {
        public string adi;
        public int okulNo;
        public string sinif;
        public Ders dersler;

        public Ogrenci()
        {
        }

        public void bilgi()
        {
            Console.WriteLine(
                "Ad\t\t: " + adi + "\n" +
                "Okul No\t\t: " + okulNo + "\n" +
                "Sınıf\t\t: " + sinif + "\n"  +
                "Ders Adı\t: " + dersler.dersAdi + "\n" +
                "Kaç Saat\t: " + dersler.kacSaat + "\n" 
                    
            );
        }
    }

    class Ders
    {
        public string dersAdi;
        public int kacSaat;

        public Ders()
        {
        }
    }

}
