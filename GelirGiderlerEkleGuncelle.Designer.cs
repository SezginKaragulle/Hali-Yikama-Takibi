namespace Hali_Yıkama_Takibi
{
    partial class GelirGiderlerEkleGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirGiderlerEkleGuncelle));
            this.txtFisTutari = new System.Windows.Forms.TextBox();
            this.txtFisAciklamasi = new System.Windows.Forms.TextBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBorc = new System.Windows.Forms.RadioButton();
            this.rdbAlacak = new System.Windows.Forms.RadioButton();
            this.dtFisTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFisTutari
            // 
            this.txtFisTutari.Location = new System.Drawing.Point(102, 71);
            this.txtFisTutari.Name = "txtFisTutari";
            this.txtFisTutari.Size = new System.Drawing.Size(190, 20);
            this.txtFisTutari.TabIndex = 28;
            this.txtFisTutari.TextChanged += new System.EventHandler(this.txtFisTutari_TextChanged);
            // 
            // txtFisAciklamasi
            // 
            this.txtFisAciklamasi.Location = new System.Drawing.Point(102, 45);
            this.txtFisAciklamasi.Name = "txtFisAciklamasi";
            this.txtFisAciklamasi.Size = new System.Drawing.Size(190, 20);
            this.txtFisAciklamasi.TabIndex = 27;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.ForeColor = System.Drawing.Color.Green;
            this.btnGeriDon.Location = new System.Drawing.Point(185, 149);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(110, 23);
            this.btnGeriDon.TabIndex = 25;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            this.btnGeriDon.MouseLeave += new System.EventHandler(this.btnGeriDon_MouseLeave);
            this.btnGeriDon.MouseHover += new System.EventHandler(this.btnGeriDon_MouseHover);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.Green;
            this.btnEkle.Location = new System.Drawing.Point(24, 149);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 23);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(39, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fiş Tutarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fiş Açıklaması :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fiş Tarihi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBorc);
            this.groupBox1.Controls.Add(this.rdbAlacak);
            this.groupBox1.Location = new System.Drawing.Point(42, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 46);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // rdbBorc
            // 
            this.rdbBorc.AutoSize = true;
            this.rdbBorc.ForeColor = System.Drawing.Color.Green;
            this.rdbBorc.Location = new System.Drawing.Point(159, 20);
            this.rdbBorc.Name = "rdbBorc";
            this.rdbBorc.Size = new System.Drawing.Size(47, 17);
            this.rdbBorc.TabIndex = 1;
            this.rdbBorc.TabStop = true;
            this.rdbBorc.Text = "Borç";
            this.rdbBorc.UseVisualStyleBackColor = true;
            this.rdbBorc.Click += new System.EventHandler(this.rdbBorc_Click);
            // 
            // rdbAlacak
            // 
            this.rdbAlacak.AutoSize = true;
            this.rdbAlacak.ForeColor = System.Drawing.Color.Green;
            this.rdbAlacak.Location = new System.Drawing.Point(7, 20);
            this.rdbAlacak.Name = "rdbAlacak";
            this.rdbAlacak.Size = new System.Drawing.Size(58, 17);
            this.rdbAlacak.TabIndex = 0;
            this.rdbAlacak.TabStop = true;
            this.rdbAlacak.Text = "Alacak";
            this.rdbAlacak.UseVisualStyleBackColor = true;
            this.rdbAlacak.Click += new System.EventHandler(this.rdbAlacak_Click);
            // 
            // dtFisTarihi
            // 
            this.dtFisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFisTarihi.Location = new System.Drawing.Point(102, 16);
            this.dtFisTarihi.Name = "dtFisTarihi";
            this.dtFisTarihi.Size = new System.Drawing.Size(190, 20);
            this.dtFisTarihi.TabIndex = 30;
            // 
            // GelirGiderlerEkleGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 185);
            this.Controls.Add(this.dtFisTarihi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFisTutari);
            this.Controls.Add(this.txtFisAciklamasi);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GelirGiderlerEkleGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Gider";
            this.Load += new System.EventHandler(this.GelirGiderlerEkleGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtFisTutari;
        public System.Windows.Forms.TextBox txtFisAciklamasi;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBorc;
        private System.Windows.Forms.RadioButton rdbAlacak;
        private System.Windows.Forms.DateTimePicker dtFisTarihi;
    }
}