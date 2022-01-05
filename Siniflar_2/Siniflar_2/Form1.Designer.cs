
namespace Siniflar_2
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
            this.btnArabaOlustur = new System.Windows.Forms.Button();
            this.rctMetin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnArabaOlustur
            // 
            this.btnArabaOlustur.Location = new System.Drawing.Point(14, 14);
            this.btnArabaOlustur.Margin = new System.Windows.Forms.Padding(5);
            this.btnArabaOlustur.Name = "btnArabaOlustur";
            this.btnArabaOlustur.Size = new System.Drawing.Size(158, 51);
            this.btnArabaOlustur.TabIndex = 0;
            this.btnArabaOlustur.Text = "Araba Oluştur";
            this.btnArabaOlustur.UseVisualStyleBackColor = true;
            this.btnArabaOlustur.Click += new System.EventHandler(this.btnArabaOlustur_Click);
            // 
            // rctMetin
            // 
            this.rctMetin.Location = new System.Drawing.Point(197, 14);
            this.rctMetin.Name = "rctMetin";
            this.rctMetin.Size = new System.Drawing.Size(189, 183);
            this.rctMetin.TabIndex = 1;
            this.rctMetin.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 246);
            this.Controls.Add(this.rctMetin);
            this.Controls.Add(this.btnArabaOlustur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Sınıf İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArabaOlustur;
        private System.Windows.Forms.RichTextBox rctMetin;
    }
}

