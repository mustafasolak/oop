using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VeritabaniBaglantisi_1
{
    public partial class Form1 : Form
    {
        /*
dersler tablosu oluşturduk.

CREATE TABLE dersler (
dersid int primary key auto_increment not null,
dersKodu text not null,
dersAdi text not null
)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;
         */

        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(
                "Server=localhost;Database=eokul;Uid=root;Pwd=12345;"
                );
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    MessageBox.Show("Bağlantı açıldı");
                   /* baglanti.Close();
                    if(baglanti.State == ConnectionState.Closed)
                        MessageBox.Show("Bağlantı kapatıldı");
                    else
                        MessageBox.Show("Bağlantı kapatılamadı");*/
                }
                else
                {
                    MessageBox.Show("Bağlantı açılamadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + ex.Message.ToString());
                
            }
            

            
        }

        private void btnVeriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand komut = new MySqlCommand();
                komut.CommandText = "insert into dersler(dersAdi, dersKodu) " +
                    "values('" + txtDersAdi.Text + "', '" + txtDersKodu.Text + "') ";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                MessageBox.Show("Veri eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }


        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdsil = new MySqlCommand();
                cmdsil.Connection = baglanti;
                cmdsil.CommandText = "delete from dersler where dersKodu='"+
                    txtSilinecekDersKodu.Text + "'";
                int kayitsayisi = cmdsil.ExecuteNonQuery();
                if(kayitsayisi == 0)
                    MessageBox.Show("Silinecek ders kodu bulunamadı!", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Ders başarıyla silindi.", "Bilgi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }

        }
    }
}
