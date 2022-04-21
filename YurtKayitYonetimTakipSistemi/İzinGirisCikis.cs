using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YurtKayitYonetimTakipSistemi
{
    public partial class İzinGirisCikis : Form
    {

        SqlBaglantisi bgln = new SqlBaglantisi();
        GirisCikisİslemleri SQL = new GirisCikisİslemleri();
        public İzinGirisCikis()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            txtGiris.Clear();
            txtCikis.Clear();


        }
        public string Bilgi;
        private void GirisCikis_Load(object sender, EventArgs e)
        {
            
            GirisCikisYenile();
            Temizle();
           
            Bilgi = İzinLİstesi.GidenBilgi.ToString();
           
        }

        public void GirisCikisYenile()
        {

            dataGridView1.DataSource = SQL.GirisCikisGetir();


        }

        public string tarih;

        private void btnSuanGiris_Click(object sender, EventArgs e)
               
        {

            DateTime tarih =new DateTime();
            tarih = DateTime.Now;
            //txtGiris.Text = Convert.ToString("yyyy-mm-dd HH:mm");
            txtGiris.Text = Convert.ToString(tarih);
            
            

        }

       
        private void btnSuanCikis_Click(object sender, EventArgs e)
        {

            DateTime tarih = new DateTime();
            tarih = DateTime.Now;
            txtCikis.Text = Convert.ToString(tarih);
            

           


        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {




           
            GirisCikisİslemleri SQL = new GirisCikisİslemleri();
             
            SQL.GirisCikisEkle(Convert.ToInt32(Bilgi),txtGiris.Text,txtCikis.Text);

            GirisCikisYenile();
            Temizle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtGiris.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtCikis.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void btnOgrenciSec_Click(object sender, EventArgs e)
        {
            İzinLİstesi fr = new İzinLİstesi();
            fr.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            GirisCikisİslemleri SQL = new GirisCikisİslemleri();
            SQL.GirisCikisSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            GirisCikisYenile();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GirisCikisİslemleri SQL = new GirisCikisİslemleri();
            SQL.GirisCikisGuncelle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), txtGiris.Text, txtCikis.Text);
            GirisCikisYenile();
            Temizle();
        }

        private void İzinGirisCikis_FormClosing(object sender, FormClosingEventArgs e)
        {

            AnaSayfa frm = new AnaSayfa();
            frm.erkengecGirisCikisYenile();
            AnaSayfa frm2 = new AnaSayfa();
            frm2.Show();
        }
    }





    
    }

