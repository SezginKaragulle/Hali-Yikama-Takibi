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
    public partial class TeslimAlma : Form
    {
        public Giris FrmGiris;
        public TeslimAlma()
        {
            InitializeComponent();
        }

        public void TeslimAlma_Form_Metot()
        {

            txtSiparisVeren.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[1].Value.ToString();
            txtAdres.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[2].Value.ToString();
            txtEvTel.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[3].Value.ToString();
            txtCepTel.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[4].Value.ToString();
            txtMetreKare.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[5].Value.ToString();
            txtSiparisNotu.Text = FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[6].Value.ToString();
        }
        private void TeslimAlma_Load(object sender, EventArgs e)
        {
            S_Siparisler.M_SiparisSayaci(txtSiparisNo);
            TeslimAlma_Form_Metot();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            txtSiparisVeren.Text = "";
            txtAdres.Text = "";
            txtEvTel.Text = "";
            txtCepTel.Text = "";
            txtMetreKare.Text = "";
            txtSiparisNotu.Text = "";
            txtAlinacakUcret.Text = "";
            txtUcret.Text = "";
            FrmGiris.FrmAlinacakSiparisler.Show();
            S_Siparisler.M_AlinacakSiparisler(FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi);
            this.Hide();
        }
        private float gr_ucret;
        private float gr_toplamucret;
        private int gr_metrekare;
        private void btnUcretHesapla_Click(object sender, EventArgs e)
        {
            if (txtUcret.Text == "")
            {
                MessageBox.Show("Hesaplanacak Tutarı Giriniz","Hesaplanacak Tutar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                gr_ucret = float.Parse(txtUcret.Text);
                gr_metrekare = int.Parse(txtMetreKare.Text);
                gr_toplamucret = gr_ucret * gr_metrekare;
                txtAlinacakUcret.Text = gr_toplamucret.ToString();
                txtAlinacakUcret.Text = txtAlinacakUcret.Text.ToString().Replace(",", ".");
            }
          
            
        }

        private void btnTeslimSonuc_Click(object sender, EventArgs e)
        {
            if (txtUcret.Text == "" || txtAlinacakUcret.Text == "")
            {
                MessageBox.Show("Ücret Hesaplamasını Gerçekleştiriniz","Ücret Hesaplama",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Teslim Alınma İşlemi Tamamlanacak. Sipariş Kaydının Oluşmasını Onaylıyor musunuz ?","Teslim Alma",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    S_Siparisler.M_TeslimAlindi(int.Parse(txtSiparisNo.Text), txtSiparisVeren.Text, txtAdres.Text, txtEvTel.Text, txtCepTel.Text, int.Parse(txtMetreKare.Text), txtSiparisNotu.Text,txtAlinacakUcret.Text, dtSiparisTarihi.Text);
                    S_Siparisler.M_AlinacakSiparisSil(int.Parse(FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi.CurrentRow.Cells[0].Value.ToString()));
                    txtSiparisVeren.Text = "";
                    txtAdres.Text = "";
                    txtEvTel.Text = "";
                    txtCepTel.Text = "";
                    txtMetreKare.Text = "";
                    txtSiparisNotu.Text = "";
                    txtUcret.Text = "";
                    txtAlinacakUcret.Text = "";
                    FrmGiris.FrmAlinacakSiparisler.Show();
                    S_Siparisler.M_AlinacakSiparisler(FrmGiris.FrmAlinacakSiparisler.dtAlinacakSiparislerimListesi);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Teslim Almınma İşlemi Tamamlanmadı.","Teslim Alma",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void btnUcretHesapla_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnUcretHesapla);
        }

        private void btnUcretHesapla_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnUcretHesapla);
        }

        private void btnGeriDon_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnGeriDon);
        }

        private void btnGeriDon_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnGeriDon);
        }

        private void btnTeslimSonuc_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnTeslimSonuc);
        }

        private void btnTeslimSonuc_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnTeslimSonuc);
        }
    }
}
