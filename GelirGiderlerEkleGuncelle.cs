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
    public partial class GelirGiderlerEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public GelirGiderlerEkleGuncelle()
        {
            InitializeComponent();
        }
        public void Frm_Doldur()
        {
            if (FrmGiris.FrmGelirGiderler.vr_Btn_Deger == "Ekle")
            {
                btnEkle.Text = "Ekle";
            }
            if (FrmGiris.FrmGelirGiderler.vr_Btn_Deger == "Güncelle" && FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[4].Value.ToString() == "A")
            {
                btnEkle.Text = "Güncelle";
                dtFisTarihi.Text = FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[1].Value.ToString();
                txtFisAciklamasi.Text = FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[2].Value.ToString();
                txtFisTutari.Text = FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[3].Value.ToString();
                rdbAlacak.Checked = true;

            }
            else if (FrmGiris.FrmGelirGiderler.vr_Btn_Deger == "Güncelle" && FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[4].Value.ToString() == "B")
            {
                btnEkle.Text = "Güncelle";
                dtFisTarihi.Text = FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[1].Value.ToString();
                txtFisAciklamasi.Text = FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[2].Value.ToString();
                txtFisTutari.Text = FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[3].Value.ToString();
                rdbBorc.Checked = true;

            }
        }
        private void GelirGiderlerEkleGuncelle_Load(object sender, EventArgs e)
        {
            Frm_Doldur();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            dtFisTarihi.Text = DateTime.Now.ToShortDateString();
            txtFisAciklamasi.Text = "";
            txtFisTutari.Text = "";
            rdbAlacak.Checked = false;
            rdbBorc.Checked = false;
            FrmGiris.FrmGelirGiderler.Show();
            S_Siparisler.M_GelirGiderler(FrmGiris.FrmGelirGiderler.dtGelirGiderListesi,FrmGiris.FrmGelirGiderler.rdbTumu.Text);
            FrmGiris.FrmGelirGiderler.rdbTumu.Checked = true;
            S_Siparisler.M_GelirGiderToplamı(FrmGiris.FrmGelirGiderler.txtToplamGelir, "A");
            S_Siparisler.M_GelirGiderToplamı(FrmGiris.FrmGelirGiderler.txtToplamGider, "B");
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Ekle")
            {
                if (rdbAlacak.Checked == false && rdbBorc.Checked == false)
                {
                    MessageBox.Show("Alcak veya Borç Seçimi Yapınız", "Gelir Gider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdbAlacak.Checked == true)
                {
                    S_Siparisler.M_GelirGiderEkle(dtFisTarihi.Text, txtFisAciklamasi.Text, txtFisTutari.Text, "A");
                    dtFisTarihi.Text = DateTime.Now.ToShortDateString();
                    txtFisAciklamasi.Text = "";
                    txtFisTutari.Text = "";
                    rdbAlacak.Checked = false;
                    rdbBorc.Checked = false;
                }
                else if (rdbBorc.Checked == true)
                {
                    S_Siparisler.M_GelirGiderEkle(dtFisTarihi.Text, txtFisAciklamasi.Text, txtFisTutari.Text, "B");
                    dtFisTarihi.Text = DateTime.Now.ToShortDateString();
                    txtFisAciklamasi.Text = "";
                    txtFisTutari.Text = "";
                    rdbAlacak.Checked = false;
                    rdbBorc.Checked = false;
                }
            }

            if (btnEkle.Text == "Güncelle")
            {
                if (rdbAlacak.Checked == false && rdbBorc.Checked == false)
                {
                    MessageBox.Show("Alcak veya Borç Seçimi Yapınız", "Gelir Gider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (rdbAlacak.Checked == true)
                {
                    
                    S_Siparisler.M_GelirGiderGuncelle(int.Parse(FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[0].Value.ToString()),dtFisTarihi.Text, txtFisAciklamasi.Text, txtFisTutari.Text, "A");
                    
                }
                else if (rdbBorc.Checked == true)
                {
                    
                    S_Siparisler.M_GelirGiderGuncelle(int.Parse(FrmGiris.FrmGelirGiderler.dtGelirGiderListesi.CurrentRow.Cells[0].Value.ToString()),dtFisTarihi.Text, txtFisAciklamasi.Text, txtFisTutari.Text, "B");
                  
                }
            }


        }

        private void txtFisTutari_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbAlacak_Click(object sender, EventArgs e)
        {
            txtFisTutari.Text = txtFisTutari.Text.ToString().Replace(",", ".");
        }

        private void rdbBorc_Click(object sender, EventArgs e)
        {
            txtFisTutari.Text = txtFisTutari.Text.ToString().Replace(",", ".");
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
    }
}
