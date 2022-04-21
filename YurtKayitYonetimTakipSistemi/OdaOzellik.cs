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
    public partial class OdaOzellik
        : Form
    {
        public OdaOzellik()
        {
           
            
            InitializeComponent();
        }
        
        public int Oda_ozellikid;
        public int GidenBilgi;
        Odaİslemleri SQL = new Odaİslemleri();
        public void OdaOzellikYenile()
        {
           
            dataGridView1.DataSource = SQL.OdaOzellikGetir();



        }

        void Temizle()
        {
            cmbOzellik.ResetText();
            mskdtxtBaslangic.Clear();
            mskdtxtBitis.Clear();
            cmbDurum.ResetText();
           


        }


    


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            cmbOzellik.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mskdtxtBaslangic.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mskdtxtBitis.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbDurum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        public string Bilgi;
       
        private void OdaOzellik_Load(object sender, EventArgs e)
        {
            
            SqlBaglantisi bgln = new SqlBaglantisi();
            
            OdaSec SQL = new OdaSec();
            OdaOzellikYenile();
            Temizle();
            Bilgi = OdaSec.GidenBilgi.ToString();
           


        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Odaİslemleri SQL = new Odaİslemleri();
        
           
            SQL.OdaOzellikEkle(Convert.ToInt32(Bilgi),cmbOzellik.Text,mskdtxtBaslangic.Text,mskdtxtBitis.Text,cmbDurum.Text);
            OdaOzellikYenile();
            Temizle();
        }


        //Convert.ToInt32(cmbDurum.Text)

        private void btnOdaSec_Click(object sender, EventArgs e)
        {
            OdaSec fr = new OdaSec();
            fr.Show();
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Odaİslemleri SQL = new Odaİslemleri();
            SQL.OdaOzellikSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            OdaOzellikYenile();
            Temizle();

        }

       


        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Odaİslemleri SQL = new Odaİslemleri();
            SQL.OdaOzellikGuncelle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),cmbOzellik.Text,mskdtxtBaslangic.Text,mskdtxtBitis.Text,cmbDurum.Text);
            OdaOzellikYenile();
            Temizle();

        }

        
    }
    }

