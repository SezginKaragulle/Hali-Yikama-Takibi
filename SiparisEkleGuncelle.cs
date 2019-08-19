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
    public partial class SiparisEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public SiparisEkleGuncelle()
        {
            InitializeComponent();
        }

        public void Frm_SiparisEkleGuncelle_Load_Metot()
        {
            if (FrmGiris.FrmSiparisler.vr_BtnDeger == "Ekle")
            {
                btnEkle.Text = "Ekle";
                S_Siparisler.M_SiparisSayaci(txtSiparisNo);
                groupBox1.Visible = true;
                btnUcretHesapla.Visible = true;
                txtUcret.Visible = true;
            }
            else if (FrmGiris.FrmSiparisler.vr_BtnDeger == "Güncelle")
            {
                btnEkle.Text = "Güncelle";
                groupBox1.Visible = false;
                btnUcretHesapla.Visible = false;
                txtUcret.Visible = false;
                txtSiparisNo.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[0].Value.ToString();
                txtSiparisVeren.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[1].Value.ToString();
                txtAdres.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[2].Value.ToString();
                txtEvTel.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[3].Value.ToString();
                txtCepTel.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[4].Value.ToString();
                txtMetreKare.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[5].Value.ToString();
                txtSiparisNotu.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[6].Value.ToString();
                txtAlinacakUcret.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[7].Value.ToString();
                dtSiparisTarihi.Text = FrmGiris.FrmSiparisler.dtSiparisListesi.CurrentRow.Cells[8].Value.ToString();

            }

        }
        private void SiparisEkleGuncelle_Load(object sender, EventArgs e)
        {
            Frm_SiparisEkleGuncelle_Load_Metot();
            
           

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            txtSiparisNo.Text = "";
            txtSiparisVeren.Text = "";
            txtAdres.Text = "";
            txtEvTel.Text = "";
            txtCepTel.Text = "";
            txtMetreKare.Text = "";
            txtSiparisNotu.Text = "";
            txtAlinacakUcret.Text = "";
            dtSiparisTarihi.Text = DateTime.Now.ToShortDateString();
            txtUcret.Text = "";
            FrmGiris.FrmSiparisler.Show();
            S_Siparisler.M_Siparisler(FrmGiris.FrmSiparisler.dtSiparisListesi);
            this.Hide();
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
         
            if (btnEkle.Text == "Ekle")
            {
                if (txtUcret.Text == "" || txtAlinacakUcret.Text == "")
                {
                    MessageBox.Show("Ücret Hesaplamasını Gerçekleştiriniz", "Ücret Hesaplama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    S_Siparisler.M_TeslimAlindi(int.Parse(txtSiparisNo.Text), txtSiparisVeren.Text, txtAdres.Text, txtEvTel.Text, txtCepTel.Text, int.Parse(txtMetreKare.Text), txtSiparisNotu.Text, txtAlinacakUcret.Text, dtSiparisTarihi.Text);
                    S_Siparisler.M_SiparisSayaci(txtSiparisNo);
                    txtSiparisVeren.Text = "";
                    txtAdres.Text = "";
                    txtEvTel.Text = "";
                    txtCepTel.Text = "";
                    txtMetreKare.Text = "";
                    txtSiparisNotu.Text = "";
                    txtAlinacakUcret.Text = "";
                    dtSiparisTarihi.Text = DateTime.Now.ToShortDateString();
                    txtUcret.Text = "";

                }
                
            }
            else if (btnEkle.Text == "Güncelle")
            {
                S_Siparisler.M_SiparisGuncelle(int.Parse(txtSiparisNo.Text), txtSiparisVeren.Text, txtAdres.Text, txtEvTel.Text, txtCepTel.Text, int.Parse(txtMetreKare.Text), txtSiparisNotu.Text, txtAlinacakUcret.Text, dtSiparisTarihi.Text);
            }
           
        }

        private double gr_ucret;
        private double gr_toplamucret;
        private string gr_metrekare;
        private void btnUcretHesapla_Click(object sender, EventArgs e)
        {
            if (txtUcret.Text == "")
            {
                MessageBox.Show("Hesaplanacak Tutarı Giriniz", "Hesaplanacak Tutar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                gr_metrekare = txtMetreKare.Text.Trim();
                gr_ucret = double.Parse(txtUcret.Text.Trim());
                gr_toplamucret = double.Parse(gr_metrekare) * gr_ucret;
                txtAlinacakUcret.Text = String.Format(gr_toplamucret.ToString());
              
            }
        }

        private void txtMetreKare_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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

        private void btnUcretHesapla_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnUcretHesapla);
        }

        private void btnUcretHesapla_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnUcretHesapla);
        }
    }
}
