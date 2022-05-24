using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KitapUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int id;
            string adi;
            string yazari;
            int basimYili;
            string isbnNo;

            Console.Write("Id giriniz :");
            id = int.Parse(Console.ReadLine());
            adi = Console.ReadLine();
            yazari = Console.ReadLine();
            basimYili = int.Parse( Console.ReadLine());
            isbnNo = Console.ReadLine();
            */

            int[,] notlar = new int[2, 3];
         
            String[] isimler = new string[5];
            isimler[0] = "Derin";
            isimler[1] = "Kaan";
            isimler[2] = "Efe";
            isimler[3] = "Ali";
            isimler[4] = "Kerem";

            ArrayList plakalar = new ArrayList();
            plakalar.Add(45);
            plakalar.Add(34);
            plakalar.Add(19);
            plakalar.Add(74);

            foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka);
            }

            Dictionary<string, string> kelimeler = 
                new Dictionary<string, string>();
            kelimeler.Add("kitap",   "book");
            kelimeler.Add("kalem",   "pencil");
            kelimeler.Add("masa",    "table");
            kelimeler.Add("zorunlu", "mandatory");




            Kitap kitap1 = new Kitap(1, "Ben Robot", "Isaac ASIMOV", 1950, "9786053756040");
            Kitap kitap2 = new Kitap(2, "Vakıf İleri", "Isaac ASIMOV", 1993, "9786257442015");
            Kitap kitap3 = new Kitap(3, "Uzay Akımları", "Isaac ASIMOV", 1952, "9786053758877");
            
            List<Kitap> kitaplar = new List<Kitap>();
            kitaplar.Add(kitap1);
            kitaplar.Add(kitap2);
            kitaplar.Add(kitap3);

            Console.WriteLine("\nKayıtlı Kitaplar Listesi");
            foreach (var _kitap in kitaplar)
            {
                _kitap.kitapBilgi();
            }

            Console.Read();
        }
    }

    class Kitap
    {
        private int id;
        private string adi;
        private string yazari;
        private int basimYili;
        private string isbnNo;

        public Kitap(int _id, string _adi, string _yazari, int _basimYili, string _isbnNo) {
            id = _id;
            adi = _adi;
            yazari = _yazari;
            basimYili = _basimYili;
            isbnNo = _isbnNo;
            Console.WriteLine(_adi + " isimli kitap eklendi");
        }

        public void kitapBilgi()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("ID\t\t: " + id.ToString());
            Console.WriteLine("Adı\t\t: " + adi);
            Console.WriteLine("Yazarı\t\t: " + yazari);
            Console.WriteLine("Basım Yılı\t: " + basimYili.ToString());
            Console.WriteLine("ISBN No\t\t: " + isbnNo.ToString());
            Console.WriteLine("-----------------------------------------------\n");

        }

    }

    
}
