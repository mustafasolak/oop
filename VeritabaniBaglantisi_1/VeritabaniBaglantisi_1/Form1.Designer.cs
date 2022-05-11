
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVeriEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSilinecekDersKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDersSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(15, 15);
            this.btnBaglan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(150, 42);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 255);
            this.dataGridView1.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 487);
            this.Controls.Add(this.txtSilinecekDersKodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDersKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVeriEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBaglan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Bağlantısı";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVeriEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSilinecekDersKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDersSil;
    }
}

