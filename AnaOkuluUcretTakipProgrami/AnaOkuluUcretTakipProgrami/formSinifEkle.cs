﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace AnaOkuluUcretTakipProgrami
{
    public partial class formSinifEkle : Form
    {
        public formSinifEkle()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti =
          new MySqlConnection(
              "Server=localhost;Database=anaokulu;Uid=root;Pwd=12345;Pooling=true;Min Pool Size=10;Max Pool Size=50;Persist Security Info=True;"
              );

        DataTable dt = new DataTable();

        int id = 0;

        void baglantiAcKapa()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                else if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

                if (baglanti.State == ConnectionState.Open)
                {
                  //  MessageBox.Show("Bağlantı açıldı");
                }
                else
                {
                  //  MessageBox.Show("Bağlantı kapatıldı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi. Hata : "
                    + ex.Message.ToString());
            }
        }


        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand komut = new MySqlCommand();
                komut.CommandText = "insert into siniflar(adi) " +
                    "values('" + txtSinifAd.Text + "') ";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                MessageBox.Show("Veri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }
        }

        private void formSinifEkle_Load(object sender, EventArgs e)
        {
            baglantiAcKapa();
        }
    }
}
