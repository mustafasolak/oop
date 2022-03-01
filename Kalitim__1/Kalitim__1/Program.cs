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

            Yonetici Mustafa = new Yonetici();
            Mustafa.ad = "Mustafa";
            Mustafa.soyad = "SOLAK";
            Mustafa.calistigi_gun_sayisi = 10;
            Mustafa.calistigi_birim = "Kafasına Göre Takılanlar";
            Mustafa.yas = 35;

            Mustafa.maasHesapla();
            Mustafa.bilgiVer();

            Isci Sefa = new Isci();
            Sefa.ad = "Sefa";
            Sefa.soyad = "Kolpa";
            Sefa.calistigi_gun_sayisi = 30;
            Sefa.calistigi_birim = "Mal Kabul";
            Sefa.yas = 16;

            Sefa.maasHesapla();
            Sefa.bilgiVer();







            /*
            // Insan sınıfından ahmet adında bir nesne türettik
            Insan ahmet = new Insan();
            ahmet.ad = "Ahmet";
            ahmet.soyad = "Yandanbakar";
            ahmet.yas = 33;
            ahmet.boy = 186.0;
            ahmet.cinsiyet = "Diğer";
            ahmet.selamVer();

            // Ogretmen sınıfından Hamza adında bir Ogretmen nesnesi türetelim
            Ogretmen hamza = new Ogretmen();
            hamza.ad = "Hamza";
            hamza.soyad = "YILMAZ";
            hamza.kilo = 76.5;
            hamza.brans = "İngilizce";
            hamza.selamVer();

            // Akademisyen sınıfından Osman adından bir Akademisyen nesnesi türetelim
            Akademisyen osman = new Akademisyen();


            */
            Console.Read();
        }
    }

    class Isci : Personel
    {
        public Isci()
        {
        }
        public void maasHesapla()
        {
            maas = (calistigi_gun_sayisi * 100) + 3000;
        }

    }

    class Yonetici : Personel
    {
        public Yonetici()
        {
        }

        public void maasHesapla()
        {
            maas = (calistigi_gun_sayisi * 300) + 6000;
        }
    }

    class Personel
    {
        public String ad;
        public String soyad;
        public int yas;
        public String calistigi_birim;
        public int calistigi_gun_sayisi;
        public double maas;

        public Personel()
        {
        }

        public void bilgiVer()
        {
            Console.WriteLine(
                "Ad :" + ad + "\n" + 
                "Soyad :" +soyad + "\n" +
                "Yaş :" + yas.ToString() + "\n" +
                "Çalıştığı Birim :" + calistigi_birim + "\n" +
                "Maaş : " + maas
                );
        }

        public void maasHesapla()
        {
            maas = (calistigi_gun_sayisi * 200) + 4000;
        }
    }



    class Akademisyen : Insan
    {
        public string brans;
        public string universite;

        public Akademisyen()
        {
            Console.WriteLine("Akademisyen constructor worked.");
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

        public new void selamVer()
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
