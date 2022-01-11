using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar_3_get_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNesneOlustur_Click(object sender, EventArgs e)
        {
            Araba araba1 = new Araba();
            // araba1.hiz = 100;
            araba1.setHiz(100);
            MessageBox.Show(araba1.getHiz().ToString());

        }

        private void btnHayvanNesnesiOlstur_Click(object sender, EventArgs e)
        {
            Hayvan hayvan1 = new Hayvan();
            hayvan1.Ad = "a";
            hayvan1.Yas = -1;
            hayvan1.Boy = 70;
            hayvan1.Kilo = 15.3;
            hayvan1.Yasam_alani = "Orman";

            lblAd.Text = hayvan1.Ad;
            lblYas.Text = hayvan1.Yas.ToString();
            lblBoy.Text = hayvan1.Boy.ToString();
            lblKilo.Text = hayvan1.Kilo.ToString(); 
            lblYasamAlani.Text = hayvan1.Yasam_alani.ToString();    



        }

        private void btnOgrenciOlustur_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = txtAd.Text; 
            ogrenci1.Telefon = txtTelefon.Text; 
            ogrenci1.Yas = int.Parse( txtYas.Text ); 
            ogrenci1.OkulNo = int.Parse( txtOkulNo.Text );

            MessageBox.Show(
                "Öğrenci Adı \t: " + ogrenci1.Isim + "\n"  + 
                "Telefon \t\t: " + ogrenci1.Telefon + "\n" +
                "Yaşı \t\t: " + ogrenci1.Yas + "\n" + 
                "Okul No \t\t: " + ogrenci1.OkulNo
                , "Öğrenci Bilgileri",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

        }

        private void btnStringConcat_Click(object sender, EventArgs e)
        {
            String isim = "Ali";
            MessageBox.Show(isim);
          //  isim = isim + " KEREM";
            isim = isim + " " + "KEREM";
            MessageBox.Show(isim);
            isim += " SOLAK";
            MessageBox.Show(isim);
        }
    }

    class Ogrenci
    {
        String isim;
        int okulNo;
        String telefon;
        int yas;

        // Getter ve setter fonksiyonlarını yazıyoruz
        public String Isim { get; set; }
        public int OkulNo { get; set; }
        public String Telefon { get; set; }
        public int Yas { get; set; }

        // Sınıfın yapıcı fonksiyonunu(constructor) tanımladık
        public Ogrenci()
        {
            
        }
    }

    class Hayvan
    {
        String ad;
        int yas;
        double boy;
        double kilo;
        String yasam_alani;
        public Hayvan() {  

        }
        public String Ad { 
            get {
                return ad;
            } 
            set {
                if (value.Length < 3)
                {
                    MessageBox.Show("hayvan adı en az 3 karakter olmalıdır.");
                    ad = "boş";
                }
                else
                    ad = value;
            } 
        }
        public int Yas { 
            get {
                return yas;
            } 
            set { 
                if(value<0)
                {
                    MessageBox.Show("Yaş 0'dan küçük olamaz!");
                    yas = 0;
                }
            } 
        }
        public double Boy{ get; set; }
        public double Kilo { get; set; }
        public String Yasam_alani { get; set; }
    }

    class Araba
    {
        private String model;
        private String renk;
        private int hiz;
        private double motor;

        public Araba()
        {
            
        }

        public void setHiz(int miktar)
        {
            hiz = miktar;
        }

        public int getHiz()
        {
            return hiz;
        }


    }


    
}
