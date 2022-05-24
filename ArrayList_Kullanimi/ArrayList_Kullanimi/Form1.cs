using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayList_Kullanimi
{
    public partial class Form1 : Form
    {
        // Tipten bağımsız bir liste oluşturduk
        ArrayList veriler = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        public void listeyiYazdir()
        {
            // listbox'ı temizler
            lbxVeriler.Items.Clear();

            // veriler listesinin içeriğini listbox'a aktarıyoruz
            foreach (var eleman in veriler)
                lbxVeriler.Items.Add(eleman);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // veriler listesine girilen metin ekleniyor
            veriler.Add(txtVeri.Text.Trim());

            listeyiYazdir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Silme işlemi için remove ve removeAt fonksiyonları kullanılır
            // silinecek veriyi aldık
            string silinecek = txtSilinecekVeri.Text.Trim();

            // listemizin remove fonksiyonu ile veriyi silelim
            veriler.Remove(silinecek);

            listeyiYazdir();

        }

        private void btnListeyiTemizle_Click(object sender, EventArgs e)
        {
            // listenin clear() fonksiyonu ile listenin içindeki elemanları toplu halde siliyorum
            veriler.Clear();

            listeyiYazdir();
        }

        private void btnArayaEklenecekVeri_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textIndis.Text);
            veriler.Insert(i,txtArayaEklenecekVeri.Text);
            listeyiYazdir();
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            veriler.Sort();
            listeyiYazdir();
        }
    }
}
