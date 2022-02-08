using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDikdortgenAlanHesapla_Click(object sender, EventArgs e)
        {
            // Sınıftan nesne üretme


            // new anahtar kelimesi kullanılır
            // sinifAdi nesneadi = new sinifadi;
            Dikdortgen dikdortgen1 = new Dikdortgen(4,6);
            int alanimiz = dikdortgen1.alanHesapla();
            MessageBox.Show("Alan :" + alanimiz.ToString());

            // Örnek sonradan eklenen metin

        }
    }

    class Dikdortgen
    {
        // Sınıfa ait özellikleri tanımladık
        private int kisaKenar;
        private int uzunKenar; 

        // Sınıfların yapıcı metotları vardır
        // Constructor = yapıcı
        // Sınıftan bir nesne ürettiğimizde ilk çalışan ,
        // fonksiyona denir.
        // Erişim türü public'tir.
        // Yapıcı fonksiyonun(constructor) adı sınıf adı ile
        // aynıdır.
        public Dikdortgen(int _kisaKenar, int _uzunKenar)
        {
            this.kisaKenar = _kisaKenar;
            this.uzunKenar = _uzunKenar;
            MessageBox.Show("yapıcı fonksiyon çalıştı");
        }

        public int alanHesapla()
        {
            int alan = kisaKenar * uzunKenar;
            return alan;
        }

    }

    class Araba
    {
        // Sınıfa ait özellikleri tanımladık
        String renk;
        String marka;
        String model;
        String yil;
    }

}
