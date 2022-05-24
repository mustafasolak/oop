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
    public partial class formOgretmenListele : Form
    {
        public formOgretmenListele()
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
                   // MessageBox.Show("Bağlantı açıldı");
                }
                else
                {
                    //MessageBox.Show("Bağlantı kapatıldı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi. Hata : "
                    + ex.Message.ToString());
            }
        }

        void ogretmenleriGetir()
        {
            dt.Clear();
            MySqlDataAdapter adapter =
                new MySqlDataAdapter("Select * from ogretmenler", baglanti);
            adapter.Fill(dt);
            dgOgretmenler.DataSource = dt;
            dgOgretmenler.Columns[0].HeaderText = "Id";
            dgOgretmenler.Columns[1].HeaderText = "Öğretmen Adı";
            dgOgretmenler.Columns[2].HeaderText = "Öğretmen Soyadı";
            dgOgretmenler.Columns[3].HeaderText = "Öğretmen Telefon";

        }
        private void formOgretmenListele_Load(object sender, EventArgs e)
        {
            baglantiAcKapa();
            ogretmenleriGetir();
        }

        private void dgOgretmenler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgOgretmenler.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOgretmenAd.Text =
                dgOgretmenler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOgretmenSoyad.Text =
                dgOgretmenler.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtOgretmenTelefon.Text =
                dgOgretmenler.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdGuncelle =
                new MySqlCommand();
            cmdGuncelle.Connection = baglanti;
            cmdGuncelle.CommandText =
                "update ogretmenler set adi='" +
                txtOgretmenAd.Text + "', soyadi='" +
                txtOgretmenSoyad.Text + "', telefon='" +
                txtOgretmenTelefon.Text + "' where ogretmen_id='" +
                id
                + "'";
            int sonuc = cmdGuncelle.ExecuteNonQuery();
            if (sonuc != 0)
            {
                ogretmenleriGetir();
                MessageBox.Show("Veri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri güncellenemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
