using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziIslemleri
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[5];
        int[] numaralar = new int[5];
        int[] sayilar = { 3, -5, 6, 40, -15 };
        int indis = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Dizinin alabileceğinden fazla eleman eklenmesine izin verme
            if (indis < 5)
            {
                isimler[indis] = txtAdSoyad.Text;
                numaralar[indis] = int.Parse(txtNumara.Text);
                indis++;
                MessageBox.Show("Yeni kayıt eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("5 elemandan fazla eklenemez");
        }

        private void btnDiziElemanSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "isimler dizisi eleman sayısı :" +
                isimler.Length.ToString()
                );
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            for (int sayac = 0; sayac < isimler.Length; sayac++)
            {
                if (isimler[sayac] != null)
                    lbxOgrenciler.Items.Add(isimler[sayac]);
                if(numaralar[sayac]!= 0)
                    lbxOgrenciler.Items.Add(numaralar[sayac]);

            }
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizi eleman sayısı :" +
              sayilar.Length.ToString());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizideki en küçük eleman :" +
                sayilar.Min().ToString());
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizideki en büyük eleman :" +
                sayilar.Max().ToString());
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizideki elemanların ortalaması :" +
                sayilar.Average().ToString());
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizideki sayiların toplamı :" +
                sayilar.Sum().ToString());
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizinin ilk elemanı :" +
                sayilar.First().ToString());
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dizinin son elemanı :" +
                sayilar.Last().ToString());
        }
    }
}
