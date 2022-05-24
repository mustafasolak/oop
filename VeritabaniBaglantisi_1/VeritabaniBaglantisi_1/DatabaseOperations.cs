using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeritabaniBaglantisi_1
{
    
    class DatabaseOperations
    {
        MySqlConnection baglanti =
            new MySqlConnection(
                "Server=localhost;Database=eokul;Uid=root;Pwd=12345;Pooling=true;Min Pool Size=10;Max Pool Size=50;Persist Security Info=True;"
                );
        DataTable dt = new DataTable();
        MySqlCommand cmd = new MySqlCommand();

        public bool baglantiAc()
        {
            try
            {
                // önce bağlantı açık kapalı mı diye bakıyoruz
                if (baglanti.State == ConnectionState.Closed)
                    // bağlantı kapalı hadi açalım
                    baglanti.Open();

                if (baglanti.State == ConnectionState.Open)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool baglantiKapat()
        {
            try
            {
                // önce bağlantı açık kapalı mı diye bakıyoruz
                if (baglanti.State == ConnectionState.Open)
                    // bağlantı açık hadi kapatalım
                    baglanti.Close();

                if (baglanti.State == ConnectionState.Closed)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable verileriGetir(string tabloAdi)
        {
            dt.Clear();
            MySqlDataAdapter adapter =
                new MySqlDataAdapter("Select * from " + tabloAdi , baglanti);
            adapter.Fill(dt);
            return dt;
        }
        
        public int veriEkle(string tabloAdi, string sutunlar, string veriler)
        {
            try
            {
                cmd.CommandText = "insert into " + tabloAdi +
                        "(" + sutunlar + ") " +
                        "values(" + veriler + ") ";
                cmd.Connection = baglanti;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }

        }

        public int veriSil(string tabloAdi, string where)
        {
            try
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "delete from " + tabloAdi
                    + "where " + where;
                return cmd.ExecuteNonQuery();
               
            }
            catch (Exception hata)
            {
                return -1;
            }
        }
    }
}
