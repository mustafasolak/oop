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
        MySqlConnection baglanti = 
            new MySqlConnection(
                "Server=localhost;Database=eokul;Uid=root;Pwd=12345;Pooling=true;Min Pool Size=10;Max Pool Size=50;Persist Security Info=True;"
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
                    btnBaglan.BackColor = Color.Green;
                    btnBaglan.Text = "Bağlantıyı Kapat";
                    MessageBox.Show("Bağlantı açıldı");
                }
                else
                {
                    btnBaglan.BackColor = Color.Red;
                    btnBaglan.Text = "Bağlantıyı Aç";
                    MessageBox.Show("Bağlantı kapatıldı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi. Hata : "
                    + ex.Message.ToString());
            }
        }

        void dersleriGetir()
        {
            dt.Clear();
            MySqlDataAdapter adapter =
                new MySqlDataAdapter("Select * from dersler", baglanti);
            adapter.Fill(dt);
            dtgvwDersler.DataSource = dt;
            dtgvwDersler.Columns[0].HeaderText = "Id";
            dtgvwDersler.Columns[1].HeaderText = "Ders Kodu";
            dtgvwDersler.Columns[2].HeaderText = "Ders Adı";

        }
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            baglantiAcKapa();            
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
                dersleriGetir();
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
                if (kayitsayisi == 0)
                    MessageBox.Show("Silinecek ders kodu bulunamadı!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    dersleriGetir();
                    MessageBox.Show("Ders başarıyla silindi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
            catch (Exception hata)
            {
                MessageBox.Show("Hata meydana geldi. Hata : " + hata.Message.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //baglantiAcKapa();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void btnDersleriCek_Click(object sender, EventArgs e)
        {
            dersleriGetir();
            
        }

        private void dtgvwDersler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dtgvwDersler.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDersKoduG.Text =
                dtgvwDersler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDersAdiG.Text = 
                dtgvwDersler.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdGuncelle =
                new MySqlCommand();
            cmdGuncelle.Connection = baglanti;
            cmdGuncelle.CommandText = 
                "update dersler set dersKodu='" + 
                txtDersKoduG.Text + "', dersAdi='" +
                txtDersAdiG.Text +"' where id='"+
                id
                +"'";
            int sonuc = cmdGuncelle.ExecuteNonQuery();
            if (sonuc != 0) {
                dersleriGetir();
                MessageBox.Show("Veri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri güncellenemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTabloOlustur_Click(object sender, EventArgs e)
        {
            String sqlTablo = "create table dersler(id int primary key auto_increment,dersKodu text not null,dersAdi text not null)";
            MySqlCommand cmdTabloOlustur = new MySqlCommand();
            cmdTabloOlustur.Connection = baglanti;
            cmdTabloOlustur.CommandText = sqlTablo;
            cmdTabloOlustur.ExecuteNonQuery();
            MessageBox.Show("Tablo oluştu");
        }
    }
}
