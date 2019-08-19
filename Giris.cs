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
    public partial class Giris : Form
    {
        public Anasayfa FrmAnasayfa;
        public AlinacakSiparisler FrmAlinacakSiparisler;
        public AlinacakSiparisEkleGuncelle FrmAlinacakSiparisEkleGuncelle;
        public TeslimAlma FrmTeslimAlma;
        public Siparisler FrmSiparisler;
        public SiparisEkleGuncelle FrmSiparisEkleGuncelle;
        public Dagitimlar FrmDagitimlar;
        public DagitimGuncelle FrmDagitimGuncelle;
        public TeslimEdildi FrmTeslimEdildi;
        public GelirGiderler FrmGelirGiderler;
        public GelirGiderlerEkleGuncelle FrmGelirGiderEkleGuncelle;
        public SistemYonetimi FrmSistemYonetimi;
        public KullaniciEkleGuncelle FrmKullaniciEkleGuncelle;
        public KullaniciSifreDegistir FrmKullaniciSifreDegistir;
        public Giris()
        {
            FrmAnasayfa = new Anasayfa();
            FrmAlinacakSiparisler = new AlinacakSiparisler();
            FrmAlinacakSiparisEkleGuncelle = new AlinacakSiparisEkleGuncelle();
            FrmTeslimAlma = new TeslimAlma();
            FrmSiparisler = new Siparisler();
            FrmSiparisEkleGuncelle = new SiparisEkleGuncelle();
            FrmDagitimlar = new Dagitimlar();
            FrmDagitimGuncelle = new DagitimGuncelle();
            FrmTeslimEdildi = new TeslimEdildi();
            FrmGelirGiderler = new GelirGiderler();
            FrmGelirGiderEkleGuncelle = new GelirGiderlerEkleGuncelle();
            FrmSistemYonetimi = new SistemYonetimi();
            FrmKullaniciEkleGuncelle = new KullaniciEkleGuncelle();
            FrmKullaniciSifreDegistir = new KullaniciSifreDegistir();
            /*------------------------------------*/
            FrmAnasayfa.FrmGiris = this;
            FrmAlinacakSiparisler.FrmGiris = this;
            FrmAlinacakSiparisEkleGuncelle.FrmGiris = this;
            FrmTeslimAlma.FrmGiris = this;
            FrmSiparisler.FrmGiris = this;
            FrmSiparisEkleGuncelle.FrmGiris = this;
            FrmDagitimlar.FrmGiris = this;
            FrmDagitimGuncelle.FrmGiris = this;
            FrmTeslimEdildi.FrmGiris = this;
            FrmGelirGiderler.FrmGiris = this;
            FrmGelirGiderEkleGuncelle.FrmGiris = this;
            FrmSistemYonetimi.FrmGiris = this;
            FrmKullaniciEkleGuncelle.FrmGiris = this;
            FrmKullaniciSifreDegistir.FrmGiris = this;


            InitializeComponent();
        }

        public void Button_Hover (Button vr_Btn)
        {
            vr_Btn.BackColor = Color.Green;
            vr_Btn.ForeColor = Color.White;
        }

        public void Button_Leave(Button vr_Btn)
        {
            vr_Btn.BackColor = Color.White;
            vr_Btn.ForeColor = Color.Green;
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //S_Baglanti.BaglantiTest();
            S_Baglanti.M_Giris(txtKullaniciAdi.Text, txtSifre.Text, FrmAnasayfa, this);
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";


        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult yanitim;
            yanitim = MessageBox.Show("Sistem den çıkmak istiyor musunuz ?", "Sistem Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yanitim == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void Giris_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_MouseHover(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.Green;
            btnGiris.ForeColor = Color.White;
        }

        private void btnGiris_MouseLeave(object sender, EventArgs e)
        {
            btnGiris.BackColor = Color.White;
            btnGiris.ForeColor = Color.Green;
        }

        private void btnCikis_MouseHover(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Green;
            btnCikis.ForeColor = Color.White;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.White;
            btnCikis.ForeColor = Color.Green;
        }
    }
}
