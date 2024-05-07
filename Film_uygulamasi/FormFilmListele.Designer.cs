namespace Film_uygulamasi
{
    partial class FormFilmListele
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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdb_puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbPoster = new System.Windows.Forms.PictureBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sinema Listesi";
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.filmad,
            this.tur,
            this.yil,
            this.imdb_puan,
            this.ozet});
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListe.Enabled = false;
            this.dgvListe.Location = new System.Drawing.Point(3, 16);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(840, 114);
            this.dgvListe.TabIndex = 0;
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // filmad
            // 
            this.filmad.DataPropertyName = "filmad";
            this.filmad.HeaderText = "Film Ad";
            this.filmad.Name = "filmad";
            this.filmad.ReadOnly = true;
            // 
            // tur
            // 
            this.tur.DataPropertyName = "tur";
            this.tur.HeaderText = "Tür";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            // 
            // yil
            // 
            this.yil.DataPropertyName = "yil";
            this.yil.HeaderText = "Yıl";
            this.yil.Name = "yil";
            this.yil.ReadOnly = true;
            this.yil.Visible = false;
            // 
            // imdb_puan
            // 
            this.imdb_puan.DataPropertyName = "imdb_puan";
            this.imdb_puan.HeaderText = "IMDB Puan";
            this.imdb_puan.Name = "imdb_puan";
            this.imdb_puan.ReadOnly = true;
            // 
            // ozet
            // 
            this.ozet.DataPropertyName = "ozet";
            this.ozet.HeaderText = "Özet";
            this.ozet.Name = "ozet";
            this.ozet.ReadOnly = true;
            this.ozet.Visible = false;
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(115, 299);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(222, 232);
            this.pbPoster.TabIndex = 51;
            this.pbPoster.TabStop = false;
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
            this.cmbTur.Location = new System.Drawing.Point(115, 192);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(222, 21);
            this.cmbTur.TabIndex = 48;
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(377, 167);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(426, 347);
            this.txtOzet.TabIndex = 47;
            // 
            // txtPuan
            // 
            this.txtPuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPuan.Location = new System.Drawing.Point(115, 261);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(222, 20);
            this.txtPuan.TabIndex = 46;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(115, 222);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(222, 20);
            this.txtYil.TabIndex = 45;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(115, 157);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(222, 20);
            this.txtFilmAd.TabIndex = 44;
            // 
            // lblOzet
            // 
            this.lblOzet.AutoSize = true;
            this.lblOzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzet.Location = new System.Drawing.Point(15, 299);
            this.lblOzet.Name = "lblOzet";
            this.lblOzet.Size = new System.Drawing.Size(71, 16);
            this.lblOzet.TabIndex = 43;
            this.lblOzet.Text = "Film Özet";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTur.Location = new System.Drawing.Point(15, 193);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(30, 16);
            this.lblTur.TabIndex = 42;
            this.lblTur.Text = "Tür";
            // 
            // lblImdbPuan
            // 
            this.lblImdbPuan.AutoSize = true;
            this.lblImdbPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImdbPuan.Location = new System.Drawing.Point(15, 261);
            this.lblImdbPuan.Name = "lblImdbPuan";
            this.lblImdbPuan.Size = new System.Drawing.Size(83, 16);
            this.lblImdbPuan.TabIndex = 41;
            this.lblImdbPuan.Text = "lMDB Puan";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYil.Location = new System.Drawing.Point(15, 226);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(25, 16);
            this.lblYil.TabIndex = 40;
            this.lblYil.Text = "Yıl";
            // 
            // lblFilmAd
            // 
            this.lblFilmAd.AutoSize = true;
            this.lblFilmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAd.Location = new System.Drawing.Point(15, 157);
            this.lblFilmAd.Name = "lblFilmAd";
            this.lblFilmAd.Size = new System.Drawing.Size(59, 16);
            this.lblFilmAd.TabIndex = 39;
            this.lblFilmAd.Text = "Film Ad";
            // 
            // FormFilmListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(863, 562);
            this.Controls.Add(this.pbPoster);
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
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFilmListele";
            this.Text = "FormFilmListele";
            this.Load += new System.EventHandler(this.FormFilmListele_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdb_puan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozet;
        private System.Windows.Forms.PictureBox pbPoster;
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