namespace Hali_Yıkama_Takibi
{
    partial class Siparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparisler));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtSiparisListesi = new System.Windows.Forms.DataGridView();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnDurumDegistir = new System.Windows.Forms.Button();
            this.cmbSiparisDurum = new System.Windows.Forms.ComboBox();
            this.btnDagitimaGonder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDurumFiltre = new System.Windows.Forms.ComboBox();
            this.txtSiparisVeren = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiparisNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtSiparisListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.Green;
            this.btnSil.Location = new System.Drawing.Point(477, 81);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(165, 23);
            this.btnSil.TabIndex = 22;
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
            this.btnGuncelle.Location = new System.Drawing.Point(477, 52);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(165, 23);
            this.btnGuncelle.TabIndex = 21;
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
            this.btnEkle.Location = new System.Drawing.Point(478, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(165, 23);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // dtSiparisListesi
            // 
            this.dtSiparisListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtSiparisListesi.BackgroundColor = System.Drawing.Color.White;
            this.dtSiparisListesi.Location = new System.Drawing.Point(12, 14);
            this.dtSiparisListesi.Name = "dtSiparisListesi";
            this.dtSiparisListesi.ReadOnly = true;
            this.dtSiparisListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtSiparisListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtSiparisListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSiparisListesi.Size = new System.Drawing.Size(450, 206);
            this.dtSiparisListesi.TabIndex = 19;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Green;
            this.btnAnasayfa.Location = new System.Drawing.Point(477, 110);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(165, 23);
            this.btnAnasayfa.TabIndex = 23;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseEnter += new System.EventHandler(this.btnAnasayfa_MouseEnter);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseHover += new System.EventHandler(this.btnAnasayfa_MouseHover);
            // 
            // btnDurumDegistir
            // 
            this.btnDurumDegistir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDurumDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumDegistir.ForeColor = System.Drawing.Color.Green;
            this.btnDurumDegistir.Location = new System.Drawing.Point(477, 171);
            this.btnDurumDegistir.Name = "btnDurumDegistir";
            this.btnDurumDegistir.Size = new System.Drawing.Size(165, 23);
            this.btnDurumDegistir.TabIndex = 24;
            this.btnDurumDegistir.Text = "Durum Değiştir";
            this.btnDurumDegistir.UseVisualStyleBackColor = true;
            this.btnDurumDegistir.Click += new System.EventHandler(this.btnDurumDegistir_Click);
            this.btnDurumDegistir.MouseLeave += new System.EventHandler(this.btnDurumDegistir_MouseLeave);
            this.btnDurumDegistir.MouseHover += new System.EventHandler(this.btnDurumDegistir_MouseHover);
            // 
            // cmbSiparisDurum
            // 
            this.cmbSiparisDurum.FormattingEnabled = true;
            this.cmbSiparisDurum.Items.AddRange(new object[] {
            "Yıkanacak",
            "Kurutulacak",
            "Paketlenecek",
            "Paketlendi"});
            this.cmbSiparisDurum.Location = new System.Drawing.Point(477, 201);
            this.cmbSiparisDurum.Name = "cmbSiparisDurum";
            this.cmbSiparisDurum.Size = new System.Drawing.Size(166, 21);
            this.cmbSiparisDurum.TabIndex = 25;
            // 
            // btnDagitimaGonder
            // 
            this.btnDagitimaGonder.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDagitimaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDagitimaGonder.ForeColor = System.Drawing.Color.Green;
            this.btnDagitimaGonder.Location = new System.Drawing.Point(478, 139);
            this.btnDagitimaGonder.Name = "btnDagitimaGonder";
            this.btnDagitimaGonder.Size = new System.Drawing.Size(165, 23);
            this.btnDagitimaGonder.TabIndex = 26;
            this.btnDagitimaGonder.Text = "Dağıtıma Gönder";
            this.btnDagitimaGonder.UseVisualStyleBackColor = true;
            this.btnDagitimaGonder.Click += new System.EventHandler(this.btnDagitimaGonder_Click);
            this.btnDagitimaGonder.MouseLeave += new System.EventHandler(this.btnDagitimaGonder_MouseLeave);
            this.btnDagitimaGonder.MouseHover += new System.EventHandler(this.btnDagitimaGonder_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDurumFiltre);
            this.groupBox1.Controls.Add(this.txtSiparisVeren);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSiparisNo);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(17, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 114);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
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
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Sipariş Durum :";
            // 
            // cmbDurumFiltre
            // 
            this.cmbDurumFiltre.FormattingEnabled = true;
            this.cmbDurumFiltre.Items.AddRange(new object[] {
            "Yıkanacak",
            "Kurutulacak",
            "Paketlenecek",
            "Paketlendi"});
            this.cmbDurumFiltre.Location = new System.Drawing.Point(87, 79);
            this.cmbDurumFiltre.Name = "cmbDurumFiltre";
            this.cmbDurumFiltre.Size = new System.Drawing.Size(191, 21);
            this.cmbDurumFiltre.TabIndex = 58;
            // 
            // txtSiparisVeren
            // 
            this.txtSiparisVeren.Location = new System.Drawing.Point(87, 47);
            this.txtSiparisVeren.Name = "txtSiparisVeren";
            this.txtSiparisVeren.Size = new System.Drawing.Size(190, 20);
            this.txtSiparisVeren.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Sipariş Veren :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Sipariş No:";
            // 
            // txtSiparisNo
            // 
            this.txtSiparisNo.Location = new System.Drawing.Point(88, 14);
            this.txtSiparisNo.Name = "txtSiparisNo";
            this.txtSiparisNo.Size = new System.Drawing.Size(190, 20);
            this.txtSiparisNo.TabIndex = 55;
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDagitimaGonder);
            this.Controls.Add(this.cmbSiparisDurum);
            this.Controls.Add(this.btnDurumDegistir);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtSiparisListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Siparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparisler";
            this.Load += new System.EventHandler(this.Siparisler_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Siparisler_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dtSiparisListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.DataGridView dtSiparisListesi;
        public System.Windows.Forms.Button btnAnasayfa;
        public System.Windows.Forms.Button btnDurumDegistir;
        private System.Windows.Forms.ComboBox cmbSiparisDurum;
        public System.Windows.Forms.Button btnDagitimaGonder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDurumFiltre;
        public System.Windows.Forms.TextBox txtSiparisVeren;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSiparisNo;
        public System.Windows.Forms.Button btnFiltre;
    }
}