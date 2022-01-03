using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSorusu1D2Y
{
    public partial class frmTelRehber : Form
    {
        public frmTelRehber()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtNumara.Text.Length == 10)
            {
                lbxNumaralar.Items.Add(txtNumara.Text);
                txtNumara.Clear();
            }
            else
            {
                MessageBox.Show("Numara 10 haneli olmalıdır !", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (txtArananNo.Text.Length == 10)
            {
                bool bulundu = false;
                for (int sayac = 0; sayac < lbxNumaralar.Items.Count; sayac++)
                {
                    if(lbxNumaralar.Items[sayac].ToString() == txtArananNo.Text)
                    {
                        bulundu = true;
                        break;
                    }
                }
                if(bulundu)
                    MessageBox.Show("Aranan numara bulundu.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Aranan numara bulunamadı !", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Aranan numara 10 haneli olmalıdır !", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
