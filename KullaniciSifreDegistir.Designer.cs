namespace Hali_Yıkama_Takibi
{
    partial class KullaniciSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciSifreDegistir));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.txtSifre1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtSifre2
            // 
            this.txtSifre2.Location = new System.Drawing.Point(83, 85);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.PasswordChar = '*';
            this.txtSifre2.Size = new System.Drawing.Size(190, 20);
            this.txtSifre2.TabIndex = 59;
            // 
            // txtSifre1
            // 
            this.txtSifre1.Location = new System.Drawing.Point(83, 56);
            this.txtSifre1.Name = "txtSifre1";
            this.txtSifre1.PasswordChar = '*';
            this.txtSifre1.Size = new System.Drawing.Size(190, 20);
            this.txtSifre1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Şifre2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(33, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Şifre1 :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(83, 20);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(190, 20);
            this.txtKullaniciAdi.TabIndex = 55;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.ForeColor = System.Drawing.Color.Green;
            this.btnGeriDon.Location = new System.Drawing.Point(181, 124);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(110, 23);
            this.btnGeriDon.TabIndex = 61;
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
            this.btnEkle.Location = new System.Drawing.Point(12, 124);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 23);
            this.btnEkle.TabIndex = 60;
            this.btnEkle.Text = "Değiştir";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            this.btnEkle.MouseHover += new System.EventHandler(this.btnEkle_MouseHover);
            // 
            // KullaniciSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 169);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSifre2);
            this.Controls.Add(this.txtSifre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KullaniciSifreDegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Şifre Değiştir";
            this.Load += new System.EventHandler(this.KullaniciSifreDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSifre2;
        public System.Windows.Forms.TextBox txtSifre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnEkle;
    }
}