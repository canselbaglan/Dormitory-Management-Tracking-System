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
    public partial class Personel_OdaKayit : Form
    {
        public Personel_OdaKayit()
        {
            InitializeComponent();
        }


        public static string a;

        PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();

        public void PersonelOdaYenile()
        {

            dataGridView1.DataSource = SQL.PersonelOdaGetir();



        }

        void Temizle()
        {
            txtPersonelOdaid.Clear();
            txtOdaid.Clear();
            txtPersonelid.Clear();


        }

        private void Personel_OdaKayit_Load(object sender, EventArgs e)
        {

            txtOdaid.Clear();
            txtPersonelid.Clear();
            txtPersonelid.Text = PersonelListesi1.GidenBilgi.ToString();
            txtOdaid.Text = OdaListesi1.GidenBilgi.ToString();
            PersonelOdaYenile();
            

        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {

            PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();
            SQL.PersonelOdaEkle(Convert.ToInt32(txtPersonelid.Text), Convert.ToInt32(txtOdaid.Text));
            PersonelOdaYenile();
            Temizle();


        }

        private void btnSİL_Click(object sender, EventArgs e)
        {
            PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();
            SQL.PersonelOdaSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            PersonelOdaYenile();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();
            SQL.PersonelOdaGuncelle(Convert.ToInt32(a), Convert.ToInt32(txtPersonelid.Text), Convert.ToInt32(txtOdaid.Text));
            PersonelOdaYenile();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnPersonelListesi_Click(object sender, EventArgs e)
        {

            this.Close();
            PersonelListesi1 fr = new PersonelListesi1();
            fr.Show();
            this.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelOdaid.Text= a;
        }

        private void btnOdaListesi_Click(object sender, EventArgs e)
        {
            this.Close();
            OdaListesi1 fr = new OdaListesi1();
            fr.Show();
            this.Close();

        }

        
    }
}
