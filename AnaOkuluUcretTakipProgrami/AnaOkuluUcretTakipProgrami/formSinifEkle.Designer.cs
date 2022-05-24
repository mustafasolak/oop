
namespace AnaOkuluUcretTakipProgrami
{
    partial class formSinifEkle
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
            this.txtSinifAd = new System.Windows.Forms.TextBox();
            this.btnSinifEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSinifAd);
            this.groupBox1.Controls.Add(this.btnSinifEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf Bilgileri";
            // 
            // txtSinifAd
            // 
            this.txtSinifAd.Location = new System.Drawing.Point(74, 44);
            this.txtSinifAd.Name = "txtSinifAd";
            this.txtSinifAd.Size = new System.Drawing.Size(100, 20);
            this.txtSinifAd.TabIndex = 1;
            // 
            // btnSinifEkle
            // 
            this.btnSinifEkle.Location = new System.Drawing.Point(74, 79);
            this.btnSinifEkle.Name = "btnSinifEkle";
            this.btnSinifEkle.Size = new System.Drawing.Size(100, 27);
            this.btnSinifEkle.TabIndex = 6;
            this.btnSinifEkle.Text = "Sınıfı Kaydet";
            this.btnSinifEkle.UseVisualStyleBackColor = true;
            this.btnSinifEkle.Click += new System.EventHandler(this.btnSinifEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // formSinifEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 170);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formSinifEkle";
            this.Text = "SINIF EKLEME FORMU";
            this.Load += new System.EventHandler(this.formSinifEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSinifAd;
        private System.Windows.Forms.Button btnSinifEkle;
        private System.Windows.Forms.Label label1;
    }
}