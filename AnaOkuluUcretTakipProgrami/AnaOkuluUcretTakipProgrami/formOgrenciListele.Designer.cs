
namespace AnaOkuluUcretTakipProgrami
{
    partial class formOgrenciListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgOgrenciler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOgrenciAdres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOgrenciVeliTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenciVeliAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciNumara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgOgrenciler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 340);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Öğrenciler";
            // 
            // dgOgrenciler
            // 
            this.dgOgrenciler.AllowUserToAddRows = false;
            this.dgOgrenciler.AllowUserToDeleteRows = false;
            this.dgOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOgrenciler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgOgrenciler.Location = new System.Drawing.Point(3, 16);
            this.dgOgrenciler.MultiSelect = false;
            this.dgOgrenciler.Name = "dgOgrenciler";
            this.dgOgrenciler.ReadOnly = true;
            this.dgOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOgrenciler.Size = new System.Drawing.Size(483, 321);
            this.dgOgrenciler.TabIndex = 0;
            this.dgOgrenciler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrenciler_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOgrenciAdres);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtOgrenciVeliTelefon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtOgrenciVeliAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbSinif);
            this.groupBox2.Controls.Add(this.txtOgrenciAd);
            this.groupBox2.Controls.Add(this.btnOgrenciEkle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtOgrenciNumara);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox2.Location = new System.Drawing.Point(517, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 340);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // txtOgrenciAdres
            // 
            this.txtOgrenciAdres.Location = new System.Drawing.Point(77, 247);
            this.txtOgrenciAdres.Name = "txtOgrenciAdres";
            this.txtOgrenciAdres.Size = new System.Drawing.Size(120, 20);
            this.txtOgrenciAdres.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Adres :";
            // 
            // txtOgrenciVeliTelefon
            // 
            this.txtOgrenciVeliTelefon.Location = new System.Drawing.Point(76, 214);
            this.txtOgrenciVeliTelefon.Name = "txtOgrenciVeliTelefon";
            this.txtOgrenciVeliTelefon.Size = new System.Drawing.Size(120, 20);
            this.txtOgrenciVeliTelefon.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Veli Telefon :";
            // 
            // txtOgrenciVeliAdi
            // 
            this.txtOgrenciVeliAdi.Location = new System.Drawing.Point(76, 177);
            this.txtOgrenciVeliAdi.Name = "txtOgrenciVeliAdi";
            this.txtOgrenciVeliAdi.Size = new System.Drawing.Size(120, 20);
            this.txtOgrenciVeliAdi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Veli Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sınıf :";
            // 
            // cmbSinif
            // 
            this.cmbSinif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(76, 145);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(121, 21);
            this.cmbSinif.TabIndex = 7;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(76, 37);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(120, 20);
            this.txtOgrenciAd.TabIndex = 1;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(76, 283);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(120, 27);
            this.btnOgrenciEkle.TabIndex = 6;
            this.btnOgrenciEkle.Text = "Öğrenciyi Güncelle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // txtOgrenciNumara
            // 
            this.txtOgrenciNumara.Location = new System.Drawing.Point(76, 109);
            this.txtOgrenciNumara.Name = "txtOgrenciNumara";
            this.txtOgrenciNumara.Size = new System.Drawing.Size(120, 20);
            this.txtOgrenciNumara.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numarası :";
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(76, 74);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(120, 20);
            this.txtOgrenciSoyad.TabIndex = 3;
            // 
            // formOgrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formOgrenciListele";
            this.Text = "ÖĞRENCİ LİSTELEME / GÜNCELLEME FORMU";
            this.Load += new System.EventHandler(this.formOgrenciListele_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgOgrenciler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOgrenciAdres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOgrenciVeliTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenciVeliAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
    }
}