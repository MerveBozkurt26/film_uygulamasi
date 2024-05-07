namespace Film_uygulamasi
{
    partial class FormFilmEkle
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
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.lblOzet = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblImdbPuan = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblFilmAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(369, 94);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(245, 232);
            this.pbPoster.TabIndex = 38;
            this.pbPoster.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(369, 341);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(245, 67);
            this.btnKaydet.TabIndex = 37;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(369, 20);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(245, 67);
            this.btnSec.TabIndex = 36;
            this.btnSec.Text = "Resim Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Dram",
            "Komedi ",
            "Fantastik",
            "Romantik",
            "Bilim Kurgu",
            "Korku",
            "Gerilim",
            "Macera",
            "Aksiyon",
            "Animasyon"});
            this.cmbTur.Location = new System.Drawing.Point(111, 55);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(222, 21);
            this.cmbTur.TabIndex = 35;
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(111, 162);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(222, 246);
            this.txtOzet.TabIndex = 34;
            // 
            // txtPuan
            // 
            this.txtPuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPuan.Location = new System.Drawing.Point(111, 124);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(222, 20);
            this.txtPuan.TabIndex = 33;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(111, 85);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(222, 20);
            this.txtYil.TabIndex = 32;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(111, 20);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(222, 20);
            this.txtFilmAd.TabIndex = 31;
            // 
            // lblOzet
            // 
            this.lblOzet.AutoSize = true;
            this.lblOzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzet.Location = new System.Drawing.Point(11, 162);
            this.lblOzet.Name = "lblOzet";
            this.lblOzet.Size = new System.Drawing.Size(71, 16);
            this.lblOzet.TabIndex = 30;
            this.lblOzet.Text = "Film Özet";
           
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.Location = new System.Drawing.Point(11, 56);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(30, 16);
            this.lblTur.TabIndex = 29;
            this.lblTur.Text = "Tür";
            // 
            // lblImdbPuan
            // 
            this.lblImdbPuan.AutoSize = true;
            this.lblImdbPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImdbPuan.Location = new System.Drawing.Point(11, 124);
            this.lblImdbPuan.Name = "lblImdbPuan";
            this.lblImdbPuan.Size = new System.Drawing.Size(83, 16);
            this.lblImdbPuan.TabIndex = 28;
            this.lblImdbPuan.Text = "lMDB Puan";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.Location = new System.Drawing.Point(11, 89);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(25, 16);
            this.lblYil.TabIndex = 27;
            this.lblYil.Text = "Yıl";
            // 
            // lblFilmAd
            // 
            this.lblFilmAd.AutoSize = true;
            this.lblFilmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAd.Location = new System.Drawing.Point(11, 20);
            this.lblFilmAd.Name = "lblFilmAd";
            this.lblFilmAd.Size = new System.Drawing.Size(59, 16);
            this.lblFilmAd.TabIndex = 26;
            this.lblFilmAd.Text = "Film Ad";
            // 
            // FormFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtFilmAd);
            this.Controls.Add(this.lblOzet);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblImdbPuan);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblFilmAd);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormFilmEkle";
            this.Text = "FormFilmEkle";
            this.Load += new System.EventHandler(this.FormFilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label lblOzet;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblImdbPuan;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblFilmAd;
    }
}