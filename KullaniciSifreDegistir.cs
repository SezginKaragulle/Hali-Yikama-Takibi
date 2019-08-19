using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hali_Yıkama_Takibi
{
    public partial class KullaniciSifreDegistir : Form
    {
        public Giris FrmGiris;
        public KullaniciSifreDegistir()
        {
            InitializeComponent();
        }
       public void Frm_Doldur()
        {
            txtKullaniciAdi.Text = FrmGiris.FrmSistemYonetimi.dtKullaniciListesi.CurrentRow.Cells[1].Value.ToString();
        }

        private void KullaniciSifreDegistir_Load(object sender, EventArgs e)
        {
            Frm_Doldur();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmSistemYonetimi.Show();
            S_Siparisler.M_Kullanicilar(FrmGiris.FrmSistemYonetimi.dtKullaniciListesi);
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSifre1.Text.Trim() == txtSifre2.Text.Trim())
            {
                S_Siparisler.M_KullaniciSifreGuncelle(FrmGiris.FrmSistemYonetimi.dtKullaniciListesi.CurrentRow.Cells[0].Value.ToString(), txtSifre1.Text.Trim());
                txtKullaniciAdi.Text = "";
                txtSifre1.Text = "";
                txtSifre2.Text = "";
                FrmGiris.FrmSistemYonetimi.Show();
                S_Siparisler.M_Kullanicilar(FrmGiris.FrmSistemYonetimi.dtKullaniciListesi);
                this.Hide();

            }
            else
            {
                MessageBox.Show("İki şifre alanına girilen şifre farklıdır.","Şifre Değiştirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtSifre1.Text = "";
                txtSifre2.Text = "";
            }
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnEkle);
        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnEkle);
        }

        private void btnGeriDon_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnGeriDon);
        }

        private void btnGeriDon_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnGeriDon);
        }
    }
}
