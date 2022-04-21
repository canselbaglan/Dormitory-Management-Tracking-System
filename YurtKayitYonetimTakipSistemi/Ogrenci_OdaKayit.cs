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
    public partial class Ogrenci_OdaKayit : Form
    {
        public Ogrenci_OdaKayit()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgln = new SqlBaglantisi();
        


        void Temizle()
        {

            txtOgrenciid.Clear();
            txtOdaid.Clear();
            txtOgrenciOdaid.Clear();


        }

        OgrenciOdaİslemleri SQL = new OgrenciOdaİslemleri();



        public void OgrenciOdaYenile()
        {

            dataGridView1.DataSource = SQL.OgrenciOdaGetir();



        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciOdaid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOgrenciid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOdaid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        //public string  OdaBilgi;

        private void Ogrenci_OdaKayit_Load(object sender, EventArgs e)
        {
            Ogrenciİslemleri SQL = new Ogrenciİslemleri();
            OgrenciOdaYenile();
            txtOgrenciid.Text = OgrenciListesi3.GidenBilgi.ToString();
            txtOdaid.Text = OdaListesi2.GidenBilgi.ToString();
            //Temizle();
            //OdaBilgi= OdaListesi2.GidenBilgi2.ToString();
        }

       


        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgrenciOdaİslemleri SQL = new OgrenciOdaİslemleri();
            SQL.OgrenciOdaEkle(Convert.ToInt32(txtOgrenciid.Text), Convert.ToInt32(txtOdaid.Text));
            SQL.OdaAktifArttir(Convert.ToInt32(OdaListesi2.GidenBilgi.ToString()));
            OgrenciOdaYenile();
            Temizle();





        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            OgrenciOdaİslemleri SQL = new OgrenciOdaİslemleri();
            SQL.OgrenciOdaSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            SQL.OdaAktifAzalt(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            OgrenciOdaYenile();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            OgrenciOdaİslemleri SQL = new OgrenciOdaİslemleri();
            SQL.OgrenciOdaGuncelle(Convert.ToInt32(txtOgrenciOdaid.Text), Convert.ToInt32(txtOgrenciid.Text), Convert.ToInt32(txtOdaid.Text));
            OgrenciOdaYenile();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnOgrenciSec_Click(object sender, EventArgs e)
        {
            OgrenciListesi3 fr = new OgrenciListesi3();
            fr.Show();
            this.Close();

        }

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            OdaListesi2 fr = new OdaListesi2();
            fr.Show();
            this.Close();
         
        }

        

        
    }
    




}
