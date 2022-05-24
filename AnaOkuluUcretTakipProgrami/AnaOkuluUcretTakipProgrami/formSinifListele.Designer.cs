
namespace AnaOkuluUcretTakipProgrami
{
    partial class formSinifListele
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
            this.dgSiniflar = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSinifAd = new System.Windows.Forms.TextBox();
            this.btnSinifGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiniflar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgSiniflar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 134);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlı Sınıflar";
            // 
            // dgSiniflar
            // 
            this.dgSiniflar.AllowUserToAddRows = false;
            this.dgSiniflar.AllowUserToDeleteRows = false;
            this.dgSiniflar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSiniflar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiniflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSiniflar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSiniflar.Location = new System.Drawing.Point(3, 16);
            this.dgSiniflar.MultiSelect = false;
            this.dgSiniflar.Name = "dgSiniflar";
            this.dgSiniflar.ReadOnly = true;
            this.dgSiniflar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSiniflar.Size = new System.Drawing.Size(190, 115);
            this.dgSiniflar.TabIndex = 0;
            this.dgSiniflar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSiniflar_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSinifAd);
            this.groupBox3.Controls.Add(this.btnSinifGuncelle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(214, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 134);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınıf Bilgileri";
            // 
            // txtSinifAd
            // 
            this.txtSinifAd.Location = new System.Drawing.Point(74, 44);
            this.txtSinifAd.Name = "txtSinifAd";
            this.txtSinifAd.Size = new System.Drawing.Size(100, 20);
            this.txtSinifAd.TabIndex = 1;
            // 
            // btnSinifGuncelle
            // 
            this.btnSinifGuncelle.Location = new System.Drawing.Point(74, 79);
            this.btnSinifGuncelle.Name = "btnSinifGuncelle";
            this.btnSinifGuncelle.Size = new System.Drawing.Size(100, 27);
            this.btnSinifGuncelle.TabIndex = 6;
            this.btnSinifGuncelle.Text = "Sınıfı Güncelle";
            this.btnSinifGuncelle.UseVisualStyleBackColor = true;
            this.btnSinifGuncelle.Click += new System.EventHandler(this.btnSinifGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adı :";
            // 
            // formSinifListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 167);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formSinifListele";
            this.Text = "SINIF LİSTELEME / GÜNCELLEME FORMU";
            this.Load += new System.EventHandler(this.formSinifListele_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSiniflar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgSiniflar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSinifAd;
        private System.Windows.Forms.Button btnSinifGuncelle;
        private System.Windows.Forms.Label label4;
    }
}