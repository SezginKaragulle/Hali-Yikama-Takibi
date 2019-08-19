namespace Hali_Yıkama_Takibi
{
    partial class SistemYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemYonetimi));
            this.dtKullaniciListesi = new System.Windows.Forms.DataGridView();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKullanimİciDisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtKullaniciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtKullaniciListesi
            // 
            this.dtKullaniciListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtKullaniciListesi.BackgroundColor = System.Drawing.Color.White;
            this.dtKullaniciListesi.Location = new System.Drawing.Point(12, 12);
            this.dtKullaniciListesi.Name = "dtKullaniciListesi";
            this.dtKullaniciListesi.ReadOnly = true;
            this.dtKullaniciListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtKullaniciListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtKullaniciListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtKullaniciListesi.Size = new System.Drawing.Size(450, 206);
            this.dtKullaniciListesi.TabIndex = 27;
            this.dtKullaniciListesi.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtKullaniciListesi_RowHeaderMouseClick);
            this.dtKullaniciListesi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtKullaniciListesi_MouseClick);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.ForeColor = System.Drawing.Color.Green;
            this.btnAnasayfa.Location = new System.Drawing.Point(468, 170);
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
            this.btnSil.Location = new System.Drawing.Point(468, 113);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(165, 23);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSifreDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreDegistir.ForeColor = System.Drawing.Color.Green;
            this.btnSifreDegistir.Location = new System.Drawing.Point(468, 84);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(165, 23);
            this.btnSifreDegistir.TabIndex = 29;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            this.btnSifreDegistir.MouseLeave += new System.EventHandler(this.btnSifreDegistir_MouseLeave);
            this.btnSifreDegistir.MouseHover += new System.EventHandler(this.btnSifreDegistir_MouseHover);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.Green;
            this.btnEkle.Location = new System.Drawing.Point(469, 55);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(165, 23);
            this.btnEkle.TabIndex = 28;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // btnKullanimİciDisi
            // 
            this.btnKullanimİciDisi.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnKullanimİciDisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanimİciDisi.ForeColor = System.Drawing.Color.Green;
            this.btnKullanimİciDisi.Location = new System.Drawing.Point(468, 142);
            this.btnKullanimİciDisi.Name = "btnKullanimİciDisi";
            this.btnKullanimİciDisi.Size = new System.Drawing.Size(165, 23);
            this.btnKullanimİciDisi.TabIndex = 32;
            this.btnKullanimİciDisi.Text = "Kullanım Dışı Yap";
            this.btnKullanimİciDisi.UseVisualStyleBackColor = true;
            this.btnKullanimİciDisi.Click += new System.EventHandler(this.btnKullanimİciDisi_Click);
            this.btnKullanimİciDisi.MouseLeave += new System.EventHandler(this.btnKullanimİciDisi_MouseLeave);
            this.btnKullanimİciDisi.MouseHover += new System.EventHandler(this.btnKullanimİciDisi_MouseHover);
            // 
            // SistemYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 237);
            this.Controls.Add(this.btnKullanimİciDisi);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtKullaniciListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SistemYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Yönetimi";
            this.Load += new System.EventHandler(this.SistemYonetimi_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SistemYonetimi_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dtKullaniciListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dtKullaniciListesi;
        public System.Windows.Forms.Button btnAnasayfa;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnSifreDegistir;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnKullanimİciDisi;
    }
}