using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Form çalıştığında ilk çalışan fonksiyon
        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Ben çalıştım");
            this.Text = "OOP Work 2";
            this.Width = 600;
            this.Height = 400;
            this.BackColor = Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnArabaOlustur_Click(object sender, EventArgs e)
        {
            // Sinifadi nesneadi = new sinifadi();
            Araba araba1 = new Araba();
            araba1.setRenk("Kırmızı");
            araba1.setModel("Polo");
            araba1.setMotor(1.6);
            araba1.setHiz(20);

            rctMetin.Text = araba1.getRenk() + "\n";
            rctMetin.Text += araba1.getModel() + "\n";
            rctMetin.Text += araba1.getMotor().ToString() + "\n";
            rctMetin.Text += araba1.getHiz().ToString() + "\n";



        }
    }

    class Araba
    {
        private string renk;
        private string model;
        private double motor;
        private int hiz;

        public Araba()
        {
            MessageBox.Show("constructor worked !");
        }

        public void hizlan(int miktar)
        {
            hiz += miktar;
        }

        public void yavasla(int miktar)
        {
            hiz -= miktar;
        }

        public void dur()
        {
            hiz = 0;
        }

        public int hizGoster()
        {
            return hiz;
        }

        public string getRenk()
        {
            return renk;
        }

        public void setRenk(string _renk)
        {
            this.renk = _renk;
        }

        public string getModel()
        {
            return model;
        }

        public void setModel(string _model)
        {
            this.model = _model;
        }

        public double getMotor()
        {
            return motor;
        }

        public void setMotor(double _motor)
        {
            this.motor = _motor;
        }

        public int getHiz()
        {
            return hiz;
        }

        public void setHiz(int _hiz)
        {
            this.hiz = _hiz;
        }

        // getter  ve setter

    }
}
