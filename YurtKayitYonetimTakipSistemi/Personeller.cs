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
    public partial class Personeller : Form
    {

        

        public Personeller()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgln = new SqlBaglantisi();
        Personelİslemleri SQL = new Personelİslemleri();

        public void PersonelYenile()
           {

            dataGridView1.DataSource = SQL.PersonelGetir();



        }
        /*
        void OdaGetir()
        {

            SqlBaglantisi bgln = new SqlBaglantisi();

            String Sorgu = "select OdaNo from Odalar";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbOdaNO2.Items.Add(read[0].ToString());

            }
            bgln.baglanti().Close();




        }

        */


        void Temizle()
        {

            txtPersonelid.Clear();
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            txtTc.Clear();
            txtMail.Clear();
            cmbİl.ResetText();
            txtTel.Clear();
            txtMaas.Clear();
            txtDogumTarih.Clear();
            cmbCinsiyet.ResetText();
            dateIseGiris.ResetText();
            dateIstenCıkıs.ResetText();
            cmbPersoneldurum.ResetText();


        }



        private void Personeller_Load(object sender, EventArgs e)
        {

            PersonelYenile();
            //OdaGetir();
            Temizle();
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtPersonelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPersonelSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbİl.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtDogumTarih.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            dateIseGiris.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            dateIstenCıkıs.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            cmbPersoneldurum.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
            
        {

            Personelİslemleri SQL = new Personelİslemleri();
            SQL.PersonelEkle(txtPersonelAd.Text,txtPersonelSoyad.Text,txtTc.Text, txtMail.Text, cmbİl.Text, txtMaas.Text, txtTel.Text, txtDogumTarih.Text, cmbCinsiyet.Text, dateIseGiris.Text, dateIstenCıkıs.Text, cmbPersoneldurum.Text);
            PersonelYenile();
            Temizle();
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personelİslemleri SQL = new Personelİslemleri();
            SQL.PersonelSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            PersonelYenile();
            Temizle();



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Personelİslemleri SQL = new Personelİslemleri();
            SQL.PersonelGuncelle(Convert.ToInt32(txtPersonelid.Text),txtPersonelAd.Text,txtPersonelSoyad.Text,txtTc.Text,txtMail.Text,cmbİl.Text, txtMaas.Text, txtTel.Text, txtDogumTarih.Text, cmbCinsiyet.Text, dateIseGiris.Text, dateIstenCıkıs.Text, cmbPersoneldurum.Text);
            
            bgln.baglanti().Close();
            PersonelYenile();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }



}



