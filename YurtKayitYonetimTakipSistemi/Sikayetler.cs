using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitYonetimTakipSistemi
{


    public partial class Sikayetler : Form
    {

        
        public Sikayetler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgln = new SqlBaglantisi();
        Sikayetİslemleri SQL = new Sikayetİslemleri();
        
        public void SikayetYenile()
        {

            dataGridView1.DataSource = SQL.SikayetGetir();




        }

       
       
        public void Temizle()
        {
            txtOgrenciid.Clear();
            txtSikayetid.Clear();
            txtTur.Clear();
            richtxtSikayet.Clear();
            dateTarih.ResetText();
            txtSondurum.Clear();
            txtcozum.Clear();




        }





        
        private void Sikayetler_Load(object sender, EventArgs e)
        {
           
           
            SikayetYenile();
            //Temizle();
            txtOgrenciid.Text = OgrenciListesi1.GidenBilgi.ToString();


        }



        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtSikayetid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOgrenciid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTur.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            richtxtSikayet.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTarih.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSondurum.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtcozum.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();


        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sikayetİslemleri SQL = new Sikayetİslemleri();
            SQL.SikayetEkle(Convert.ToInt32(txtOgrenciid.Text),txtTur.Text,richtxtSikayet.Text, dateTarih.Text, txtSondurum.Text, txtcozum.Text);
            SikayetYenile();
            Temizle();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sikayetİslemleri SQL = new Sikayetİslemleri();
            SQL.SikayetSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            SikayetYenile();
            Temizle();




        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           

            Sikayetİslemleri SQL = new Sikayetİslemleri();
            SQL.SikayetGuncelle(Convert.ToInt32(txtOgrenciid.Text),Convert.ToInt32(txtSikayetid.Text),txtTur.Text, richtxtSikayet.Text, dateTarih.Text, txtSondurum.Text, txtcozum.Text);
            SikayetYenile();
            Temizle();
            

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnOgrenciListe_Click(object sender, EventArgs e)
        {
            OgrenciListesi1 fr = new OgrenciListesi1();
            fr.Show();
            this.Hide();
            
        }
    }

}




