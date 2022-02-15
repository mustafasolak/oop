using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShipGame
{
    public partial class Form1 : Form
    {
        int hareketHizi = 20;

        List<PictureBox> mermiListesi = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbSpaceShip.Location = new Point(218, 436);
            timer1.Enabled = true;
            timer1.Start();
            //  pictureBox1.Location = new Point(5, 15);
        }
        int x = 30;
        int y = 30;
        private void btnAddNewButton_Click(object sender, EventArgs e)
        {
            PictureBox pbMermi = new PictureBox();
            pbMermi.Name = "pbMermi1";
            pbMermi.Image = Image.FromFile(@"mermi.png");
            pbMermi.Size = new Size(32, 32);
            pbMermi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMermi.Location = new Point(x, y);

            this.Controls.Add(pbMermi);
            //x += 50;
            y += 50;


        }

        void mermiOlustur(int x, int y)
        {
            PictureBox pbMermi = new PictureBox();
            pbMermi.Name = "pbMermi1";
            pbMermi.Image = Image.FromFile(@"mermi.png");
            pbMermi.Size = new Size(32, 32);
            pbMermi.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMermi.Location = new Point(x+16, y-32);
            pbMermi.BringToFront();

            this.Controls.Add(pbMermi);
            mermiListesi.Add(pbMermi);
        }

        void hareketEt()
        {
            for(int sayac=0; sayac < mermiListesi.Count; sayac++)
            {
                int x = mermiListesi[sayac].Location.X;
                int y = mermiListesi[sayac].Location.Y;
                y -= 5;

                mermiListesi[sayac].Location = new Point(x, y);
                if (y <= -10)
                {
                    this.Controls.Remove(mermiListesi[sayac]);
                    mermiListesi.RemoveAt(sayac);

                }
            }
            
        }

        private void btnHAreket_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hareketEt();

            /*int x = pbOrnekMermi.Location.X;
            int y = pbOrnekMermi.Location.Y;
            y -= 5;
            
            pbOrnekMermi.Location = new Point(x, y);
            if (y <= -32)
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
                MessageBox.Show("mermi çıktı ");
            }*/
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                //MessageBox.Show("space basıldı");
                
                int gemiX = pbSpaceShip.Location.X;
                int gemiY = pbSpaceShip.Location.Y;

                mermiOlustur(gemiX, gemiY);


            }else if(e.KeyCode == Keys.Left)
            {
                // MessageBox.Show("sola  basıldı");
                int x = pbSpaceShip.Location.X;
                int y = pbSpaceShip.Location.Y;
                x -= hareketHizi;
                if(x>=-2)
                    pbSpaceShip.Location = new Point(x, y);

            }
            else if (e.KeyCode == Keys.Right)
            {
                //MessageBox.Show("saga  basıldı");
                int x = pbSpaceShip.Location.X;
                int y = pbSpaceShip.Location.Y;
                x += hareketHizi;
                if (x <= 440)
                    pbSpaceShip.Location = new Point(x, y);
            }
          else if (e.KeyCode == Keys.Down)
            {
                // MessageBox.Show("aşağı  basıldı");
                int x = pbSpaceShip.Location.X;
                int y = pbSpaceShip.Location.Y;
                y += hareketHizi;
                if (y<=436)
                    pbSpaceShip.Location = new Point(x, y);
            }
            else if (e.KeyCode == Keys.Up)
            {
                // MessageBox.Show("yukarı  basıldı");
                int x = pbSpaceShip.Location.X;
                int y = pbSpaceShip.Location.Y;
                y -= hareketHizi;
                if(y>=0)
                pbSpaceShip.Location = new Point(x, y);
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }

    
}
