
namespace ArrayList_Kullanimi
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
            this.lbxVeriler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtSilinecekVeri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListeyiTemizle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArayaEklenecekVeri = new System.Windows.Forms.TextBox();
            this.btnArayaEklenecekVeri = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textIndis = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSirala = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxVeriler
            // 
            this.lbxVeriler.FormattingEnabled = true;
            this.lbxVeriler.ItemHeight = 18;
            this.lbxVeriler.Location = new System.Drawing.Point(231, 47);
            this.lbxVeriler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbxVeriler.Name = "lbxVeriler";
            this.lbxVeriler.Size = new System.Drawing.Size(197, 184);
            this.lbxVeriler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veri :";
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(88, 30);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(70, 24);
            this.txtVeri.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(88, 70);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(70, 29);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste içindeki veriler";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(88, 68);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 29);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtSilinecekVeri
            // 
            this.txtSilinecekVeri.Location = new System.Drawing.Point(88, 28);
            this.txtSilinecekVeri.Name = "txtSilinecekVeri";
            this.txtSilinecekVeri.Size = new System.Drawing.Size(70, 24);
            this.txtSilinecekVeri.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Silinecek";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtVeri);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veri Ekleme";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSilinecekVeri);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Location = new System.Drawing.Point(13, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 110);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veri Silme";
            // 
            // btnListeyiTemizle
            // 
            this.btnListeyiTemizle.Location = new System.Drawing.Point(13, 401);
            this.btnListeyiTemizle.Name = "btnListeyiTemizle";
            this.btnListeyiTemizle.Size = new System.Drawing.Size(201, 29);
            this.btnListeyiTemizle.TabIndex = 8;
            this.btnListeyiTemizle.Text = "Listeyi Temizle";
            this.btnListeyiTemizle.UseVisualStyleBackColor = true;
            this.btnListeyiTemizle.Click += new System.EventHandler(this.btnListeyiTemizle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textIndis);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtArayaEklenecekVeri);
            this.groupBox3.Controls.Add(this.btnArayaEklenecekVeri);
            this.groupBox3.Location = new System.Drawing.Point(12, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 147);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Veri Araya Ekleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Veri :";
            // 
            // txtArayaEklenecekVeri
            // 
            this.txtArayaEklenecekVeri.Location = new System.Drawing.Point(88, 30);
            this.txtArayaEklenecekVeri.Name = "txtArayaEklenecekVeri";
            this.txtArayaEklenecekVeri.Size = new System.Drawing.Size(70, 24);
            this.txtArayaEklenecekVeri.TabIndex = 2;
            // 
            // btnArayaEklenecekVeri
            // 
            this.btnArayaEklenecekVeri.Location = new System.Drawing.Point(88, 91);
            this.btnArayaEklenecekVeri.Name = "btnArayaEklenecekVeri";
            this.btnArayaEklenecekVeri.Size = new System.Drawing.Size(70, 29);
            this.btnArayaEklenecekVeri.TabIndex = 3;
            this.btnArayaEklenecekVeri.Text = "Ekle";
            this.btnArayaEklenecekVeri.UseVisualStyleBackColor = true;
            this.btnArayaEklenecekVeri.Click += new System.EventHandler(this.btnArayaEklenecekVeri_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "İndis No:";
            // 
            // textIndis
            // 
            this.textIndis.Location = new System.Drawing.Point(88, 61);
            this.textIndis.Name = "textIndis";
            this.textIndis.Size = new System.Drawing.Size(70, 24);
            this.textIndis.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSirala);
            this.groupBox4.Location = new System.Drawing.Point(231, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 110);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Veri Sıralama";
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(6, 52);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(188, 29);
            this.btnSirala.TabIndex = 7;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 442);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnListeyiTemizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxVeriler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "ArrayList Kullanımı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxVeriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtSilinecekVeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListeyiTemizle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArayaEklenecekVeri;
        private System.Windows.Forms.Button btnArayaEklenecekVeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIndis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSirala;
    }
}

