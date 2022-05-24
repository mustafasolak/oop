using System;
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
    public partial class formYeniOgrenciEkle : Form
    {
        public formYeniOgrenciEkle()
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
                    MessageBox.Show("Bağlantı açıldı");
                }
                else
                {
                    MessageBox.Show("Bağlantı kapatıldı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi. Hata : "
                    + ex.Message.ToString());
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand komut = new MySqlCommand();
                komut.CommandText = "insert into ogrenciler(adi, soyadi, sinifi, numarasi, veli_adi, veli_telefon, adres) " +
                    "values('" + txtOgrenciAd.Text + "', '" +
                    txtOgrenciSoyad.Text + "','" + 
                    cmbSinif.SelectedItem.ToString() + "','" +
                    txtOgrenciNumara.Text + "','" +
                     txtOgrenciVeliAdi.Text + "','" +
                      txtOgrenciVeliTelefon.Text + "','" +
                       txtOgrenciAdres.Text + 
                    "') ";
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();

                MessageBox.Show("Veri eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }

        }

        void siniflariYukle()
        {
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from siniflar";
            MySqlDataReader myReader;
            myReader = komut.ExecuteReader();
            while (myReader.Read())
            {
                cmbSinif.Items.Add(myReader.GetString(1));
               // Console.WriteLine(myReader.GetInt32(0) + ", " + myReader.GetString(1));
            }
            // always call Close when done reading.
            myReader.Close();
            // Close the connection when done with it.
           // baglanti.Close();
        }

        private void formYeniOgrenciEkle_Load(object sender, EventArgs e)
        {
            baglantiAcKapa();
            siniflariYukle();
        }
    }
}
