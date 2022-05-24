
namespace Personel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKisiOlustur = new System.Windows.Forms.Button();
            this.btnKisiBilgisiGoster = new System.Windows.Forms.Button();
            this.btnAdDegistir = new System.Windows.Forms.Button();
            this.txtYeniAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKisiOlustur
            // 
            this.btnKisiOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKisiOlustur.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKisiOlustur.ForeColor = System.Drawing.Color.White;
            this.btnKisiOlustur.Location = new System.Drawing.Point(24, 12);
            this.btnKisiOlustur.Name = "btnKisiOlustur";
            this.btnKisiOlustur.Size = new System.Drawing.Size(211, 87);
            this.btnKisiOlustur.TabIndex = 0;
            this.btnKisiOlustur.Text = "Kişi Oluştur";
            this.btnKisiOlustur.UseVisualStyleBackColor = false;
            this.btnKisiOlustur.Click += new System.EventHandler(this.btnKisiOlustur_Click);
            // 
            // btnKisiBilgisiGoster
            // 
            this.btnKisiBilgisiGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKisiBilgisiGoster.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKisiBilgisiGoster.Location = new System.Drawing.Point(241, 12);
            this.btnKisiBilgisiGoster.Name = "btnKisiBilgisiGoster";
            this.btnKisiBilgisiGoster.Size = new System.Drawing.Size(211, 87);
            this.btnKisiBilgisiGoster.TabIndex = 1;
            this.btnKisiBilgisiGoster.Text = "Kişi Bilgisini Göster";
            this.btnKisiBilgisiGoster.UseVisualStyleBackColor = false;
            this.btnKisiBilgisiGoster.Click += new System.EventHandler(this.btnKisiBilgisiGoster_Click);
            // 
            // btnAdDegistir
            // 
            this.btnAdDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdDegistir.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdDegistir.ForeColor = System.Drawing.Color.White;
            this.btnAdDegistir.Location = new System.Drawing.Point(458, 12);
            this.btnAdDegistir.Name = "btnAdDegistir";
            this.btnAdDegistir.Size = new System.Drawing.Size(211, 47);
            this.btnAdDegistir.TabIndex = 2;
            this.btnAdDegistir.Text = "Ad Değiştir";
            this.btnAdDegistir.UseVisualStyleBackColor = false;
            this.btnAdDegistir.Click += new System.EventHandler(this.btnAdDegistir_Click);
            // 
            // txtYeniAd
            // 
            this.txtYeniAd.Location = new System.Drawing.Point(521, 76);
            this.txtYeniAd.Name = "txtYeniAd";
            this.txtYeniAd.Size = new System.Drawing.Size(136, 23);
            this.txtYeniAd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(476, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 120);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYeniAd);
            this.Controls.Add(this.btnAdDegistir);
            this.Controls.Add(this.btnKisiBilgisiGoster);
            this.Controls.Add(this.btnKisiOlustur);
            this.Name = "Form1";
            this.Text = "Sınıf Çalışması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKisiOlustur;
        private System.Windows.Forms.Button btnKisiBilgisiGoster;
        private System.Windows.Forms.Button btnAdDegistir;
        private System.Windows.Forms.TextBox txtYeniAd;
        private System.Windows.Forms.Label label1;
    }
}

