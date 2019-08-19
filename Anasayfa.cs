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
    public partial class Anasayfa : Form
    {
        public Giris FrmGiris;
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void Anasayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                DialogResult yanit;
                yanit = MessageBox.Show("Programdan çıkmak istiyor musunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yanit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void btnAlinanSiparisler_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmAlinacakSiparisler.Show();
            S_Siparisler.M_AlinacakSiparisler(FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi);
            this.Hide();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmSiparisler.Show();
            S_Siparisler.M_Siparisler(FrmGiris.FrmSiparisler.dtSiparisListesi);
            this.Hide();
        }

        private void btnDagitimYonetimi_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmDagitimlar.Show();
            S_Siparisler.M_Dagitimlar(FrmGiris.FrmDagitimlar.dtDagitimListesi);
            FrmGiris.FrmDagitimlar.btnTeslimatlar.Text = "Teslimatlar";
            FrmGiris.FrmDagitimlar.btnGuncelle.Enabled = true;
            FrmGiris.FrmDagitimlar.btnTeslimEdildi.Enabled = true;
            FrmGiris.FrmDagitimlar.btnDurumDegistir.Enabled = true;
            FrmGiris.FrmDagitimlar.cmbSiparisDurum.Enabled = true;
            this.Hide();
        }

        private void btnGelirGiderYonetimi_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmGelirGiderler.Show();
            S_Siparisler.M_GelirGiderler(FrmGiris.FrmGelirGiderler.dtGelirGiderListesi, FrmGiris.FrmGelirGiderler.rdbTumu.Text);
            FrmGiris.FrmGelirGiderler.rdbTumu.Checked = true;
            S_Siparisler.M_GelirGiderToplamı(FrmGiris.FrmGelirGiderler.txtToplamGelir, "A");
            S_Siparisler.M_GelirGiderToplamı(FrmGiris.FrmGelirGiderler.txtToplamGider, "B");
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmSistemYonetimi.Show();
            S_Siparisler.M_Kullanicilar(FrmGiris.FrmSistemYonetimi.dtKullaniciListesi);
            this.Hide();
        }

        private void btnAlinanSiparisler_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnAlinanSiparisler);
        }

        private void btnAlinanSiparisler_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnAlinanSiparisler);
        }

        private void btnSiparisler_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnSiparisler);
        }

        private void btnSiparisler_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnSiparisler);
        }

        private void btnDagitimYonetimi_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnDagitimYonetimi);
        }

        private void btnDagitimYonetimi_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnDagitimYonetimi);
        }

        private void btnGelirGiderYonetimi_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnGelirGiderYonetimi);
        }

        private void btnGelirGiderYonetimi_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnGelirGiderYonetimi);
        }

        private void btnSistemYonetimi_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmSistemYonetimi.Show();
            S_Siparisler.M_Kullanicilar(FrmGiris.FrmSistemYonetimi.dtKullaniciListesi);
            this.Hide();
        }

        private void btnSistemYonetimi_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnSistemYonetimi);
        }

        private void btnSistemYonetimi_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnSistemYonetimi);
        }
    }
}
