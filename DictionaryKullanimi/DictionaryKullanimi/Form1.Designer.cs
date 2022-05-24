
namespace DictionaryKullanimi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.lstKelimeler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnDosyayaYaz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rctMetin = new System.Windows.Forms.RichTextBox();
            this.rctOkunanMetin = new System.Windows.Forms.RichTextBox();
            this.btnDosyadanOku = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(152, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe";
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(18, 64);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.Size = new System.Drawing.Size(100, 26);
            this.txtIngilizce.TabIndex = 2;
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(156, 64);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(100, 26);
            this.txtTurkce.TabIndex = 3;
            // 
            // lstKelimeler
            // 
            this.lstKelimeler.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstKelimeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstKelimeler.FullRowSelect = true;
            this.lstKelimeler.GridLines = true;
            this.lstKelimeler.HideSelection = false;
            this.lstKelimeler.HoverSelection = true;
            this.lstKelimeler.Location = new System.Drawing.Point(18, 178);
            this.lstKelimeler.Name = "lstKelimeler";
            this.lstKelimeler.Size = new System.Drawing.Size(238, 200);
            this.lstKelimeler.TabIndex = 99;
            this.lstKelimeler.UseCompatibleStateImageBehavior = false;
            this.lstKelimeler.View = System.Windows.Forms.View.Details;
            this.lstKelimeler.Click += new System.EventHandler(this.lstKelimeler_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İngilizcesi";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Türkçesi";
            this.columnHeader2.Width = 117;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(18, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(71, 31);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(175, 108);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(81, 31);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(89, 108);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(82, 31);
            this.btnDegistir.TabIndex = 5;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnDosyayaYaz
            // 
            this.btnDosyayaYaz.Location = new System.Drawing.Point(313, 190);
            this.btnDosyayaYaz.Name = "btnDosyayaYaz";
            this.btnDosyayaYaz.Size = new System.Drawing.Size(135, 31);
            this.btnDosyayaYaz.TabIndex = 102;
            this.btnDosyayaYaz.Text = "Dosyaya Yaz";
            this.btnDosyayaYaz.UseVisualStyleBackColor = true;
            this.btnDosyayaYaz.Click += new System.EventHandler(this.btnDosyayaYaz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(309, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Dosyaya yazılacak metin";
            // 
            // rctMetin
            // 
            this.rctMetin.Location = new System.Drawing.Point(313, 88);
            this.rctMetin.Name = "rctMetin";
            this.rctMetin.Size = new System.Drawing.Size(200, 96);
            this.rctMetin.TabIndex = 103;
            this.rctMetin.Text = "Ali veli 4950";
            // 
            // rctOkunanMetin
            // 
            this.rctOkunanMetin.Location = new System.Drawing.Point(313, 249);
            this.rctOkunanMetin.Name = "rctOkunanMetin";
            this.rctOkunanMetin.Size = new System.Drawing.Size(200, 96);
            this.rctOkunanMetin.TabIndex = 106;
            this.rctOkunanMetin.Text = "";
            // 
            // btnDosyadanOku
            // 
            this.btnDosyadanOku.Location = new System.Drawing.Point(313, 351);
            this.btnDosyadanOku.Name = "btnDosyadanOku";
            this.btnDosyadanOku.Size = new System.Drawing.Size(135, 31);
            this.btnDosyadanOku.TabIndex = 105;
            this.btnDosyadanOku.Text = "Dosyadan Oku";
            this.btnDosyadanOku.UseVisualStyleBackColor = true;
            this.btnDosyadanOku.Click += new System.EventHandler(this.btnDosyadanOku_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(309, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 104;
            this.label4.Text = "Dosyadan okunan metin";
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(413, 23);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(100, 26);
            this.txtDosyaAdi.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(309, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 107;
            this.label5.Text = "Dosya Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 390);
            this.Controls.Add(this.txtDosyaAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rctOkunanMetin);
            this.Controls.Add(this.btnDosyadanOku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rctMetin);
            this.Controls.Add(this.btnDosyayaYaz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstKelimeler);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözlük v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.ListView lstKelimeler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnDosyayaYaz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rctMetin;
        private System.Windows.Forms.RichTextBox rctOkunanMetin;
        private System.Windows.Forms.Button btnDosyadanOku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.Label label5;
    }
}

