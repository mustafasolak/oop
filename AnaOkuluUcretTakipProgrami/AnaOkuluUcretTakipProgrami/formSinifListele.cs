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
    public partial class formSinifListele : Form
    {
        public formSinifListele()
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

        void siniflariGetir()
        {
            dt.Clear();
            MySqlDataAdapter adapter =
                new MySqlDataAdapter("Select * from siniflar", baglanti);
            adapter.Fill(dt);
            dgSiniflar.DataSource = dt;
            dgSiniflar.Columns[0].HeaderText = "Id";
            dgSiniflar.Columns[1].HeaderText = "Sınıf Adı";
          

        }

        private void formSinifListele_Load(object sender, EventArgs e)
        {
            baglantiAcKapa();
            siniflariGetir();
        }

        private void dgSiniflar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgSiniflar.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtSinifAd.Text =
                dgSiniflar.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSinifGuncelle_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdGuncelle =
                new MySqlCommand();
            cmdGuncelle.Connection = baglanti;
            cmdGuncelle.CommandText =
                "update siniflar set adi='" +
                txtSinifAd.Text  + "' where sinif_id='" +
                id
                + "'";
            int sonuc = cmdGuncelle.ExecuteNonQuery();
            if (sonuc != 0)
            {
                siniflariGetir();
                MessageBox.Show("Veri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri güncellenemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
