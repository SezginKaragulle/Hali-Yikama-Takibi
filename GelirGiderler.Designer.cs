namespace Hali_Yıkama_Takibi
{
    partial class GelirGiderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GelirGiderler));
            this.dtGelirGiderListesi = new System.Windows.Forms.DataGridView();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTumu = new System.Windows.Forms.RadioButton();
            this.rdbGider = new System.Windows.Forms.RadioButton();
            this.rdbGelir = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFisTarihiFiltre = new System.Windows.Forms.CheckBox();
            this.dtFisTarihi2 = new System.Windows.Forms.DateTimePicker();
            this.dtFisTarihi1 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamGelir = new System.Windows.Forms.TextBox();
            this.txtToplamGider = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGelirGiderListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGelirGiderListesi
            // 
            this.dtGelirGiderListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGelirGiderListesi.BackgroundColor = System.Drawing.Color.White;
            this.dtGelirGiderListesi.Location = new System.Drawing.Point(12, 12);
            this.dtGelirGiderListesi.Name = "dtGelirGiderListesi";
            this.dtGelirGiderListesi.ReadOnly = true;
            this.dtGelirGiderListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtGelirGiderListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtGelirGiderListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGelirGiderListesi.Size = new System.Drawing.Size(450, 206);
            this.dtGelirGiderListesi.TabIndex = 27;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Green;
            this.btnAnasayfa.Location = new System.Drawing.Point(479, 99);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(165, 23);
            this.btnAnasayfa.TabIndex = 31;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseHover += new System.EventHandler(this.btnAnasayfa_MouseHover);
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Green;
            this.btnSil.Location = new System.Drawing.Point(479, 70);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(165, 23);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Green;
            this.btnGuncelle.Location = new System.Drawing.Point(479, 41);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(165, 23);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            this.btnGuncelle.MouseHover += new System.EventHandler(this.btnGuncelle_MouseHover);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.Green;
            this.btnEkle.Location = new System.Drawing.Point(480, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(165, 23);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseEnter += new System.EventHandler(this.btnEkle_MouseEnter);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTumu);
            this.groupBox1.Controls.Add(this.rdbGider);
            this.groupBox1.Controls.Add(this.rdbGelir);
            this.groupBox1.Location = new System.Drawing.Point(479, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 89);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // rdbTumu
            // 
            this.rdbTumu.AutoSize = true;
            this.rdbTumu.ForeColor = System.Drawing.Color.Green;
            this.rdbTumu.Location = new System.Drawing.Point(7, 66);
            this.rdbTumu.Name = "rdbTumu";
            this.rdbTumu.Size = new System.Drawing.Size(52, 17);
            this.rdbTumu.TabIndex = 2;
            this.rdbTumu.TabStop = true;
            this.rdbTumu.Text = "Tümü";
            this.rdbTumu.UseVisualStyleBackColor = true;
            this.rdbTumu.CheckedChanged += new System.EventHandler(this.rdbTumu_CheckedChanged);
            // 
            // rdbGider
            // 
            this.rdbGider.AutoSize = true;
            this.rdbGider.ForeColor = System.Drawing.Color.Green;
            this.rdbGider.Location = new System.Drawing.Point(7, 43);
            this.rdbGider.Name = "rdbGider";
            this.rdbGider.Size = new System.Drawing.Size(50, 17);
            this.rdbGider.TabIndex = 1;
            this.rdbGider.TabStop = true;
            this.rdbGider.Text = "Gider";
            this.rdbGider.UseVisualStyleBackColor = true;
            this.rdbGider.CheckedChanged += new System.EventHandler(this.rdbGider_CheckedChanged);
            this.rdbGider.Click += new System.EventHandler(this.rdbGider_Click);
            // 
            // rdbGelir
            // 
            this.rdbGelir.AutoSize = true;
            this.rdbGelir.ForeColor = System.Drawing.Color.Green;
            this.rdbGelir.Location = new System.Drawing.Point(7, 20);
            this.rdbGelir.Name = "rdbGelir";
            this.rdbGelir.Size = new System.Drawing.Size(46, 17);
            this.rdbGelir.TabIndex = 0;
            this.rdbGelir.TabStop = true;
            this.rdbGelir.Text = "Gelir";
            this.rdbGelir.UseVisualStyleBackColor = true;
            this.rdbGelir.CheckedChanged += new System.EventHandler(this.rdbGelir_CheckedChanged);
            this.rdbGelir.Click += new System.EventHandler(this.rdbGelir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFisTarihiFiltre);
            this.groupBox2.Controls.Add(this.dtFisTarihi2);
            this.groupBox2.Controls.Add(this.dtFisTarihi1);
            this.groupBox2.Controls.Add(this.btnFiltre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFisNo);
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 114);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // chkFisTarihiFiltre
            // 
            this.chkFisTarihiFiltre.AutoSize = true;
            this.chkFisTarihiFiltre.Location = new System.Drawing.Point(296, 44);
            this.chkFisTarihiFiltre.Name = "chkFisTarihiFiltre";
            this.chkFisTarihiFiltre.Size = new System.Drawing.Size(106, 17);
            this.chkFisTarihiFiltre.TabIndex = 62;
            this.chkFisTarihiFiltre.Text = "Fiş Tarihiyle Filtre";
            this.chkFisTarihiFiltre.UseVisualStyleBackColor = true;
            // 
            // dtFisTarihi2
            // 
            this.dtFisTarihi2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFisTarihi2.Location = new System.Drawing.Point(88, 80);
            this.dtFisTarihi2.Name = "dtFisTarihi2";
            this.dtFisTarihi2.Size = new System.Drawing.Size(190, 20);
            this.dtFisTarihi2.TabIndex = 61;
            // 
            // dtFisTarihi1
            // 
            this.dtFisTarihi1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFisTarihi1.Location = new System.Drawing.Point(88, 44);
            this.dtFisTarihi1.Name = "dtFisTarihi1";
            this.dtFisTarihi1.Size = new System.Drawing.Size(190, 20);
            this.dtFisTarihi1.TabIndex = 60;
            this.dtFisTarihi1.ValueChanged += new System.EventHandler(this.dtFisTarihi1_ValueChanged);
            // 
            // btnFiltre
            // 
            this.btnFiltre.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltre.ForeColor = System.Drawing.Color.Green;
            this.btnFiltre.Location = new System.Drawing.Point(296, 77);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(129, 23);
            this.btnFiltre.TabIndex = 28;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.UseVisualStyleBackColor = true;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            this.btnFiltre.MouseLeave += new System.EventHandler(this.btnFiltre_MouseLeave);
            this.btnFiltre.MouseHover += new System.EventHandler(this.btnFiltre_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Fiş Tarihi2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Fiş Tarihi1 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Fiş No :";
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(88, 14);
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(190, 20);
            this.txtFisNo.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(479, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "TOPLAM GELİR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(477, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "TOPLAM GİDER :";
            // 
            // txtToplamGelir
            // 
            this.txtToplamGelir.Enabled = false;
            this.txtToplamGelir.Location = new System.Drawing.Point(577, 237);
            this.txtToplamGelir.Name = "txtToplamGelir";
            this.txtToplamGelir.Size = new System.Drawing.Size(138, 20);
            this.txtToplamGelir.TabIndex = 56;
            // 
            // txtToplamGider
            // 
            this.txtToplamGider.Enabled = false;
            this.txtToplamGider.Location = new System.Drawing.Point(577, 261);
            this.txtToplamGider.Name = "txtToplamGider";
            this.txtToplamGider.Size = new System.Drawing.Size(138, 20);
            this.txtToplamGider.TabIndex = 57;
            // 
            // GelirGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 348);
            this.Controls.Add(this.txtToplamGider);
            this.Controls.Add(this.txtToplamGelir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtGelirGiderListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "GelirGiderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Giderler";
            this.Load += new System.EventHandler(this.GelirGiderler_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GelirGiderler_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dtGelirGiderListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dtGelirGiderListesi;
        public System.Windows.Forms.Button btnAnasayfa;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rdbTumu;
        public System.Windows.Forms.RadioButton rdbGider;
        public System.Windows.Forms.RadioButton rdbGelir;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.DateTimePicker dtFisTarihi2;
        private System.Windows.Forms.DateTimePicker dtFisTarihi1;
        private System.Windows.Forms.CheckBox chkFisTarihiFiltre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtToplamGelir;
        public System.Windows.Forms.TextBox txtToplamGider;
    }
}