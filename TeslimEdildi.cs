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
    
    public partial class TeslimEdildi : Form
    {
        public Giris FrmGiris;
        public TeslimEdildi()
        {
            InitializeComponent();
        }

        public void Frm_Doldur()
        {
            txtSiparisNo.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[0].Value.ToString();
            txtSiparisVeren.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[1].Value.ToString();
            txtMetreKare.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[5].Value.ToString();
            txtAlinacakUcret.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[7].Value.ToString();
            dtSiparisTarihi.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[8].Value.ToString();
        }
        private void TeslimEdildi_Load(object sender, EventArgs e)
        {
            Frm_Doldur();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
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

        private void btnTeslimatTamamla_Click(object sender, EventArgs e)
        {
            DialogResult yanit;
            yanit = MessageBox.Show(txtSiparisNo.Text + " .Numaralı Teslimatı Tamamlamak İstiyor Musunuz ?", "Teslimat Tamamlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yanit == DialogResult.Yes)
            {
                S_Siparisler.M_TeslimatiTamamla(int.Parse(txtSiparisNo.Text), txtSiparisVeren.Text, FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[2].Value.ToString(), FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[3].Value.ToString(), FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[4].Value.ToString(), int.Parse(txtMetreKare.Text), txtAlinacakUcret.Text, dtSiparisTarihi.Text,dtTeslimTarihi.Text);
                FrmGiris.FrmDagitimlar.Show();
                S_Siparisler.M_Dagitimlar(FrmGiris.FrmDagitimlar.dtDagitimListesi);
                FrmGiris.FrmDagitimlar.btnTeslimatlar.Text = "Teslimatlar";
                FrmGiris.FrmDagitimlar.btnGuncelle.Enabled = true;
                FrmGiris.FrmDagitimlar.btnTeslimEdildi.Enabled = true;
                FrmGiris.FrmDagitimlar.btnDurumDegistir.Enabled = true;
                FrmGiris.FrmDagitimlar.cmbSiparisDurum.Enabled = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sipariş Teslimatı Tamamlanamadı.","Teslimat",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnTeslimatTamamla_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnTeslimatTamamla);
        }

        private void btnTeslimatTamamla_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnTeslimatTamamla);
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
