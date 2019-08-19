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
    public static class S_Siparisler
    {
        public static void M_SiparisSayaci(TextBox txtSiparisSayaci)
        {
            S_Baglanti.Baglantim.Open();
            S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
            S_Baglanti.Komutum.CommandText = "select * from tblSayaclar";
            S_Baglanti.Okuyucum = S_Baglanti.Komutum.ExecuteReader();
            while (S_Baglanti.Okuyucum.Read())
            {
                //VrCmbMalzemeGruplari.Items.Add(S_Baglanti.Okuyucum[2].ToString());
                txtSiparisSayaci.Text = S_Baglanti.Okuyucum[1].ToString();
            }
            S_Baglanti.Baglantim.Close();
            S_Baglanti.Okuyucum.Close();
        }
        public static void M_AlinacakSiparisler(DataGridView dt_AlinacakSiparisler)
        {
            S_Baglanti.Tablom = new DataTable();
            S_Baglanti.Tablom.Clear();
            S_Baglanti.Baglantim.Open();
            S_Baglanti.Adapterim = new SqlDataAdapter("exec p_AlinacakSiparisler", S_Baglanti.Baglantim);
            S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
            dt_AlinacakSiparisler.DataSource = S_Baglanti.Tablom;
            dt_AlinacakSiparisler.Columns[0].HeaderText = "Id";
            dt_AlinacakSiparisler.Columns[1].HeaderText = "Sipariş Veren";
            dt_AlinacakSiparisler.Columns[2].HeaderText = "Adres";
            dt_AlinacakSiparisler.Columns[3].HeaderText = "Ev Tel";
            dt_AlinacakSiparisler.Columns[4].HeaderText = "Cep Tel";
            dt_AlinacakSiparisler.Columns[5].HeaderText = "Metre Kare";
            dt_AlinacakSiparisler.Columns[6].HeaderText = "Sipariş Notu";
            S_Baglanti.Baglantim.Close();

        }

        public static void M_AlinacakSiparislerEkle(string vr_SiparisVeren,string vr_Adres,string vr_EvTel,string vr_CepTel,int vr_MetreKare,string vr_SiparisNotu)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_AlinacakSiparisEkle @dr_siparisveren='" + vr_SiparisVeren + "',@dr_Adres='" + vr_Adres + "',@dr_evtel = '" + vr_EvTel + "',@dr_ceptel='" + vr_CepTel + "',@dr_metrekare='" + vr_MetreKare + "',@dr_siparisnotu='" + vr_SiparisNotu + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Sipariş Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Ekleme de Hata" + e_mesaj);
            }
        }
        public static void p_AlinacakSiparisGuncelle(int vr_id, string vr_SiparisVeren, string vr_Adres, string vr_EvTel, string vr_CepTel, int vr_MetreKare, string vr_SiparisNotu)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_AlinacakSiparisGuncelle @dr_id = '"+vr_id+"', @dr_siparisveren='" + vr_SiparisVeren + "',@dr_Adres='" + vr_Adres + "',@dr_evtel = '" + vr_EvTel + "',@dr_ceptel='" + vr_CepTel + "',@dr_metrekare='" + vr_MetreKare + "',@dr_siparisnotu='" + vr_SiparisNotu + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Sipariş Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Güncelleme de Hata" + e_mesaj);
            }
        }
        public static void M_AlinacakSiparisSil(int vr_id)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "Exec p_AlinacakSiparisSil @dr_id = '" + vr_id + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Silme de Hata" + e_mesaj);
            }
        }

        public static void M_TeslimAlindi(int vr_SiparisNo,string vr_SiparisVeren,string vr_Adres,string vr_EvTel,string vr_CepTel,int vr_MetreKare,string vr_SiparisNotu, string vr_AlinacakUcret,string vr_SiparisTarihi)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_SiparisEkle @dr_siparisno = '"+vr_SiparisNo+ "',@dr_siparisveren='"+vr_SiparisVeren+ "',@dr_adres='"+vr_Adres+ "',@dr_evtel='"+vr_EvTel+ "',@dr_ceptel='"+vr_CepTel+ "',@dr_metrekare='"+vr_MetreKare+ "',@dr_siparisnotu='"+vr_SiparisNotu+ "',@dr_AlinacakUcret='"+vr_AlinacakUcret+ "',@dr_siparistarihi='"+vr_SiparisTarihi+ "',@dr_siparisdurumu='Yıkanacak'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Sipariş Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Ekleme de Hata" + e_mesaj);
            }
        }

        public static void M_Siparisler(DataGridView dt_Siparisler)
        {
            S_Baglanti.Tablom = new DataTable();
            S_Baglanti.Tablom.Clear();
            S_Baglanti.Baglantim.Open();
            S_Baglanti.Adapterim = new SqlDataAdapter("exec p_Siparisler", S_Baglanti.Baglantim);
            S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
            dt_Siparisler.DataSource = S_Baglanti.Tablom;
            dt_Siparisler.Columns[0].HeaderText = "Sipariş Numarası";
            dt_Siparisler.Columns[1].HeaderText = "Sipariş Veren";
            dt_Siparisler.Columns[2].HeaderText = "Adres";
            dt_Siparisler.Columns[3].HeaderText = "Ev Tel";
            dt_Siparisler.Columns[4].HeaderText = "Cep Tel";
            dt_Siparisler.Columns[5].HeaderText = "Metre Kare";
            dt_Siparisler.Columns[6].HeaderText = "Sipariş Notu";
            dt_Siparisler.Columns[7].HeaderText = "Alınacak Ücret";
            dt_Siparisler.Columns[8].HeaderText = "Sipariş Tarihi";
            dt_Siparisler.Columns[9].HeaderText = "Sipariş Durumu";
            S_Baglanti.Baglantim.Close();

        }
        public static void M_SiparisGuncelle(int vr_SiparisNo, string vr_SiparisVeren, string vr_Adres, string vr_EvTel, string vr_CepTel, int vr_MetreKare, string vr_SiparisNotu, string vr_AlinacakUcret, string vr_SiparisTarihi)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_SiparisGuncelle @dr_siparisno = '" + vr_SiparisNo + "',@dr_siparisveren='" + vr_SiparisVeren + "',@dr_adres='" + vr_Adres + "',@dr_evtel='" + vr_EvTel + "',@dr_ceptel='" + vr_CepTel + "',@dr_metrekare='" + vr_MetreKare + "',@dr_siparisnotu='" + vr_SiparisNotu + "',@dr_AlinacakUcret='" + vr_AlinacakUcret + "',@dr_siparistarihi='" + vr_SiparisTarihi + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Sipariş Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Güncelleme de Hata" + e_mesaj);
            }
        }

        public static void M_SiparisSil(int vr_SiparisNo)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_SiparisSil @dr_siparisno = '" + vr_SiparisNo + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Sipariş Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Silme de Hata" + e_mesaj);
            }
        }

        public static void M_SiparisDurumGuncelleme(int vr_SiparisNo, string vr_siparisdurumu)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_SiparisDurumGuncelle @dr_siparisno = '" + vr_SiparisNo + "',@dr_siparisdurumu='"+vr_siparisdurumu+"'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Sipariş Durum Güncellendi.", "Durum Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Durum Güncelleme de Hata" + e_mesaj);
            }
        }
        public static void M_Dagitimlar(DataGridView dt_Dagitimlar)
        {
            S_Baglanti.Tablom = new DataTable();
            S_Baglanti.Tablom.Clear();
            S_Baglanti.Baglantim.Open();
            S_Baglanti.Adapterim = new SqlDataAdapter("exec p_Dagitimlar", S_Baglanti.Baglantim);
            S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
            dt_Dagitimlar.DataSource = S_Baglanti.Tablom;
            dt_Dagitimlar.Columns[0].HeaderText = "Sipariş Numarası";
            dt_Dagitimlar.Columns[1].HeaderText = "Sipariş Veren";
            dt_Dagitimlar.Columns[2].HeaderText = "Adres";
            dt_Dagitimlar.Columns[3].HeaderText = "Ev Tel";
            dt_Dagitimlar.Columns[4].HeaderText = "Cep Tel";
            dt_Dagitimlar.Columns[5].HeaderText = "Metre Kare";
            dt_Dagitimlar.Columns[6].HeaderText = "Sipariş Notu";
            dt_Dagitimlar.Columns[7].HeaderText = "Alınacak Ücret";
            dt_Dagitimlar.Columns[8].HeaderText = "Sipariş Tarihi";
            dt_Dagitimlar.Columns[9].HeaderText = "Sipariş Durumu";
            S_Baglanti.Baglantim.Close();

        }
        public static void M_DagitimaGonder(int vr_SiparisNo, string vr_SiparisVeren, string vr_Adres, string vr_EvTel, string vr_CepTel, int vr_MetreKare, string vr_SiparisNotu,string vr_AlinacakUcret,string vr_SiparisTarihi)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_DagitimEkle @dr_siparisno = '" + vr_SiparisNo + "',@dr_siparisveren='" + vr_SiparisVeren + "',@dr_adres='" + vr_Adres + "',@dr_evtel='" + vr_EvTel + "',@dr_ceptel='" + vr_CepTel + "',@dr_metrekare='" + vr_MetreKare + "',@dr_siparisnotu='" + vr_SiparisNotu + "',@dr_AlinacakUcret='"+vr_AlinacakUcret+"',@dr_siparistarihi='"+vr_SiparisTarihi+"',@dr_siparisdurumu='Dağıtım Planı Yapılacak'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Sipariş Dağıtıma Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Ekleme de Hata" + e_mesaj);
            }
        }
        public static void M_DagitimGuncelle(int vr_SiparisNo, string vr_SiparisVeren, string vr_Adres, string vr_EvTel, string vr_CepTel, int vr_MetreKare, string vr_SiparisNotu, string vr_AlinacakUcret, DateTimePicker vr_SiparisTarihi)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_DagitimGuncelle @dr_siparisno = '" + vr_SiparisNo + "',@dr_siparisveren='" + vr_SiparisVeren + "',@dr_adres='" + vr_Adres + "',@dr_evtel='" + vr_EvTel + "',@dr_ceptel='" + vr_CepTel + "',@dr_metrekare='" + vr_MetreKare + "',@dr_siparisnotu='" + vr_SiparisNotu + "',@dr_AlinacakUcret='" + vr_AlinacakUcret + "',@dr_siparistarihi='" + vr_SiparisTarihi.Value.ToString("MM/dd/yyyy") + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Dağıtım Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Güncelleme de Hata" + e_mesaj);
            }
        }
        public static void M_DagitimDurumGuncelleme(int vr_SiparisNo, string vr_siparisdurumu)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_DagitimDurumGuncelle @dr_siparisno = '" + vr_SiparisNo + "',@dr_siparisdurumu='" + vr_siparisdurumu + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Dağıtım Durumu Güncellendi.", "Durum Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Durum Güncelleme de Hata" + e_mesaj);
            }
        }

        public static void M_Teslimler(DataGridView dt_Teslimler)
        {
            S_Baglanti.Tablom = new DataTable();
            S_Baglanti.Tablom.Clear();
            S_Baglanti.Baglantim.Open();
            S_Baglanti.Adapterim = new SqlDataAdapter("exec p_Teslimler", S_Baglanti.Baglantim);
            S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
            dt_Teslimler.DataSource = S_Baglanti.Tablom;
            dt_Teslimler.Columns[0].HeaderText = "Sipariş Numarası";
            dt_Teslimler.Columns[1].HeaderText = "Sipariş Veren";
            dt_Teslimler.Columns[2].HeaderText = "Adres";
            dt_Teslimler.Columns[3].HeaderText = "Ev Tel";
            dt_Teslimler.Columns[4].HeaderText = "Cep Tel";
            dt_Teslimler.Columns[5].HeaderText = "MetreKare";
            dt_Teslimler.Columns[6].HeaderText = "Alınan Ücret";
            dt_Teslimler.Columns[7].HeaderText = "Sipariş  Tarihi";
            dt_Teslimler.Columns[8].HeaderText = "Teslim  Tarihi";
            S_Baglanti.Baglantim.Close();

        }



        public static void M_TeslimatiTamamla(int vr_SiparisNo, string vr_SiparisVeren, string vr_Adres, string vr_EvTel, string vr_CepTel, int vr_MetreKare,string vr_AlinanUcret, string vr_SiparisTarihi, string vr_TeslimTarihi)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_TeslimatEkle @dr_siparisno = '" + vr_SiparisNo + "',@dr_siparisveren='" + vr_SiparisVeren + "',@dr_adres='" + vr_Adres + "',@dr_evtel='" + vr_EvTel + "',@dr_ceptel='" + vr_CepTel + "',@dr_metrekare='" + vr_MetreKare + "',@dr_alinanucret='" + vr_AlinanUcret + "',@dr_siparistarihi='" + vr_SiparisTarihi + "',@dr_teslimtarihi='"+ vr_TeslimTarihi + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Sipariş Teslimatı Tamamlandı", "Teslimat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Teslim de Hata" + e_mesaj);
            }
        }

        public static void M_GelirGiderler(DataGridView dt_GelirGiderler,string vr_Secim)
        {
            S_Baglanti.Tablom = new DataTable();
            S_Baglanti.Tablom.Clear();
            S_Baglanti.Baglantim.Open();
            S_Baglanti.Adapterim = new SqlDataAdapter("exec p_GelirGiderler @dr_secim = '"+vr_Secim+"'", S_Baglanti.Baglantim);
            S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
            dt_GelirGiderler.DataSource = S_Baglanti.Tablom;
            dt_GelirGiderler.Columns[0].HeaderText = "Fiş Numarası";
            dt_GelirGiderler.Columns[1].HeaderText = "Fiş Tarihi";
            dt_GelirGiderler.Columns[2].HeaderText = "Fiş Açıklaması";
            dt_GelirGiderler.Columns[3].HeaderText = "Fiş Tutarı";
            dt_GelirGiderler.Columns[4].HeaderText = "Alacak-Borç";
            S_Baglanti.Baglantim.Close();

        }

        public static void M_GelirGiderEkle(string vr_FisTarihi,string vr_FisAciklamasi,string vr_FisTutari,string vr_GelirGider)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_GelirGiderEkle @dr_FisTarihi='" + vr_FisTarihi + "',@dr_FisAciklamasi='" + vr_FisAciklamasi + "',@dr_FisTutari = '" + vr_FisTutari + "',@dr_GelirGider='" + vr_GelirGider + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Fiş Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Ekleme de Hata" + e_mesaj);
            }
        }

        public static void M_GelirGiderGuncelle(int vr_FisNo,string vr_FisTarihi, string vr_FisAciklamasi, string vr_FisTutari, string vr_GelirGider)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_GelirGiderGuncelle  @dr_FisNo='"+vr_FisNo+"' ,@dr_FisTarihi='" + vr_FisTarihi + "',@dr_FisAciklamasi='" + vr_FisAciklamasi + "',@dr_FisTutari = '" + vr_FisTutari + "',@dr_GelirGider='" + vr_GelirGider + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Fiş Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Güncelleme de Hata" + e_mesaj);
            }
        }

        public static void M_GelirGiderSil(int vr_FisNo)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_GelirGiderSil  @dr_FisNo='" + vr_FisNo + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Fiş Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Silme de Hata" + e_mesaj);
            }
        }

        public static void M_SiparislerFiltre(DataGridView dt_Siparisler,string vr_Filtreİsmi,string vr_FiltreDegeri)
        {

            if (vr_Filtreİsmi == "txtSiparisNo")
            {
                S_Baglanti.Tablom = new DataTable();
                S_Baglanti.Tablom.Clear();
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Adapterim = new SqlDataAdapter("select * from tblSiparisler Where SiparisNo='" + vr_FiltreDegeri + "'", S_Baglanti.Baglantim);
                S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
                dt_Siparisler.DataSource = S_Baglanti.Tablom;
                dt_Siparisler.Columns[0].HeaderText = "Sipariş Numarası";
                dt_Siparisler.Columns[1].HeaderText = "Sipariş Veren";
                dt_Siparisler.Columns[2].HeaderText = "Adres";
                dt_Siparisler.Columns[3].HeaderText = "Ev Tel";
                dt_Siparisler.Columns[4].HeaderText = "Cep Tel";
                dt_Siparisler.Columns[5].HeaderText = "Metre Kare";
                dt_Siparisler.Columns[6].HeaderText = "Sipariş Notu";
                dt_Siparisler.Columns[7].HeaderText = "Alınacak Ücret";
                dt_Siparisler.Columns[8].HeaderText = "Sipariş Tarihi";
                dt_Siparisler.Columns[9].HeaderText = "Sipariş Durumu";
                S_Baglanti.Baglantim.Close();
            }
            else if (vr_Filtreİsmi == "txtSiparisVeren")
            {
                S_Baglanti.Tablom = new DataTable();
                S_Baglanti.Tablom.Clear();
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Adapterim = new SqlDataAdapter("select * from tblSiparisler Where SiparisVeren Like '%"+vr_FiltreDegeri+"%'", S_Baglanti.Baglantim);
                S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
                dt_Siparisler.DataSource = S_Baglanti.Tablom;
                dt_Siparisler.Columns[0].HeaderText = "Sipariş Numarası";
                dt_Siparisler.Columns[1].HeaderText = "Sipariş Veren";
                dt_Siparisler.Columns[2].HeaderText = "Adres";
                dt_Siparisler.Columns[3].HeaderText = "Ev Tel";
                dt_Siparisler.Columns[4].HeaderText = "Cep Tel";
                dt_Siparisler.Columns[5].HeaderText = "Metre Kare";
                dt_Siparisler.Columns[6].HeaderText = "Sipariş Notu";
                dt_Siparisler.Columns[7].HeaderText = "Alınacak Ücret";
                dt_Siparisler.Columns[8].HeaderText = "Sipariş Tarihi";
                dt_Siparisler.Columns[9].HeaderText = "Sipariş Durumu";
                S_Baglanti.Baglantim.Close();
            }

            else if (vr_Filtreİsmi == "cmbDurumFiltre")
            {
                S_Baglanti.Tablom = new DataTable();
                S_Baglanti.Tablom.Clear();
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Adapterim = new SqlDataAdapter("select * from tblSiparisler Where SiparisDurumu='" + vr_FiltreDegeri + "'", S_Baglanti.Baglantim);
                S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
                dt_Siparisler.DataSource = S_Baglanti.Tablom;
                dt_Siparisler.Columns[0].HeaderText = "Sipariş Numarası";
                dt_Siparisler.Columns[1].HeaderText = "Sipariş Veren";
                dt_Siparisler.Columns[2].HeaderText = "Adres";
                dt_Siparisler.Columns[3].HeaderText = "Ev Tel";
                dt_Siparisler.Columns[4].HeaderText = "Cep Tel";
                dt_Siparisler.Columns[5].HeaderText = "Metre Kare";
                dt_Siparisler.Columns[6].HeaderText = "Sipariş Notu";
                dt_Siparisler.Columns[7].HeaderText = "Alınacak Ücret";
                dt_Siparisler.Columns[8].HeaderText = "Sipariş Tarihi";
                dt_Siparisler.Columns[9].HeaderText = "Sipariş Durumu";
                S_Baglanti.Baglantim.Close();

            }
           

        }

        public static void M_DagitimlarFiltre(DataGridView dt_Dagitimlar, string vr_Filtreİsmi, string vr_FiltreDegeri)
        {

            if (vr_Filtreİsmi == "txtSiparisNo")
            {
                S_Baglanti.Tablom = new DataTable();
                S_Baglanti.Tablom.Clear();
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Adapterim = new SqlDataAdapter("select * from tblDagitimlar Where SiparisNo='" + vr_FiltreDegeri + "'", S_Baglanti.Baglantim);
                S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
                dt_Dagitimlar.DataSource = S_Baglanti.Tablom;
                dt_Dagitimlar.Columns[0].HeaderText = "Sipariş Numarası";
                dt_Dagitimlar.Columns[1].HeaderText = "Sipariş Veren";
                dt_Dagitimlar.Columns[2].HeaderText = "Adres";
                dt_Dagitimlar.Columns[3].HeaderText = "Ev Tel";
                dt_Dagitimlar.Columns[4].HeaderText = "Cep Tel";
                dt_Dagitimlar.Columns[5].HeaderText = "Metre Kare";
                dt_Dagitimlar.Columns[6].HeaderText = "Sipariş Notu";
                dt_Dagitimlar.Columns[7].HeaderText = "Alınacak Ücret";
                dt_Dagitimlar.Columns[8].HeaderText = "Sipariş Tarihi";
                dt_Dagitimlar.Columns[9].HeaderText = "Sipariş Durumu";
                S_Baglanti.Baglantim.Close();
            }
            else if (vr_Filtreİsmi == "txtSiparisVeren")
            {
                S_Baglanti.Tablom = new DataTable();
                S_Baglanti.Tablom.Clear();
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Adapterim = new SqlDataAdapter("select * from tblDagitimlar Where SiparisVeren Like '%" + vr_FiltreDegeri + "%'", S_Baglanti.Baglantim);
                S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
                dt_Dagitimlar.DataSource = S_Baglanti.Tablom;
                dt_Dagitimlar.Columns[0].HeaderText = "Sipariş Numarası";
                dt_Dagitimlar.Columns[1].HeaderText = "Sipariş Veren";
                dt_Dagitimlar.Columns[2].HeaderText = "Adres";
                dt_Dagitimlar.Columns[3].HeaderText = "Ev Tel";
                dt_Dagitimlar.Columns[4].HeaderText = "Cep Tel";
                dt_Dagitimlar.Columns[5].HeaderText = "Metre Kare";
                dt_Dagitimlar.Columns[6].HeaderText = "Sipariş Notu";
                dt_Dagitimlar.Columns[7].HeaderText = "Alınacak Ücret";
                dt_Dagitimlar.Columns[8].HeaderText = "Sipariş Tarihi";
                dt_Dagitimlar.Columns[9].HeaderText = "Sipariş Durumu";
                S_Baglanti.Baglantim.Close();
            }

            else if (vr_Filtreİsmi == "cmbDurumFiltre")
            {
                S_Baglanti.Tablom = new DataTable();
                S_Baglanti.Tablom.Clear();
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Adapterim = new SqlDataAdapter("select * from tblDagitimlar Where SiparisDurumu='" + vr_FiltreDegeri + "'", S_Baglanti.Baglantim);
                S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
                dt_Dagitimlar.DataSource = S_Baglanti.Tablom;
                dt_Dagitimlar.Columns[0].HeaderText = "Sipariş Numarası";
                dt_Dagitimlar.Columns[1].HeaderText = "Sipariş Veren";
                dt_Dagitimlar.Columns[2].HeaderText = "Adres";
                dt_Dagitimlar.Columns[3].HeaderText = "Ev Tel";
                dt_Dagitimlar.Columns[4].HeaderText = "Cep Tel";
                dt_Dagitimlar.Columns[5].HeaderText = "Metre Kare";
                dt_Dagitimlar.Columns[6].HeaderText = "Sipariş Notu";
                dt_Dagitimlar.Columns[7].HeaderText = "Alınacak Ücret";
                dt_Dagitimlar.Columns[8].HeaderText = "Sipariş Tarihi";
                dt_Dagitimlar.Columns[9].HeaderText = "Sipariş Durumu";
                S_Baglanti.Baglantim.Close();

            }


        }

        public static void M_GelirGiderlerFiltre(DataGridView dt_GelirGiderler, string vr_Filtreİsmi, string vr_FiltreDegeri,string vr_FiltreDegeri2)
        {
            if (vr_Filtreİsmi == "txtFisNo")
            {
                S_Baglanti.Tablom = new DataTable();
                S_Baglanti.Tablom.Clear();
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Adapterim = new SqlDataAdapter("Select * From tblGelirGider Where FisNo = '" + vr_FiltreDegeri + "'", S_Baglanti.Baglantim);
                S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
                dt_GelirGiderler.DataSource = S_Baglanti.Tablom;
                dt_GelirGiderler.Columns[0].HeaderText = "Fiş Numarası";
                dt_GelirGiderler.Columns[1].HeaderText = "Fiş Tarihi";
                dt_GelirGiderler.Columns[2].HeaderText = "Fiş Açıklaması";
                dt_GelirGiderler.Columns[3].HeaderText = "Fiş Tutarı";
                dt_GelirGiderler.Columns[4].HeaderText = "Alacak-Borç";
                S_Baglanti.Baglantim.Close();
            }
            else if (vr_Filtreİsmi == "dtFisTarihi1")
            {
                S_Baglanti.Tablom = new DataTable();
                S_Baglanti.Tablom.Clear();
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Adapterim = new SqlDataAdapter("Select * From tblGelirGider Where FisTarihi Between '"+vr_FiltreDegeri+"' And '"+vr_FiltreDegeri2+"'", S_Baglanti.Baglantim);
                S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
                dt_GelirGiderler.DataSource = S_Baglanti.Tablom;
                dt_GelirGiderler.Columns[0].HeaderText = "Fiş Numarası";
                dt_GelirGiderler.Columns[1].HeaderText = "Fiş Tarihi";
                dt_GelirGiderler.Columns[2].HeaderText = "Fiş Açıklaması";
                dt_GelirGiderler.Columns[3].HeaderText = "Fiş Tutarı";
                dt_GelirGiderler.Columns[4].HeaderText = "Alacak-Borç";
                S_Baglanti.Baglantim.Close();
            }
           

        }

        public static void M_GelirGiderToplamı(TextBox Vr_GelirGiderKaydi,string vr_AlacakBorc)
        {
            try
            {
                Vr_GelirGiderKaydi.Text = "";
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "select SUM(CAST(FisTutari AS float)) From tblGelirGider WHERE GelirGider = '"+vr_AlacakBorc+"'";
                S_Baglanti.Okuyucum = S_Baglanti.Komutum.ExecuteReader();
                while (S_Baglanti.Okuyucum.Read())
                {
                    Vr_GelirGiderKaydi.Text = S_Baglanti.Okuyucum[0].ToString();
                }
                S_Baglanti.Baglantim.Close();
                S_Baglanti.Okuyucum.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show(e_mesaj.ToString());
            }
        }

        public static void M_Kullanicilar(DataGridView dt_Kullanicilar)
        {
            S_Baglanti.Tablom = new DataTable();
            S_Baglanti.Tablom.Clear();
            S_Baglanti.Baglantim.Open();
            S_Baglanti.Adapterim = new SqlDataAdapter("exec p_Kullanicilar", S_Baglanti.Baglantim);
            S_Baglanti.Adapterim.Fill(S_Baglanti.Tablom);
            dt_Kullanicilar.DataSource = S_Baglanti.Tablom;
            dt_Kullanicilar.Columns[0].HeaderText = "Id";
            dt_Kullanicilar.Columns[1].HeaderText = "Kullanıcı Adı";
            dt_Kullanicilar.Columns[2].HeaderText = "Kullanıcı Durumu";
            dt_Kullanicilar.Columns[3].HeaderText = "Personel Adı Soyadı";
            S_Baglanti.Baglantim.Close();

        }

        public static void M_KullaniciEkle(string vr_KullaniciAdi, string vr_Sifre, string vr_KullaniciDurum, string vr_PersonelAdiSoyadi)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "exec p_KullaniciEkle @dr_kullaniciAdi='" + vr_KullaniciAdi + "',@dr_sifre='" + vr_Sifre + "',@dr_kullaniciDurum = '" + vr_KullaniciDurum + "',@dr_personelAdiSoyadi='" + vr_PersonelAdiSoyadi + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Ekleme de Hata" + e_mesaj);
            }
        }

        public static void M_KullaniciDurumGuncelle(string vr_id,string vr_KullaniciDurum)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "Update tblKullanicilar Set Kullanici_Durum ='"+vr_KullaniciDurum+"' Where id = '"+vr_id+"'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Durum Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Güncelleme de Hata" + e_mesaj);
            }
        }

        public static void M_KullaniciSil(string vr_id)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "Delete From tblKullanicilar Where id = '" + vr_id + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Silme de Hata" + e_mesaj);
            }
        }

        public static void M_KullaniciSifreGuncelle(string vr_id, string vr_Sifre)
        {
            try
            {
                S_Baglanti.Baglantim.Open();
                S_Baglanti.Komutum.Connection = S_Baglanti.Baglantim;
                S_Baglanti.Komutum.CommandText = "Update tblKullanicilar Set Sifre ='" + vr_Sifre + "' Where id = '" + vr_id + "'";
                S_Baglanti.Komutum.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Şifre Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                S_Baglanti.Baglantim.Close();
            }
            catch (Exception e_mesaj)
            {

                MessageBox.Show("Güncelleme de Hata" + e_mesaj);
            }
        }

    }
}
