using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {

            /* // dizi tanımlama
             string[] isimler = new string[5];

             // eleman ekleme
             // diziAdi[indisNo] = eklencek_eleman;
             // isimler dizisinin ilk sırasına Ali değerini ekle
             isimler[0] = "Ali";
             isimler[1] = "Veli";
             isimler[2] = "Cabbar";
             isimler[3] = "Haydar";
             isimler[4] = "Haşmet";

             // isimler[5] = "hasan"; // hata verir. Sınır dışına çıkılamaz


             Console.WriteLine(isimler[0]);
             Console.WriteLine(isimler[1]);
             Console.WriteLine(isimler[2]);
             Console.WriteLine(isimler[3]);
             Console.WriteLine(isimler[4]);

             */

            // Diziye ilk değer atama
            int[] sayilar = new int[4] { 15, -4, 45, 65 };
      
            // for döngüsü ile dizinin elemanlarını yazdırma
            for (int sayac = 0; sayac < 4; sayac++)
                Console.WriteLine(  sayac.ToString() + 
                                    ". eleman: " + 
                                    sayilar[sayac] 
                                 );
            Console.WriteLine("\n-------------\n");

            // 100 elemanlı bir dizi tanımlayın ve içine
            // 1-100 arası sayıları atın
            int[] sayiDizisi = new int[100];
            for (int sayac = 0; sayac < 100; sayac++)
                sayiDizisi[sayac] = sayac + 1;

            for (int sayac = 0; sayac < 100; sayac++)
                Console.WriteLine(sayac.ToString() +
                                    ". eleman: " + 
                                    sayiDizisi[sayac]
                                    );

            string[] ogrenciler = new string[4] { "ali", "veli", "kamil", "mehmet" };
            Console.WriteLine("ogrenciler dizisinin içeriği :\n");
            for (int sayac = 0; sayac < 4; sayac++)
                Console.WriteLine(sayac.ToString() +
                                    ". eleman: " +
                                    ogrenciler[sayac]
                                 );
            ogrenciler[3] = "Cabbar";

            Console.WriteLine("ogrenciler dizisinin içeriği :\n");
            for (int sayac = 0; sayac < 4; sayac++)
                Console.WriteLine(sayac.ToString() +
                                    ". eleman: " +
                                    ogrenciler[sayac]
                                 );

            Console.Read();

        }
    }
}
