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
    public partial class AlinacakSiparisler : Form
    {
        public Giris FrmGiris;
        public AlinacakSiparisler()
        {
            InitializeComponent();
        }
        public string vr_BtnDeger;
        private void AlinacakSiparisler_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AlinacakSiparisler_Load(object sender, EventArgs e)
        {
            S_Siparisler.M_AlinacakSiparisler(dtAlinacakSiparislerimListesi);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            vr_BtnDeger = btnEkle.Text;
            FrmGiris.FrmAlinacakSiparisEkleGuncelle.Show();
            FrmGiris.FrmAlinacakSiparisEkleGuncelle.Frm_AlinacakSiparisEkleGuncelle_Load_Metot();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            vr_BtnDeger = btnGuncelle.Text;
            FrmGiris.FrmAlinacakSiparisEkleGuncelle.Show();
            FrmGiris.FrmAlinacakSiparisEkleGuncelle.Frm_AlinacakSiparisEkleGuncelle_Load_Metot();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(dtAlinacakSiparislerimListesi.CurrentRow.Cells[0].Value.ToString() + " Numaralı Sipariş Silinsin mi ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                S_Siparisler.M_AlinacakSiparisSil(int.Parse(dtAlinacakSiparislerimListesi.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Sipariş Silme İşlemi Gerçekleştirildi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Siparisler.M_AlinacakSiparisler(dtAlinacakSiparislerimListesi);
            }
            else
            {
                MessageBox.Show("Sipariş Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtTeslimAlindi_Click(object sender, EventArgs e)
        {
            if (gr_dtTutulanDeger == "")
            {
                MessageBox.Show("İşlem Yapmak İçin Kayıt Seçmelisiniz","Teslim Alma",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                FrmGiris.FrmTeslimAlma.Show();
                S_Siparisler.M_SiparisSayaci(FrmGiris.FrmTeslimAlma.txtSiparisNo);
                FrmGiris.FrmTeslimAlma.TeslimAlma_Form_Metot();
                this.Hide();

            }
           
        }

        private string gr_dtTutulanDeger;
        private void dtAlinacakSiparislerimListesi_MouseClick(object sender, MouseEventArgs e)
        {
            gr_dtTutulanDeger = dtAlinacakSiparislerimListesi.CurrentRow.Cells[0].Value.ToString();
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

        private void txtTeslimAlindi_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(txtTeslimAlindi);
        }

        private void txtTeslimAlindi_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(txtTeslimAlindi);
        }

        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnAnasayfa);
        }

        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnAnasayfa);
        }
    }
}
