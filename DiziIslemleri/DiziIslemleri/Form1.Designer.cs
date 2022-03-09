
namespace DiziIslemleri
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxOgrenciler = new System.Windows.Forms.ListBox();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.btnDiziElemanSayisi = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(138, 174);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(167, 35);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Numara";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(137, 42);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(5);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(164, 26);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(138, 109);
            this.txtNumara.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(164, 26);
            this.txtNumara.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(352, 235);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekleme Formu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxOgrenciler);
            this.groupBox2.Location = new System.Drawing.Point(20, 335);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(352, 214);
            this.groupBox2.TabIndex = 600;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlı Öğrenciler";
            // 
            // lbxOgrenciler
            // 
            this.lbxOgrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxOgrenciler.FormattingEnabled = true;
            this.lbxOgrenciler.ItemHeight = 20;
            this.lbxOgrenciler.Location = new System.Drawing.Point(5, 24);
            this.lbxOgrenciler.Margin = new System.Windows.Forms.Padding(5);
            this.lbxOgrenciler.Name = "lbxOgrenciler";
            this.lbxOgrenciler.Size = new System.Drawing.Size(342, 185);
            this.lbxOgrenciler.TabIndex = 500;
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Location = new System.Drawing.Point(20, 263);
            this.btnOgrenciListele.Margin = new System.Windows.Forms.Padding(5);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(173, 55);
            this.btnOgrenciListele.TabIndex = 4;
            this.btnOgrenciListele.Text = "Öğrencileri Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // btnDiziElemanSayisi
            // 
            this.btnDiziElemanSayisi.Location = new System.Drawing.Point(199, 263);
            this.btnDiziElemanSayisi.Margin = new System.Windows.Forms.Padding(5);
            this.btnDiziElemanSayisi.Name = "btnDiziElemanSayisi";
            this.btnDiziElemanSayisi.Size = new System.Drawing.Size(100, 55);
            this.btnDiziElemanSayisi.TabIndex = 5;
            this.btnDiziElemanSayisi.Text = "Kaç Eleman?";
            this.btnDiziElemanSayisi.UseVisualStyleBackColor = true;
            this.btnDiziElemanSayisi.Click += new System.EventHandler(this.btnDiziElemanSayisi_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(380, 34);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(95, 50);
            this.btnLength.TabIndex = 601;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(481, 34);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(68, 50);
            this.btnMin.TabIndex = 602;
            this.btnMin.Text = "Min()";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(555, 34);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(68, 50);
            this.btnMax.TabIndex = 603;
            this.btnMax.Text = "Max()";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(380, 102);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(95, 50);
            this.btnAverage.TabIndex = 604;
            this.btnAverage.Text = "Average()";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(481, 102);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(68, 50);
            this.btnSum.TabIndex = 605;
            this.btnSum.Text = "Sum()";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(555, 103);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(68, 50);
            this.btnFirst.TabIndex = 606;
            this.btnFirst.Text = "First()";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(555, 168);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(68, 50);
            this.btnLast.TabIndex = 607;
            this.btnLast.Text = "Last()";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 562);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.btnDiziElemanSayisi);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dizi İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxOgrenciler;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Button btnDiziElemanSayisi;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
    }
}

