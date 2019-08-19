namespace Hali_Yıkama_Takibi
{
    partial class Dagitimlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dagitimlar));
            this.cmbSiparisDurum = new System.Windows.Forms.ComboBox();
            this.btnDurumDegistir = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtDagitimListesi = new System.Windows.Forms.DataGridView();
            this.btnTeslimEdildi = new System.Windows.Forms.Button();
            this.btnTeslimatlar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDurumFiltre = new System.Windows.Forms.ComboBox();
            this.txtSiparisVeren = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSiparisNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDagitimListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSiparisDurum
            // 
            this.cmbSiparisDurum.FormattingEnabled = true;
            this.cmbSiparisDurum.Items.AddRange(new object[] {
            "Dağıtım Planı Yapılacak",
            "Dağıtıma Çıkacak",
            "Dağıtımda"});
            this.cmbSiparisDurum.Location = new System.Drawing.Point(478, 196);
            this.cmbSiparisDurum.Name = "cmbSiparisDurum";
            this.cmbSiparisDurum.Size = new System.Drawing.Size(166, 21);
            this.cmbSiparisDurum.TabIndex = 32;
            // 
            // btnDurumDegistir
            // 
            this.btnDurumDegistir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDurumDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumDegistir.ForeColor = System.Drawing.Color.Green;
            this.btnDurumDegistir.Location = new System.Drawing.Point(478, 166);
            this.btnDurumDegistir.Name = "btnDurumDegistir";
            this.btnDurumDegistir.Size = new System.Drawing.Size(165, 23);
            this.btnDurumDegistir.TabIndex = 31;
            this.btnDurumDegistir.Text = "Durum Değiştir";
            this.btnDurumDegistir.UseVisualStyleBackColor = true;
            this.btnDurumDegistir.Click += new System.EventHandler(this.btnDurumDegistir_Click);
            this.btnDurumDegistir.MouseLeave += new System.EventHandler(this.btnDurumDegistir_MouseLeave);
            this.btnDurumDegistir.MouseHover += new System.EventHandler(this.btnDurumDegistir_MouseHover);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Green;
            this.btnAnasayfa.Location = new System.Drawing.Point(478, 102);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(165, 23);
            this.btnAnasayfa.TabIndex = 30;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseEnter += new System.EventHandler(this.btnAnasayfa_MouseEnter);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseHover += new System.EventHandler(this.btnAnasayfa_MouseHover);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Green;
            this.btnGuncelle.Location = new System.Drawing.Point(478, 73);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(165, 23);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            this.btnGuncelle.MouseHover += new System.EventHandler(this.btnGuncelle_MouseHover);
            // 
            // dtDagitimListesi
            // 
            this.dtDagitimListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtDagitimListesi.BackgroundColor = System.Drawing.Color.White;
            this.dtDagitimListesi.Location = new System.Drawing.Point(13, 14);
            this.dtDagitimListesi.Name = "dtDagitimListesi";
            this.dtDagitimListesi.ReadOnly = true;
            this.dtDagitimListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtDagitimListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtDagitimListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDagitimListesi.Size = new System.Drawing.Size(450, 206);
            this.dtDagitimListesi.TabIndex = 26;
            // 
            // btnTeslimEdildi
            // 
            this.btnTeslimEdildi.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnTeslimEdildi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimEdildi.ForeColor = System.Drawing.Color.Green;
            this.btnTeslimEdildi.Location = new System.Drawing.Point(478, 131);
            this.btnTeslimEdildi.Name = "btnTeslimEdildi";
            this.btnTeslimEdildi.Size = new System.Drawing.Size(165, 23);
            this.btnTeslimEdildi.TabIndex = 33;
            this.btnTeslimEdildi.Text = "Teslim Edildi";
            this.btnTeslimEdildi.UseVisualStyleBackColor = true;
            this.btnTeslimEdildi.Click += new System.EventHandler(this.btnTeslimEdildi_Click);
            this.btnTeslimEdildi.MouseLeave += new System.EventHandler(this.btnTeslimEdildi_MouseLeave);
            this.btnTeslimEdildi.MouseHover += new System.EventHandler(this.btnTeslimEdildi_MouseHover);
            // 
            // btnTeslimatlar
            // 
            this.btnTeslimatlar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnTeslimatlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimatlar.ForeColor = System.Drawing.Color.Green;
            this.btnTeslimatlar.Location = new System.Drawing.Point(480, 14);
            this.btnTeslimatlar.Name = "btnTeslimatlar";
            this.btnTeslimatlar.Size = new System.Drawing.Size(165, 23);
            this.btnTeslimatlar.TabIndex = 34;
            this.btnTeslimatlar.Text = "Teslimatlar";
            this.btnTeslimatlar.UseVisualStyleBackColor = true;
            this.btnTeslimatlar.Click += new System.EventHandler(this.btnTeslimatlar_Click);
            this.btnTeslimatlar.MouseLeave += new System.EventHandler(this.btnTeslimatlar_MouseLeave);
            this.btnTeslimatlar.MouseHover += new System.EventHandler(this.btnTeslimatlar_MouseHover);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 114);
            this.groupBox1.TabIndex = 35;
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
            this.label2.ForeColor = System.Drawing.Color.Green;
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
            "Dağıtım Planı Yapılacak",
            "Dağıtıma Çıkacak",
            "Dağıtımda"});
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
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Sipariş Veren :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
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
            // Dagitimlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTeslimatlar);
            this.Controls.Add(this.btnTeslimEdildi);
            this.Controls.Add(this.cmbSiparisDurum);
            this.Controls.Add(this.btnDurumDegistir);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtDagitimListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Dagitimlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dagitimlar";
            this.Load += new System.EventHandler(this.Dagitimlar_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dagitimlar_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dtDagitimListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnDurumDegistir;
        public System.Windows.Forms.Button btnAnasayfa;
        public System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.DataGridView dtDagitimListesi;
        public System.Windows.Forms.Button btnTeslimEdildi;
        public System.Windows.Forms.Button btnTeslimatlar;
        public System.Windows.Forms.ComboBox cmbSiparisDurum;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDurumFiltre;
        public System.Windows.Forms.TextBox txtSiparisVeren;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSiparisNo;
    }
}