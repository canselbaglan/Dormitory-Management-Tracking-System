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
    public partial class Ogrenciİzin : Form
    {




        public Ogrenciİzin()
        {
            InitializeComponent();
        }



        SqlBaglantisi bgln = new SqlBaglantisi();
        İzinİslemleri SQL = new İzinİslemleri();


     public void OgrenciİzinYenile()
        {

            dataGridView1.DataSource = SQL.OgrenciİzinGetir();


        }

        void Temizle()
        {
            
            
            dateAlinan.ResetText();
            dateİzinBaslama.ResetText();
            dateİzinBitis.ResetText();
            txtSebep.Clear();
            cmbizinil.ResetText();


        }


        private void btnOgrenciListesi_Click(object sender, EventArgs e)
        {
           
            OgrenciListesi4 fr1 = new OgrenciListesi4();
            this.Hide();
            fr1.ShowDialog();
          

        }

        public string Bilgi;
        

        private void İzinler_Load(object sender, EventArgs e)
        {
       
            OgrenciİzinYenile();
            dateİzinBaslama.CustomFormat = "dd.MM.yyyy 06:00 ";
            dateİzinBitis.CustomFormat = "dd.MM.yyyy 23:00 ";

            Temizle();
            Bilgi = OgrenciListesi4.GidenBilgi.ToString();

         
        }

       
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            dateAlinan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateİzinBaslama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateİzinBitis.Text=dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSebep.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cmbizinil.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        


        }

        public void btnEkle_Click(object sender, EventArgs e)
        {

            İzinİslemleri SQL = new İzinİslemleri();
            SQL.OgrenciİzinEkle(Convert.ToInt32(Bilgi), dateAlinan.Text,dateİzinBaslama.Text,dateİzinBitis.Text, txtSebep.Text, cmbizinil.Text);
            OgrenciİzinYenile();
            Temizle();

            
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            
            İzinİslemleri SQL = new İzinİslemleri();
            SQL.OgrenciİzinSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            OgrenciİzinYenile();
            Temizle();
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            İzinİslemleri SQL = new İzinİslemleri();
            SQL.OgrenciİzinGuncelle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()), dateAlinan.Text,dateİzinBaslama.Text,dateİzinBitis.Text, txtSebep.Text, cmbizinil.Text);
            OgrenciİzinYenile();
            Temizle();


        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle(); 
        }

        
    }
}
