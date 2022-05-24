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
    public partial class formOgrenciListele : Form
    {
        public formOgrenciListele()
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

        void ogrencileriGetir()
        {
            dt.Clear();
            MySqlDataAdapter adapter =
                new MySqlDataAdapter("Select * from ogrenciler", baglanti);
            adapter.Fill(dt);
            dgOgrenciler.DataSource = dt;
            dgOgrenciler.Columns[0].HeaderText = "Id";
            dgOgrenciler.Columns[1].HeaderText = "Adı";
            dgOgrenciler.Columns[2].HeaderText = "Soyadı";
            dgOgrenciler.Columns[3].HeaderText = "Sınıfı";
            dgOgrenciler.Columns[4].HeaderText = "Numarası";
            dgOgrenciler.Columns[5].HeaderText = "Veli Adı";
            dgOgrenciler.Columns[6].HeaderText = "Veli Telefon";
            dgOgrenciler.Columns[7].HeaderText = "Adres";

        }
        Dictionary<int, string> siniflar = new Dictionary<int, string>();
        void siniflariYukle()
        {
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from siniflar";
            MySqlDataReader myReader;
            myReader = komut.ExecuteReader();
            while (myReader.Read())
            {
                siniflar.Add(myReader.GetInt32(0), myReader.GetString(1));
                cmbSinif.Items.Add(myReader.GetString(1));
                // Console.WriteLine(myReader.GetInt32(0) + ", " + myReader.GetString(1));
            }
            // always call Close when done reading.
            myReader.Close();
            // Close the connection when done with it.
            // baglanti.Close();

        }

        private void formOgrenciListele_Load(object sender, EventArgs e)
        {
            baglantiAcKapa();
            ogrencileriGetir();
            siniflariYukle();
        }

        private void dgOgrenciler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgOgrenciler.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOgrenciAd.Text =
                dgOgrenciler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOgrenciSoyad.Text =
                dgOgrenciler.Rows[e.RowIndex].Cells[2].Value.ToString();

            string secilenSinif = dgOgrenciler.Rows[e.RowIndex].Cells[3].Value.ToString();
            foreach (var item in siniflar)
            {
                if(item.Value == secilenSinif)
                {
                    cmbSinif.SelectedItem = secilenSinif;
                }
            }


        }
    }
}
