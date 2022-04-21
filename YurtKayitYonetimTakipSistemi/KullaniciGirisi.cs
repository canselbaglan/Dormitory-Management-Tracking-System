using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitYonetimTakipSistemi
{
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgln = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand("select * from Yonetici where YoneticiAd=@YoneticiAd and YoneticiSifre=@YoneticiSifre", bgln.baglanti());
            komut.Parameters.AddWithValue("@YoneticiAd",txtKullanici.Text);
            komut.Parameters.AddWithValue("@YoneticiSifre",txtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                AnaSayfa fr = new AnaSayfa();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı yada Şifre!");
                txtKullanici.Clear();
                txtSifre.Clear();
                txtKullanici.Focus();


            }

            bgln.baglanti().Close();





        }

        
    }
}
