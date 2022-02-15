
namespace SpaceShipGame
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
            this.components = new System.ComponentModel.Container();
            this.btnAddNewButton = new System.Windows.Forms.Button();
            this.btnHAreket = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSpaceShip = new System.Windows.Forms.PictureBox();
            this.pbOrnekMermi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrnekMermi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewButton
            // 
            this.btnAddNewButton.Enabled = false;
            this.btnAddNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewButton.Location = new System.Drawing.Point(666, 88);
            this.btnAddNewButton.Name = "btnAddNewButton";
            this.btnAddNewButton.Size = new System.Drawing.Size(128, 84);
            this.btnAddNewButton.TabIndex = 100;
            this.btnAddNewButton.TabStop = false;
            this.btnAddNewButton.Text = "Yeni düğme ekle";
            this.btnAddNewButton.UseVisualStyleBackColor = true;
            this.btnAddNewButton.Click += new System.EventHandler(this.btnAddNewButton_Click);
            // 
            // btnHAreket
            // 
            this.btnHAreket.Enabled = false;
            this.btnHAreket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHAreket.Location = new System.Drawing.Point(703, 218);
            this.btnHAreket.Name = "btnHAreket";
            this.btnHAreket.Size = new System.Drawing.Size(91, 42);
            this.btnHAreket.TabIndex = 500;
            this.btnHAreket.TabStop = false;
            this.btnHAreket.Text = "İlerlet";
            this.btnHAreket.UseVisualStyleBackColor = true;
            this.btnHAreket.Click += new System.EventHandler(this.btnHAreket_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(733, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 4;
            // 
            // pbSpaceShip
            // 
            this.pbSpaceShip.Image = global::SpaceShipGame.Properties.Resources.uzaygemisi;
            this.pbSpaceShip.Location = new System.Drawing.Point(298, 440);
            this.pbSpaceShip.Name = "pbSpaceShip";
            this.pbSpaceShip.Size = new System.Drawing.Size(64, 64);
            this.pbSpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpaceShip.TabIndex = 4;
            this.pbSpaceShip.TabStop = false;
            // 
            // pbOrnekMermi
            // 
            this.pbOrnekMermi.Image = global::SpaceShipGame.Properties.Resources.mermi;
            this.pbOrnekMermi.Location = new System.Drawing.Point(657, 421);
            this.pbOrnekMermi.Name = "pbOrnekMermi";
            this.pbOrnekMermi.Size = new System.Drawing.Size(32, 32);
            this.pbOrnekMermi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrnekMermi.TabIndex = 3;
            this.pbOrnekMermi.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(510, 511);
            this.Controls.Add(this.pbSpaceShip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbOrnekMermi);
            this.Controls.Add(this.btnHAreket);
            this.Controls.Add(this.btnAddNewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SpaceShip Game v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbSpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrnekMermi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewButton;
        private System.Windows.Forms.Button btnHAreket;
        private System.Windows.Forms.PictureBox pbOrnekMermi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSpaceShip;
    }
}

