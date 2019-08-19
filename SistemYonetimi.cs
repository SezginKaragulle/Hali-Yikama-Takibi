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
    public partial class SistemYonetimi : Form
    {
        public Giris FrmGiris;
        public SistemYonetimi()
        {
            InitializeComponent();
        }

        private void SistemYonetimi_Load(object sender, EventArgs e)
        {
            S_Siparisler.M_Kullanicilar(dtKullaniciListesi);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmAnasayfa.Show();
            this.Hide();
        }

        private void SistemYonetimi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmKullaniciEkleGuncelle.Show();
            this.Hide();
        }

        private void dtKullaniciListesi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dtKullaniciListesi_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtKullaniciListesi.CurrentRow.Cells[2].Value.ToString() == "True")
            {
                btnKullanimİciDisi.Text = "Kullanım Dışı Yap";
            }
            else if (dtKullaniciListesi.CurrentRow.Cells[2].Value.ToString() == "False")
            {
                btnKullanimİciDisi.Text = "Kullanım İçi Yap";
            }
           // MessageBox.Show(dtKullaniciListesi.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnKullanimİciDisi_Click(object sender, EventArgs e)
        {
            DialogResult yanit;
            yanit = MessageBox.Show(dtKullaniciListesi.CurrentRow.Cells[1].Value.ToString() + " kullanıcısına işlem yapmak istiyor musunuz ?","Kullanıcı Durum",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (yanit == DialogResult.Yes)
            {
                if (btnKullanimİciDisi.Text == "Kullanım Dışı Yap")
                {
                    S_Siparisler.M_KullaniciDurumGuncelle(dtKullaniciListesi.CurrentRow.Cells[0].Value.ToString(), "False");
                    S_Siparisler.M_Kullanicilar(dtKullaniciListesi);
                }
                else if (btnKullanimİciDisi.Text == "Kullanım İçi Yap")
                {
                    S_Siparisler.M_KullaniciDurumGuncelle(dtKullaniciListesi.CurrentRow.Cells[0].Value.ToString(), "True");
                    S_Siparisler.M_Kullanicilar(dtKullaniciListesi);
                }
            }
            else if (yanit == DialogResult.No)
            {
                MessageBox.Show("İşlem Gerçekleştirilmedi","Kullanıcı Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);
                S_Siparisler.M_Kullanicilar(dtKullaniciListesi);
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult yanit;
            yanit = MessageBox.Show(dtKullaniciListesi.CurrentRow.Cells[1].Value.ToString() + " kullanıcısını silmek istiyor musunuz ?", "Kullanıcı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yanit == DialogResult.Yes)
            {
                S_Siparisler.M_KullaniciSil(dtKullaniciListesi.CurrentRow.Cells[0].Value.ToString());
                S_Siparisler.M_Kullanicilar(dtKullaniciListesi);

            }
            else if (yanit == DialogResult.No)
            {
                MessageBox.Show("Kullanıcı Silme İşlemi Gerçekleştirilmedi.","Kullanıcı Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                S_Siparisler.M_Kullanicilar(dtKullaniciListesi);
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            FrmGiris.FrmKullaniciSifreDegistir.Show();
            FrmGiris.FrmKullaniciSifreDegistir.Frm_Doldur();
            this.Hide();
        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnEkle);
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnEkle);
        }

        private void btnSifreDegistir_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnSifreDegistir);
        }

        private void btnSifreDegistir_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnSifreDegistir);
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnSil);
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnSil);
        }

        private void btnKullanimİciDisi_MouseHover(object sender, EventArgs e)
        {
            FrmGiris.Button_Hover(btnKullanimİciDisi);
        }

        private void btnKullanimİciDisi_MouseLeave(object sender, EventArgs e)
        {
            FrmGiris.Button_Leave(btnKullanimİciDisi);
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
