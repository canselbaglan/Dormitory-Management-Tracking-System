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
    public partial class PersonelGorev : Form
    {
        public PersonelGorev()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgln = new SqlBaglantisi();

        PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();


        void Temizle()
        {

            dateTarih.ResetText();
            cmbGorev.ResetText();
            

        }
        public void PersonelOdaGorevYenile()
        {
           
            dataGridView1.DataSource = SQL.PersonelOdaGorevGetir();
           


        }

     

        public string Bilgi;
        private void PersonelGorev_Load(object sender, EventArgs e)
        {
            Temizle();
            PersonelOdaGorevYenile();
            Bilgi = PersonelOdaListe.GidenBilgi.ToString();
            
        }



      

        private void btnPersonelodaListesi_Click(object sender, EventArgs e)
        {
          
            PersonelOdaListe fr = new PersonelOdaListe();
            fr.Show();
            this.Hide();
            
            
        }

      
        private void btnEkle_Click(object sender, EventArgs e)
        {

            PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();
            
            SQL.PersonelGorevEkle(Convert.ToInt32(Bilgi), dateTarih.Text, cmbGorev.Text);
            PersonelOdaGorevYenile();
            Temizle();
            AnaSayfa fr2 = new AnaSayfa();
            fr2.Close();

        }

        private void btnSİL_Click(object sender, EventArgs e)
        {
            PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();
            SQL.PersonelGorevSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            PersonelOdaGorevYenile();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();
            SQL.PersonelGorevGuncelle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),dateTarih.Text, cmbGorev.Text);
            PersonelOdaGorevYenile();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void PersonelGorev_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            AnaSayfa frm = new AnaSayfa();
            frm.PersonelGorevYenile();
            AnaSayfa frm2 = new AnaSayfa();
            frm2.Show();
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTarih.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbGorev.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }


}
