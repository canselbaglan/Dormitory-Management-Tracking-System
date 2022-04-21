using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace YurtKayitYonetimTakipSistemi
{
    public partial class Duyurular : Form
    {
        
       
        
        
        public Duyurular()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgln = new SqlBaglantisi();
        Duyuruİslemleri SQL = new Duyuruİslemleri();



        public void DuyuruYenile()
        {

            dataGridView1.DataSource =SQL.DuyuruGetir();


        }


        
        void Temizle()
        {

            txtid.Clear();
            dateDuyuruYayin.ResetText();
            dateDuyuruBaslangic.ResetText();
            dateDuyuruBitis.ResetText();
            richtxtNot.Clear();



        }
        private void Form2_Load(object sender, EventArgs e)
        {
           DuyuruYenile();
           Temizle();
            
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)

        {

            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateDuyuruYayin.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateDuyuruBaslangic.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateDuyuruBitis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            richtxtNot.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
                
        {


            Duyuruİslemleri SQL = new Duyuruİslemleri();
            SQL.DuyuruEkle(dateDuyuruYayin.Text, dateDuyuruBaslangic.Text, dateDuyuruBitis.Text, richtxtNot.Text);
            DuyuruYenile();
            Temizle();
           
            
       
      
           
        }

        private void btnSil_Click(object sender, EventArgs e)


        

        {
            Duyuruİslemleri SQL = new Duyuruİslemleri();
            SQL.DuyuruSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            DuyuruYenile();
            Temizle();

            }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Duyuruİslemleri SQL = new Duyuruİslemleri();
            SQL.DuyuruGuncelle(Convert.ToInt32(txtid.Text), dateDuyuruYayin.Text, dateDuyuruBaslangic.Text, dateDuyuruBitis.Text, richtxtNot.Text);
            DuyuruYenile();
            Temizle();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();        
        
        }



    }
    
    
    

        

    

    }


