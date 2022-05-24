using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaOkuluUcretTakipProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void öğretmenİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yeniÖğretmenEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYeniOgretmenEkle newMDIChild = new formYeniOgretmenEkle();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void yeniÖğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formYeniOgrenciEkle newMDIChild = new formYeniOgrenciEkle();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void öğretmenleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOgretmenListele newMDIChild = new formOgretmenListele();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void sınıfEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSinifEkle newMDIChild = new formSinifEkle();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void sınıflarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSinifListele newMDIChild = new formSinifListele();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void öğrencileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOgrenciListele newMDIChild = new formOgrenciListele();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
