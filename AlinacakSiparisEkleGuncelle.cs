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
    public partial class AlinacakSiparisEkleGuncelle : Form
    {
        public Giris FrmGiris;
        public AlinacakSiparisEkleGuncelle()
        {
            InitializeComponent();
        }
        public void Frm_AlinacakSiparisEkleGuncelle_Load_Metot()
        {
            if (FrmGiris.FrmAlinacakSiparisler.vr_BtnDeger == "Ekle")
            {
                
                btnEkle.Text = "Ekle";
            }
            else if (FrmGiris.FrmAlinacakSiparisler.vr_BtnDeger == "Güncelle")
            {
                btnEkle.Text = "Güncelle";
                txtSiparisVeren.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[1].Value.ToString();
                txtAdres.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[2].Value.ToString();
                txtEvTel.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[3].Value.ToString();
                txtCepTel.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[4].Value.ToString();
                txtMetreKare.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[5].Value.ToString();
                txtSiparisNotu.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[6].Value.ToString();
            }

        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            txtSiparisVeren.Text = "";
            txtAdres.Text = "";
            txtEvTel.Text = "";
            txtCepTel.Text = "";
            txtMetreKare.Text = "";
            txtSiparisNotu.Text = "";
            FrmGiris.FrmAlinacakSiparisler.Show();
            S_Siparisler.M_AlinacakSiparisler(FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi);
            this.Hide();
         
        }

        private void AlinacakSiparisEkleGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtSiparisVeren.Text == "" || txtAdres.Text == "" || txtEvTel.Text == "" || txtCepTel.Text == "" || txtMetreKare.Text == "")
            {
                MessageBox.Show("Alanları Boş Bırakmayınız.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (btnEkle.Text == "Ekle")
            {
                S_Siparisler.M_AlinacakSiparislerEkle(txtSiparisVeren.Text, txtAdres.Text, txtEvTel.Text, txtCepTel.Text, int.Parse(txtMetreKare.Text), txtSiparisNotu.Text);
                txtSiparisVeren.Text = "";
                txtAdres.Text = "";
                txtEvTel.Text = "";
                txtCepTel.Text = "";
                txtMetreKare.Text = "";
                txtSiparisNotu.Text = "";
            }

            else if (btnEkle.Text == "Güncelle")
            {
                S_Siparisler.p_AlinacakSiparisGuncelle(int.Parse(FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[0].Value.ToString()), txtSiparisVeren.Text, txtAdres.Text, txtEvTel.Text, txtCepTel.Text, int.Parse(txtMetreKare.Text), txtSiparisNotu.Text);

            }
           
        }

        private void txtEvTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCepTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
    }
}
