using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DictionaryKullanimi
{
    public partial class Form1 : Form
    {
        /*
         * İngilizce Türkçe kelimeleri tutmak için
         * kelimeler adında bir sözlük yapısı
         * tanımlayacağız
         * Sözlük şu şekilde tanımlanır:
         Dictionary<anahtarTuru, degerTuru> sozlukAdi = new Dictionary<anahtarTuru, degerTuru>();
         */
        Dictionary<string, string> kelimeler = new
            Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        public void sozluguYazdir()
        {
            lstKelimeler.Items.Clear();
            foreach (var msEleman in kelimeler)
            {
                string[] eklenecek = { msEleman.Key, msEleman.Value };
                ListViewItem eleman = new ListViewItem(eklenecek);
                lstKelimeler.Items.Add(eleman);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string anahtar = txtIngilizce.Text.Trim();
            string deger = txtTurkce.Text.Trim();

            /*
             * Sözlük yapısına veri eklerken add()
             * metodu kullanılır.
             * Örnek : 
             * sozlukAdi.add(anahtar, deger);
             */
            try
            {
                kelimeler.Add(anahtar, deger);
            }
            catch (Exception hataKodu)
            {
                MessageBox.Show("Eklenemedi, hata : " + hataKodu.Message.ToString());
            }
            

            sozluguYazdir();

            txtIngilizce.Clear();
            txtTurkce.Clear();
            txtIngilizce.Focus();
            

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstKelimeler.Items.Clear();

            kelimeler.Clear();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string anahtar = txtIngilizce.Text.Trim();
            string deger = txtTurkce.Text.Trim();

            kelimeler[anahtar] = deger;

            sozluguYazdir();
        }

        private void lstKelimeler_Click(object sender, EventArgs e)
        {
            txtIngilizce.Text =  lstKelimeler.SelectedItems[0].Text;
            txtTurkce.Text = lstKelimeler.SelectedItems[0].SubItems[1].Text;
        }

        private void btnDosyayaYaz_Click(object sender, EventArgs e)
        {
            string dosyaAdi = txtDosyaAdi.Text.Trim();
            /*
             //File.WriteAllText("kelimeler.txt", "selam");
             string yazilacakMetin = rctMetin.Text;
             //File.WriteAllText("kelimeler.txt", yazilacakMetin);
             File.WriteAllText(dosyaAdi, yazilacakMetin);
             */

            dosyayaYaz("ornek.txt");
        }

        private void btnDosyadanOku_Click(object sender, EventArgs e)
        {
            /*
            string dosyaAdi = txtDosyaAdi.Text.Trim();
            string okunanMetin = File.ReadAllText(dosyaAdi);
            rctOkunanMetin.Text = okunanMetin;
            */
            dosyadanOku("ornek.txt");
        }

        public void dosyayaYaz(string dosyaAdi)
        {
            FileStream fs = File.Create(dosyaAdi);
            StreamWriter yazici = new StreamWriter(fs);
            yazici.WriteLine("1.satır");
            yazici.WriteLine("2.satır");
            yazici.WriteLine("   3.satır");
            yazici.Close();
        }

        public void dosyadanOku(string dosyaAdi)
        {
            StreamReader okuyucu = File.OpenText(dosyaAdi);
            
            string satir1 = okuyucu.ReadLine();
            string satir2 = okuyucu.ReadLine();
            string okunan = okuyucu.ReadToEnd();

            rctOkunanMetin.Text = satir1 + "\n";
            rctOkunanMetin.Text += satir2 + "\n";
            rctOkunanMetin.Text += okunan;

        }
    }

   
}
