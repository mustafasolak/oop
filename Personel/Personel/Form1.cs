using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel
{
    public partial class Form1 : Form
    {
        // sınıfadı nesneadı = new sınıfadı();
        Kisi kisi1;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnKisiOlustur_Click(object sender, EventArgs e)
        {
            kisi1 = new Kisi("12345678912", "Mustafa", "SOLAK", "01/02/2004", "Erkek", "mustafa@gmail.com");
            MessageBox.Show("Kişi oluşturuldu.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnKisiBilgisiGoster_Click(object sender, EventArgs e)
        {
            kisi1.ogrenciBilgisiYazdir();
        }

        private void btnAdDegistir_Click(object sender, EventArgs e)
        {
           kisi1.adDegistir(txtYeniAd.Text);
           MessageBox.Show("Ad bilgisi değiştirildi.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    class Kisi
    {
        private string TcNo;
        private string adi;
        private string soyadi;
        private string dogumTarihi;
        private string cinsiyet;
        private string email;

        public Kisi(string _TcNo, string _adi, string _soyadi, string _dogumTarihi, string _cinsiyet, string _email)
        {
            TcNo = _TcNo;
            adi = _adi;
            soyadi = _soyadi;
            dogumTarihi = _dogumTarihi;
            cinsiyet = _cinsiyet;
            email = _email;
        }

        public void ogrenciBilgisiYazdir()
        {
            MessageBox.Show(
                "Adı    : " + adi + "\n" +
                "Soyadı : " + soyadi + "\n" +
                "TC No  : " + TcNo + "\n" +
                "Doğum Tarihi : " + dogumTarihi + "\n" +
                "Cinsiyet : " + cinsiyet + "\n" +
                "Email : " + email + "\n",
                "Kişi Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
        }

        public void adDegistir(string _yeniAd)
        {
            adi = _yeniAd;
        }

    }
}
