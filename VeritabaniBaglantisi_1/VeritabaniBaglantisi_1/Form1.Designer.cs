
namespace VeritabaniBaglantisi_1
{
    partial class Form1
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
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnVeriEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSilinecekDersKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.dtgvwDersler = new System.Windows.Forms.DataGridView();
            this.btnDersleriCek = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDersAdiG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDersKoduG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnTabloOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwDersler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.BackColor = System.Drawing.Color.Red;
            this.btnBaglan.ForeColor = System.Drawing.Color.White;
            this.btnBaglan.Location = new System.Drawing.Point(15, 15);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(6);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(186, 65);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = false;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnVeriEkle
            // 
            this.btnVeriEkle.Location = new System.Drawing.Point(38, 322);
            this.btnVeriEkle.Margin = new System.Windows.Forms.Padding(6);
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.Size = new System.Drawing.Size(104, 59);
            this.btnVeriEkle.TabIndex = 2;
            this.btnVeriEkle.Text = "Ders Ekle";
            this.btnVeriEkle.UseVisualStyleBackColor = true;
            this.btnVeriEkle.Click += new System.EventHandler(this.btnVeriEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ders Kodu";
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(38, 170);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(104, 29);
            this.txtDersKodu.TabIndex = 4;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(38, 261);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(104, 29);
            this.txtDersAdi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ders Adı";
            // 
            // txtSilinecekDersKodu
            // 
            this.txtSilinecekDersKodu.Location = new System.Drawing.Point(172, 170);
            this.txtSilinecekDersKodu.Name = "txtSilinecekDersKodu";
            this.txtSilinecekDersKodu.Size = new System.Drawing.Size(104, 29);
            this.txtSilinecekDersKodu.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ders Kodu";
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(172, 218);
            this.btnDersSil.Margin = new System.Windows.Forms.Padding(6);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(104, 59);
            this.btnDersSil.TabIndex = 7;
            this.btnDersSil.Text = "Dersi Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // dtgvwDersler
            // 
            this.dtgvwDersler.AllowUserToAddRows = false;
            this.dtgvwDersler.AllowUserToDeleteRows = false;
            this.dtgvwDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvwDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvwDersler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgvwDersler.Location = new System.Drawing.Point(304, 98);
            this.dtgvwDersler.MultiSelect = false;
            this.dtgvwDersler.Name = "dtgvwDersler";
            this.dtgvwDersler.ReadOnly = true;
            this.dtgvwDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvwDersler.Size = new System.Drawing.Size(300, 192);
            this.dtgvwDersler.TabIndex = 10;
            this.dtgvwDersler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvwDersler_CellDoubleClick);
            // 
            // btnDersleriCek
            // 
            this.btnDersleriCek.Location = new System.Drawing.Point(304, 30);
            this.btnDersleriCek.Margin = new System.Windows.Forms.Padding(6);
            this.btnDersleriCek.Name = "btnDersleriCek";
            this.btnDersleriCek.Size = new System.Drawing.Size(142, 59);
            this.btnDersleriCek.TabIndex = 11;
            this.btnDersleriCek.Text = "Dersleri Getir";
            this.btnDersleriCek.UseVisualStyleBackColor = true;
            this.btnDersleriCek.Click += new System.EventHandler(this.btnDersleriCek_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDersAdiG);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDersKoduG);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDersGuncelle);
            this.groupBox1.Location = new System.Drawing.Point(610, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 323);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Güncelle";
            // 
            // txtDersAdiG
            // 
            this.txtDersAdiG.Location = new System.Drawing.Point(21, 175);
            this.txtDersAdiG.Name = "txtDersAdiG";
            this.txtDersAdiG.Size = new System.Drawing.Size(104, 29);
            this.txtDersAdiG.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ders Adı";
            // 
            // txtDersKoduG
            // 
            this.txtDersKoduG.Location = new System.Drawing.Point(21, 84);
            this.txtDersKoduG.Name = "txtDersKoduG";
            this.txtDersKoduG.Size = new System.Drawing.Size(104, 29);
            this.txtDersKoduG.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ders Kodu";
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.Location = new System.Drawing.Point(21, 236);
            this.btnDersGuncelle.Margin = new System.Windows.Forms.Padding(6);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(104, 59);
            this.btnDersGuncelle.TabIndex = 7;
            this.btnDersGuncelle.Text = "Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnTabloOlustur
            // 
            this.btnTabloOlustur.Location = new System.Drawing.Point(304, 331);
            this.btnTabloOlustur.Margin = new System.Windows.Forms.Padding(6);
            this.btnTabloOlustur.Name = "btnTabloOlustur";
            this.btnTabloOlustur.Size = new System.Drawing.Size(142, 91);
            this.btnTabloOlustur.TabIndex = 13;
            this.btnTabloOlustur.Text = "Dersler Tablo Oluştur";
            this.btnTabloOlustur.UseVisualStyleBackColor = true;
            this.btnTabloOlustur.Click += new System.EventHandler(this.btnTabloOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 497);
            this.Controls.Add(this.btnTabloOlustur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDersleriCek);
            this.Controls.Add(this.dtgvwDersler);
            this.Controls.Add(this.txtSilinecekDersKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVeriEkle);
            this.Controls.Add(this.btnBaglan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Bağlantısı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvwDersler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnVeriEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSilinecekDersKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.DataGridView dtgvwDersler;
        private System.Windows.Forms.Button btnDersleriCek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDersAdiG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDersKoduG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnTabloOlustur;
    }
}

