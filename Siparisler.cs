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
    public partial class Siparisler : Form
    {
        public Giris FrmGiris;
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            S_Siparisler.M_Siparisler(dtSiparisListesi);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void Siparisler_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            DialogResult yanit;
           
            if (cmbSiparisDurum.Text == "")
            {
                MessageBox.Show("Durum Seçiniz","Durum Değiştir",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                yanit = MessageBox.Show(dtSiparisListesi.CurrentRow.Cells[0].Value.ToString() + "  numaralı siparişin durumunu değiştirmek istiyor musunz  ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yanit == DialogResult.Yes)
                {
                    S_Siparisler.M_SiparisDurumGuncelleme(int.Parse(dtSiparisListesi.CurrentRow.Cells[0].Value.ToString()), cmbSiparisDurum.Text);
                    cmbSiparisDurum.Text = "";
                    S_Siparisler.M_Siparisler(dtSiparisListesi);
                }
                else if (yanit == DialogResult.No)
                {
                    MessageBox.Show("Sipariş Durum Güncelleme Gerçekleştirilmedi.", "Sipariş Durum Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSiparisDurum.Text = "";
                    S_Siparisler.M_Siparisler(dtSiparisListesi);
                }
            }
            
        }
        public string vr_BtnDeger;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            vr_BtnDeger = btnEkle.Text;
            FrmGiris.FrmSiparisEkleGuncelle.Show();
            S_Siparisler.M_SiparisSayaci(FrmGiris.FrmSiparisEkleGuncelle.txtSiparisNo);
            FrmGiris.FrmSiparisEkleGuncelle.Frm_SiparisEkleGuncelle_Load_Metot();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            vr_BtnDeger = btnGuncelle.Text;
            FrmGiris.FrmSiparisEkleGuncelle.Show();
            FrmGiris.FrmSiparisEkleGuncelle.Frm_SiparisEkleGuncelle_Load_Metot();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            DialogResult cevap;
            cevap = MessageBox.Show(dtSiparisListesi.CurrentRow.Cells[0].Value.ToString() + " Numaralı Sipariş Silinsin mi ?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                S_Siparisler.M_SiparisSil(int.Parse(dtSiparisListesi.CurrentRow.Cells[0].Value.ToString()));
                S_Siparisler.M_Siparisler(dtSiparisListesi);
            }
            else
            {
                MessageBox.Show("Sipariş Silme İşlemi Gerçekleştirilmedi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Siparisler.M_Siparisler(dtSiparisListesi);
            }
            

        }

        private void btnDagitimaGonder_Click(object sender, EventArgs e)
        {
            DialogResult yanit;
            //if (dtSiparisListesi.CurrentRow.Cells[9].Value.ToString() == null)
            //{
            //    MessageBox.Show("İşlem İçin Kayıt Seçiniz","Dağıtım",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
            if (dtSiparisListesi.CurrentRow.Cells[9].Value.ToString() != "Paketlendi")
            {
                MessageBox.Show("Siparişin Dağıtıma Gönderimi İçin Durumu 'Paketlendi' olmalıdır.","Dağıtım",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cmbSiparisDurum.Text = "";
            }
            else if (dtSiparisListesi.CurrentRow.Cells[9].Value.ToString() == "Paketlendi")
            {
                yanit = MessageBox.Show(dtSiparisListesi.CurrentRow.Cells[0].Value.ToString() + " Numaralı Sipariş Dağıtıma Gönderilsin mi ?", "Dağıtıma Gönder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yanit == DialogResult.Yes)
                {
                    S_Siparisler.M_DagitimaGonder(int.Parse(dtSiparisListesi.CurrentRow.Cells[0].Value.ToString()), dtSiparisListesi.CurrentRow.Cells[1].Value.ToString(), dtSiparisListesi.CurrentRow.Cells[2].Value.ToString(), dtSiparisListesi.CurrentRow.Cells[3].Value.ToString(), dtSiparisListesi.CurrentRow.Cells[4].Value.ToString(), int.Parse(dtSiparisListesi.CurrentRow.Cells[5].Value.ToString()), dtSiparisListesi.CurrentRow.Cells[6].Value.ToString(), dtSiparisListesi.CurrentRow.Cells[7].Value.ToString(), dtSiparisListesi.CurrentRow.Cells[8].Value.ToString());
                    S_Siparisler.M_Siparisler(dtSiparisListesi);
                }
                else
                {
                    MessageBox.Show("Sipariş Dağıtıma Gönderme İşlemi İptal Edildi.","Dağıtıma Gönder",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
            }
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            if (txtSiparisNo.Text == "" && txtSiparisVeren.Text == "" && cmbDurumFiltre.Text == "")
            {
                S_Siparisler.M_Siparisler(dtSiparisListesi);
                cmbSiparisDurum.Text = "";
                cmbDurumFiltre.Text = "";
                txtSiparisNo.Text = "";
                txtSiparisVeren.Text = "";
            }
            else if (txtSiparisVeren.Text == "" && cmbDurumFiltre.Text == "")
            {

                S_Siparisler.M_SiparislerFiltre(dtSiparisListesi, txtSiparisNo.Name, txtSiparisNo.Text);
                cmbSiparisDurum.Text = "";
                cmbDurumFiltre.Text = "";
                txtSiparisNo.Text = "";
                txtSiparisVeren.Text = "";

            }
            else if (txtSiparisNo.Text == "" && cmbDurumFiltre.Text == "")
            {
                S_Siparisler.M_SiparislerFiltre(dtSiparisListesi, txtSiparisVeren.Name, txtSiparisVeren.Text.Trim());
                cmbSiparisDurum.Text = "";
                cmbDurumFiltre.Text = "";
                txtSiparisNo.Text = "";
                txtSiparisVeren.Text = "";
            }
            else if (txtSiparisNo.Text == "" && txtSiparisVeren.Text == "")
            {
                S_Siparisler.M_SiparislerFiltre(dtSiparisListesi, cmbDurumFiltre.Name, cmbDurumFiltre.Text);
                cmbSiparisDurum.Text = "";
                cmbDurumFiltre.Text = "";
                txtSiparisNo.Text = "";
                txtSiparisVeren.Text = "";
            }
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

        private void btnAnasayfa_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnAnasayfa_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnAnasayfa);
        }

        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnAnasayfa);
        }

        private void btnDagitimaGonder_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnDagitimaGonder);
        }

        private void btnDagitimaGonder_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnDagitimaGonder);
        }

        private void btnDurumDegistir_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnDurumDegistir);
        }

        private void btnDurumDegistir_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnDurumDegistir);
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
