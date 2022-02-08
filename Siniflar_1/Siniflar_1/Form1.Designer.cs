
namespace Siniflar_1
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
            this.btnSonradanEklenenDugme = new System.Windows.Forms.Button();
            this.btnDikdortgenAlanHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSonradanEklenenDugme
            // 
            this.btnSonradanEklenenDugme.Location = new System.Drawing.Point(239, 29);
            this.btnSonradanEklenenDugme.Name = "btnSonradanEklenenDugme";
            this.btnSonradanEklenenDugme.Size = new System.Drawing.Size(136, 88);
            this.btnSonradanEklenenDugme.TabIndex = 1;
            this.btnSonradanEklenenDugme.Text = "Sonradan Eklendi";
            this.btnSonradanEklenenDugme.UseVisualStyleBackColor = true;
            // 
            // btnDikdortgenAlanHesapla
            // 
            this.btnDikdortgenAlanHesapla.Location = new System.Drawing.Point(16, 29);
            this.btnDikdortgenAlanHesapla.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDikdortgenAlanHesapla.Name = "btnDikdortgenAlanHesapla";
            this.btnDikdortgenAlanHesapla.Size = new System.Drawing.Size(163, 88);
            this.btnDikdortgenAlanHesapla.TabIndex = 0;
            this.btnDikdortgenAlanHesapla.Text = "Dikdörtgen Alan Hesapla";
            this.btnDikdortgenAlanHesapla.UseVisualStyleBackColor = true;
            this.btnDikdortgenAlanHesapla.Click += new System.EventHandler(this.btnDikdortgenAlanHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 309);
            this.Controls.Add(this.btnSonradanEklenenDugme);
            this.Controls.Add(this.btnDikdortgenAlanHesapla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Sınıf-Nesne Kullanımı";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSonradanEklenenDugme;
        private System.Windows.Forms.Button btnDikdortgenAlanHesapla;
    }
}

