using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Hali_Yıkama_Takibi
{
    public static class S_Baglanti
    {
        //public static SqlConnection Baglantim = new SqlConnection(@"Data Source=SEZGINNOTE;Initial Catalog=DBHaliYikamaTakibi;Integrated Security=True");
        public static SqlConnection Baglantim = new SqlConnection(@"Data Source=.;Initial Catalog=DBHaliYikamaTakibi;Integrated Security=True");
        public static SqlCommand Komutum = new SqlCommand();
        public static SqlDataAdapter Adapterim;
        public static SqlDataReader Okuyucum;
        public static DataTable Tablom = new DataTable();
        private static int G_Hak = 3;

        public static void BaglantiTest()
        {
        SqlConnection test = new SqlConnection(@"Data Source=.;Initial Catalog=DBHaliYikamaTakibi;Integrated Security=True");
            test.Open();
            MessageBox.Show("Veritabanına Bağlantı Sağlandı...");
            test.Close();
        }

        public static void M_Giris(string VrKullaniciAdi, string VrSifre, Form Frm_Giris, Form Frm_Gizle)
        {
            Baglantim.Open();
            Komutum.Connection = Baglantim;
            Komutum.CommandText = "Select * From tblKullanicilar Where Kullanici_Adi = '" + VrKullaniciAdi + "' And Sifre = '" + VrSifre + "'";
            Okuyucum = Komutum.ExecuteReader();
            if (Okuyucum.Read())
            {
                if (Okuyucum[3].ToString() == "True")
                {
                    MessageBox.Show("Kullanıcı Girişi Başarıyla Gerçekleştirildi.", "Sisteme Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_Giris.Show();
                    Frm_Gizle.Hide();
                }
                else if (Okuyucum[3].ToString() == "False")
                {

                    MessageBox.Show("Kullanıcı Kullanım Dışı Olduğundan Giriş Gerçekleştiremez. Programdan Çıkış Yapılacak.", "Sisteme Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }


            }
            else
            {
                G_Hak = G_Hak - 1;
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girişi Kalan Giriş Hakkınız : " + G_Hak, "Sisteme Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (G_Hak == 0)
                {
                    MessageBox.Show("Sisteme 3 Kez Hatalı Giriş Gerçekleştirdiniz. Program Kapatılacaktır.", "Sisteme Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            Baglantim.Close();

        }
    }
}
