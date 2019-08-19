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
    public partial class DagitimGuncelle : Form
    {
        public Giris FrmGiris;
        public DagitimGuncelle()
        {
            InitializeComponent();
        }

        public void frm_DagitimGuncelleMetod()
        {

            txtSiparisNo.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[0].Value.ToString();
            txtSiparisVeren.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[1].Value.ToString();
            txtAdres.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[2].Value.ToString();
            txtEvTel.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[3].Value.ToString();
            txtCepTel.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[4].Value.ToString();
            txtMetreKare.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[5].Value.ToString();
            txtSiparisNotu.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[6].Value.ToString();
            txtAlinacakUcret.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[7].Value.ToString();
            dtSiparisTarihi.Text = FrmGiris.FrmDagitimlar.dtDagitimListesi.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmDagitimlar.Show();
            S_Siparisler.M_Dagitimlar(FrmGiris.FrmDagitimlar.dtDagitimListesi);
            this.Hide();
        }

        private void DagitimGuncelle_Load(object sender, EventArgs e)
        {
            frm_DagitimGuncelleMetod();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            S_Siparisler.M_DagitimGuncelle(int.Parse(txtSiparisNo.Text), txtSiparisVeren.Text, txtAdres.Text, txtEvTel.Text, txtCepTel.Text, int.Parse(txtMetreKare.Text), txtSiparisNotu.Text, txtAlinacakUcret.Text, dtSiparisTarihi);
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnGuncelle);
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnGuncelle);
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
