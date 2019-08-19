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
    public partial class Dagitimlar : Form
    {
        public Giris FrmGiris;

        public Dagitimlar()
        {
            InitializeComponent();
        }

        private void Dagitimlar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Dagitimlar_Load(object sender, EventArgs e)
        {
            S_Siparisler.M_Dagitimlar(dtDagitimListesi);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void btnTeslimEdildi_Click(object sender, EventArgs e)
        {
            if (dtDagitimListesi.CurrentRow.Cells[9].Value.ToString() != "Dağıtımda")
            {
                MessageBox.Show("Sipariş Dağıtım Durum da olmalıdır. ","Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                FrmGiris.FrmTeslimEdildi.Show();
                FrmGiris.FrmTeslimEdildi.txtSiparisNo.Enabled = false;
                FrmGiris.FrmTeslimEdildi.txtSiparisVeren.Enabled = false;
                FrmGiris.FrmTeslimEdildi.txtMetreKare.Enabled = false;
                FrmGiris.FrmTeslimEdildi.dtSiparisTarihi.Enabled = false;
                this.Hide();
            }
        }

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            DialogResult yanit;
            if (cmbSiparisDurum.Text == "")
            {
                MessageBox.Show("Sipariş Durumu Seçiniz","Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                yanit = MessageBox.Show(dtDagitimListesi.CurrentRow.Cells[0].Value.ToString() + "  numaralı siparişin dağıtım durumunu değiştirmek istiyor musunz  ?", "Dağıtım Durum", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yanit == DialogResult.Yes)
                {
                    S_Siparisler.M_DagitimDurumGuncelleme(int.Parse(dtDagitimListesi.CurrentRow.Cells[0].Value.ToString()), cmbSiparisDurum.Text);
                    cmbSiparisDurum.Text = "";
                    S_Siparisler.M_Dagitimlar(dtDagitimListesi);
                }
                else if (yanit == DialogResult.No)
                {
                    MessageBox.Show("Dağıtım Durum Güncelleme Gerçekleştirilmedi.", "Dağıtım Durum Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSiparisDurum.Text = "";
                    S_Siparisler.M_Dagitimlar(dtDagitimListesi);
                }
            }
       
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmDagitimGuncelle.Show();
            FrmGiris.FrmDagitimGuncelle.frm_DagitimGuncelleMetod();
            this.Hide();
        }

        private void btnTeslimatlar_Click(object sender, EventArgs e)
        {
            if (btnTeslimatlar.Text == "Teslimatlar")
            {
                S_Siparisler.M_Teslimler(dtDagitimListesi);
                btnGuncelle.Enabled = false;
                btnTeslimEdildi.Enabled = false;
                btnDurumDegistir.Enabled = false;
                cmbSiparisDurum.Enabled = false;
                btnTeslimatlar.Text = "Dağıtımlar";
            }
            else if (btnTeslimatlar.Text == "Dağıtımlar")
            {
                S_Siparisler.M_Dagitimlar(dtDagitimListesi);
                btnGuncelle.Enabled = true;
                btnTeslimEdildi.Enabled = true;
                btnDurumDegistir.Enabled = true;
                cmbSiparisDurum.Enabled = true;
                btnTeslimatlar.Text = "Teslimatlar";
            }
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            if (txtSiparisNo.Text == "" && txtSiparisVeren.Text == "" && cmbDurumFiltre.Text == "")
            {
                S_Siparisler.M_Dagitimlar(dtDagitimListesi);
                cmbSiparisDurum.Text = "";
                cmbDurumFiltre.Text = "";
                txtSiparisNo.Text = "";
                txtSiparisVeren.Text = "";
            }
            else if (txtSiparisVeren.Text == "" && cmbDurumFiltre.Text == "")
            {

                S_Siparisler.M_DagitimlarFiltre(dtDagitimListesi, txtSiparisNo.Name, txtSiparisNo.Text);
                cmbSiparisDurum.Text = "";
                cmbDurumFiltre.Text = "";
                txtSiparisNo.Text = "";
                txtSiparisVeren.Text = "";

            }
            else if (txtSiparisNo.Text == "" && cmbDurumFiltre.Text == "")
            {
                S_Siparisler.M_DagitimlarFiltre(dtDagitimListesi, txtSiparisVeren.Name, txtSiparisVeren.Text.Trim());
                cmbSiparisDurum.Text = "";
                cmbDurumFiltre.Text = "";
                txtSiparisNo.Text = "";
                txtSiparisVeren.Text = "";
            }
            else if (txtSiparisNo.Text == "" && txtSiparisVeren.Text == "")
            {
                S_Siparisler.M_DagitimlarFiltre(dtDagitimListesi, cmbDurumFiltre.Name, cmbDurumFiltre.Text);
                cmbSiparisDurum.Text = "";
                cmbDurumFiltre.Text = "";
                txtSiparisNo.Text = "";
                txtSiparisVeren.Text = "";
            }
        }

        private void btnTeslimatlar_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnTeslimatlar);
        }

        private void btnTeslimatlar_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnTeslimatlar);
        }

        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnGuncelle);
        }

        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnGuncelle);
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

        private void btnTeslimEdildi_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnTeslimEdildi);
        }

        private void btnTeslimEdildi_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnTeslimEdildi);
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
