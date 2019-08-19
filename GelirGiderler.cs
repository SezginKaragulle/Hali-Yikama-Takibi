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
    public partial class GelirGiderler : Form
    {
        public Giris FrmGiris;
        public GelirGiderler()
        {
            InitializeComponent();
        }

        private void GelirGiderler_Load(object sender, EventArgs e)
        {

        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void GelirGiderler_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rdbGider_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbGelir_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbTumu_CheckedChanged(object sender, EventArgs e)
        {
            S_Siparisler.M_GelirGiderler(dtGelirGiderListesi, rdbTumu.Text.Trim());
        }

        private void rdbGelir_CheckedChanged(object sender, EventArgs e)
        {
            S_Siparisler.M_GelirGiderler(dtGelirGiderListesi, rdbGelir.Text.Trim());
        }

        private void rdbGider_CheckedChanged(object sender, EventArgs e)
        {
            S_Siparisler.M_GelirGiderler(dtGelirGiderListesi, rdbGider.Text.Trim());
        }

        public string vr_Btn_Deger;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            vr_Btn_Deger = btnEkle.Text;
            FrmGiris.FrmGelirGiderEkleGuncelle.Show();
            FrmGiris.FrmGelirGiderEkleGuncelle.Frm_Doldur();
            this.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            vr_Btn_Deger = btnGuncelle.Text;
            FrmGiris.FrmGelirGiderEkleGuncelle.Show();
            FrmGiris.FrmGelirGiderEkleGuncelle.Frm_Doldur();
            this.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult yanit;
           yanit = MessageBox.Show(dtGelirGiderListesi.CurrentRow.Cells[0].Value.ToString()+" numaralı fişi silmek istiyor musunuz ? ","Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (yanit == DialogResult.Yes)
            {
                S_Siparisler.M_GelirGiderSil(int.Parse(dtGelirGiderListesi.CurrentRow.Cells[0].Value.ToString()));
                S_Siparisler.M_GelirGiderler(dtGelirGiderListesi, rdbTumu.Text);
                rdbTumu.Checked = true;
            }
            else
            {
                MessageBox.Show("Fiş Silme İşlemi Gerçekleştirilmedi.","Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                S_Siparisler.M_GelirGiderler(dtGelirGiderListesi, rdbTumu.Text);
                rdbTumu.Checked = true;
            }
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            if (txtFisNo.Text == "" && chkFisTarihiFiltre.Checked == false)
            {
                S_Siparisler.M_GelirGiderler(dtGelirGiderListesi, rdbTumu.Text.Trim());
                txtFisNo.Text = "";
                dtFisTarihi1.Text = DateTime.Now.ToShortDateString();
                dtFisTarihi2.Text = DateTime.Now.ToShortDateString();
                chkFisTarihiFiltre.Checked = false;
                rdbTumu.Checked = true;
            }
           else if (txtFisNo.Text != "" && chkFisTarihiFiltre.Checked == false)
            {
                S_Siparisler.M_GelirGiderlerFiltre(dtGelirGiderListesi, txtFisNo.Name, txtFisNo.Text, "");
                txtFisNo.Text = "";
                dtFisTarihi1.Text = DateTime.Now.ToShortDateString();
                dtFisTarihi2.Text = DateTime.Now.ToShortDateString();
                chkFisTarihiFiltre.Checked = false;
                rdbTumu.Checked = true;
            }

            else if (txtFisNo.Text == "" && chkFisTarihiFiltre.Checked == true)
            {
                S_Siparisler.M_GelirGiderlerFiltre(dtGelirGiderListesi, dtFisTarihi1.Name, dtFisTarihi1.Text, dtFisTarihi2.Text);
                txtFisNo.Text = "";
                dtFisTarihi1.Text = DateTime.Now.ToShortDateString();
                dtFisTarihi2.Text = DateTime.Now.ToShortDateString();
                chkFisTarihiFiltre.Checked = false;
                rdbTumu.Checked = true;
            }




        }

        private void dtFisTarihi1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnEkle);
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnEkle);
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnGuncelle);
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnGuncelle);
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnSil);
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnSil);
        }

        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnAnasayfa);
        }

        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnAnasayfa);
        }

        private void btnFiltre_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnFiltre);
        }

        private void btnFiltre_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnFiltre);
        }
    }
}
