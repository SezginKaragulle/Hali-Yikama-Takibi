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
    public partial class KullaniciEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public KullaniciEkleGuncelle()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtPersonelAdiSoyadi.Text = "";
            chckKullanimDisi.Checked = false;
            FrmGiris.FrmSistemYonetimi.Show();
            S_Siparisler.M_Kullanicilar(FrmGiris.FrmSistemYonetimi.dtKullaniciListesi);
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            S_Siparisler.M_KullaniciEkle(txtKullaniciAdi.Text, txtSifre.Text, chckKullanimDisi.Checked.ToString(), txtPersonelAdiSoyadi.Text);
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtPersonelAdiSoyadi.Text = "";
            chckKullanimDisi.Checked = false;
        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnEkle);
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnEkle);
        }

        private void btnGeriDon_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnGeriDon);
        }

        private void btnGeriDon_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnGeriDon);
        }

        private void KullaniciEkleGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
