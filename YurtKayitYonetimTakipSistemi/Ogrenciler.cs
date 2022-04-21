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
    public partial class Ogrenciler : Form
    {
      


        

        public Ogrenciler()
        {
            InitializeComponent();
        }

        Ogrenciİslemleri SQL = new Ogrenciİslemleri();
     
        SqlBaglantisi bgln = new SqlBaglantisi();


       






        //Boş oda  bilgilerini güncel olarak combobaxa  getirebilmek için


        public void OgrenciYenile()
        {
            dataGridView.DataSource = SQL.OgrenciGetir();
        }







        //txt mskdtxt ...araçlardaki bilgilerin temizlenmesi için
        void Temizle()
        {
           
            txtid.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            mskdtxtTc.Clear();
            mskdtxtTel.Clear();
            txtMail.Clear();
            mskdtxtDogumTarih.Clear();
            cmbDogumYer.ResetText();
            txtBolum.Clear();
            dateGirisTarih.ResetText();
            txtVeliAd.Clear();
            txtVeliSoyad.Clear();
            mskdtxtVeliTel1.Clear();
            mskdtxtVeliTel2.Clear();
            rchtxtAdres.Clear();

        }

        
        

        
        private void Ogrenciler_Load(object sender, EventArgs e)

        {
            
            OgrenciYenile();//verilerin form açıldığında  son halinin gelmesi için
            Temizle();//Araç kutusu elemanlarının temizlenmesi için


        }



        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            dateGirisTarih.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            mskdtxtTc.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            mskdtxtTel.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            cmbDogumYer.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            mskdtxtDogumTarih.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
            txtBolum.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
            txtVeliAd.Text = dataGridView.CurrentRow.Cells[10].Value.ToString();
            txtVeliSoyad.Text = dataGridView.CurrentRow.Cells[11].Value.ToString();
            mskdtxtVeliTel1.Text = dataGridView.CurrentRow.Cells[12].Value.ToString();
            mskdtxtVeliTel2.Text = dataGridView.CurrentRow.Cells[13].Value.ToString();
            rchtxtAdres.Text = dataGridView.CurrentRow.Cells[14].Value.ToString();
        }





        public void SutunDuzenle()
        {


            dataGridView.Columns["OgrenciAd"].HeaderText = "Adı";
            dataGridView.Columns["OgrenciSoyad"].HeaderText = "Soyadı";
            dataGridView.Columns["OdaGirisTarihi"].HeaderText = "Giriş Tarihi";
            dataGridView.Columns["OgrenciTc"].HeaderText = "Tc";
            dataGridView.Columns["Ogrenciil"].HeaderText = "İl";
            dataGridView.Columns["OgrenciMail"].HeaderText = "Mail";
            dataGridView.Columns["OgrenciDogumTarihi"].HeaderText = "Doğum Tarihi";
            dataGridView.Columns["OgrenciVeliAd"].HeaderText = "Veli Ad";
            dataGridView.Columns["OgrenciVeliSoyad"].HeaderText = "Veli Soyad";
            dataGridView.Columns["OgrenciVeliTel1"].HeaderText = "Veli Tel1";
            dataGridView.Columns["OgrenciVeliTel2"].HeaderText = "Veli Tel2";
            dataGridView.Columns["OgrenciVeliAdres"].HeaderText = "Veli Adres";


        }




        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenciİslemleri SQL = new Ogrenciİslemleri();
            SQL.OgrenciEkle(txtAd.Text, txtSoyad.Text,dateGirisTarih.Text,mskdtxtTc.Text,mskdtxtTel.Text,cmbDogumYer.Text,txtMail.Text,mskdtxtDogumTarih.Text,txtBolum.Text,txtVeliAd.Text,txtVeliSoyad.Text,mskdtxtVeliTel1.Text,mskdtxtVeliTel2.Text,rchtxtAdres.Text);
            OgrenciYenile();//her ekleme işleminden sonra datagridview listesinin güncellenmesi için
            Temizle();//ekleme işlemini yaptıktan verileri getirdikten sonra textbox combobaxların temizlenmesi için

        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            Ogrenciİslemleri SQL = new Ogrenciİslemleri();
            SQL.OgrenciSil(Convert.ToInt32(txtid.Text));
            OgrenciYenile();
            Temizle();
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Ogrenciİslemleri SQL = new Ogrenciİslemleri();
            SQL.OgrenciGuncelle(Convert.ToInt32(txtid.Text), txtAd.Text, txtSoyad.Text,dateGirisTarih.Text, mskdtxtTc.Text, mskdtxtTel.Text, cmbDogumYer.Text, txtMail.Text, mskdtxtDogumTarih.Text,txtBolum.Text, txtVeliAd.Text, txtVeliSoyad.Text, mskdtxtVeliTel1.Text, mskdtxtVeliTel2.Text, rchtxtAdres.Text);
            OgrenciYenile();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        
    }

}



 


