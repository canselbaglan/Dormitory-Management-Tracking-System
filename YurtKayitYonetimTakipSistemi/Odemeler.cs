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
    public partial class Odemeler : Form
    {




        public Odemeler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgln = new SqlBaglantisi();
        Odemeİslemleri SQL = new Odemeİslemleri();

       public void OdemeYenile()
        {


            dataGridView1.DataSource = SQL.OdemeGetir();




        }


       


        void Temizle()
        {

            txtOgrenciid.Clear();
            txtOdemeid.Clear();
            txtOdenecek.Clear();
            dateOdemetarih.ResetText();
            txtOdenen.Clear();




        }
        
        private void Odemeler_Load(object sender, EventArgs e)
        {
            
            OdemeYenile();
            Temizle();
            txtOgrenciid.Text = OgrenciListesi2.GidenBilgi.ToString();
            





        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            txtOdemeid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtOgrenciid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOdenecek.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateOdemetarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtOdenen.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Odemeİslemleri SQL = new Odemeİslemleri();
            SQL.OdemeEkle(Convert.ToInt32(txtOgrenciid.Text),txtOdenecek.Text, dateOdemetarih.Text, txtOdenen.Text);
            OdemeYenile();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            Odemeİslemleri SQL = new Odemeİslemleri();
            SQL.OdemeSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            OdemeYenile();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
            Odemeİslemleri SQL = new Odemeİslemleri();
            SQL.OdemeGuncelle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()),Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), txtOdenecek.Text, dateOdemetarih.Text, txtOdenen.Text);
            OdemeYenile();
            Temizle();
            

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnOgrenciListe_Click(object sender, EventArgs e)
        {
           
            OgrenciListesi2 fr = new OgrenciListesi2();
            fr.Show();
           

        }
    }



}






