namespace Siniflar_3_get_set
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNesneOlustur = new System.Windows.Forms.Button();
            this.btnHayvanNesnesiOlstur = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblYasamAlani = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtOkulNo = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.btnOgrenciOlustur = new System.Windows.Forms.Button();
            this.btnStringConcat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNesneOlustur
            // 
            this.btnNesneOlustur.Location = new System.Drawing.Point(17, 16);
            this.btnNesneOlustur.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNesneOlustur.Name = "btnNesneOlustur";
            this.btnNesneOlustur.Size = new System.Drawing.Size(370, 98);
            this.btnNesneOlustur.TabIndex = 0;
            this.btnNesneOlustur.Text = "Araba nesnesi oluştur";
            this.btnNesneOlustur.UseVisualStyleBackColor = true;
            this.btnNesneOlustur.Click += new System.EventHandler(this.btnNesneOlustur_Click);
            // 
            // btnHayvanNesnesiOlstur
            // 
            this.btnHayvanNesnesiOlstur.Location = new System.Drawing.Point(17, 128);
            this.btnHayvanNesnesiOlstur.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnHayvanNesnesiOlstur.Name = "btnHayvanNesnesiOlstur";
            this.btnHayvanNesnesiOlstur.Size = new System.Drawing.Size(370, 98);
            this.btnHayvanNesnesiOlstur.TabIndex = 1;
            this.btnHayvanNesnesiOlstur.Text = "Hayvan nesnesi oluştur";
            this.btnHayvanNesnesiOlstur.UseVisualStyleBackColor = true;
            this.btnHayvanNesnesiOlstur.Click += new System.EventHandler(this.btnHayvanNesnesiOlstur_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(465, 28);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(73, 31);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Adı :";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(465, 74);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(71, 31);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Yaşı";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Location = new System.Drawing.Point(465, 174);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(63, 31);
            this.lblKilo.TabIndex = 5;
            this.lblKilo.Text = "Kilo";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(465, 128);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(64, 31);
            this.lblBoy.TabIndex = 4;
            this.lblBoy.Text = "Boy";
            // 
            // lblYasamAlani
            // 
            this.lblYasamAlani.AutoSize = true;
            this.lblYasamAlani.Location = new System.Drawing.Point(465, 225);
            this.lblYasamAlani.Name = "lblYasamAlani";
            this.lblYasamAlani.Size = new System.Drawing.Size(173, 31);
            this.lblYasamAlani.TabIndex = 6;
            this.lblYasamAlani.Text = "Yaşam alanı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(858, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Okul No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(850, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefon";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(938, 25);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(232, 38);
            this.txtAd.TabIndex = 12;
            // 
            // txtOkulNo
            // 
            this.txtOkulNo.Location = new System.Drawing.Point(938, 69);
            this.txtOkulNo.Name = "txtOkulNo";
            this.txtOkulNo.Size = new System.Drawing.Size(232, 38);
            this.txtOkulNo.TabIndex = 13;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(938, 165);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(232, 38);
            this.txtTelefon.TabIndex = 15;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(938, 121);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(232, 38);
            this.txtYas.TabIndex = 14;
            // 
            // btnOgrenciOlustur
            // 
            this.btnOgrenciOlustur.Location = new System.Drawing.Point(938, 225);
            this.btnOgrenciOlustur.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnOgrenciOlustur.Name = "btnOgrenciOlustur";
            this.btnOgrenciOlustur.Size = new System.Drawing.Size(232, 77);
            this.btnOgrenciOlustur.TabIndex = 17;
            this.btnOgrenciOlustur.Text = "Öğrenci Oluştur";
            this.btnOgrenciOlustur.UseVisualStyleBackColor = true;
            this.btnOgrenciOlustur.Click += new System.EventHandler(this.btnOgrenciOlustur_Click);
            // 
            // btnStringConcat
            // 
            this.btnStringConcat.Location = new System.Drawing.Point(303, 297);
            this.btnStringConcat.Name = "btnStringConcat";
            this.btnStringConcat.Size = new System.Drawing.Size(185, 87);
            this.btnStringConcat.TabIndex = 18;
            this.btnStringConcat.Text = "String Concat";
            this.btnStringConcat.UseVisualStyleBackColor = true;
            this.btnStringConcat.Click += new System.EventHandler(this.btnStringConcat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 418);
            this.Controls.Add(this.btnStringConcat);
            this.Controls.Add(this.btnOgrenciOlustur);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtOkulNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblYasamAlani);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnHayvanNesnesiOlstur);
            this.Controls.Add(this.btnNesneOlustur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNesneOlustur;
        private System.Windows.Forms.Button btnHayvanNesnesiOlstur;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblYasamAlani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtOkulNo;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Button btnOgrenciOlustur;
        private System.Windows.Forms.Button btnStringConcat;
    }
}

