using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayitYonetimTakipSistemi
{
    public partial class Giderler : Form
    {

         //SqlCommand komut;

        public Giderler()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgln = new SqlBaglantisi();
        Giderİslemleri SQL = new Giderİslemleri();

        public void GiderYenile()
        {

            dataGridView1.DataSource = SQL.GiderGetir();

        }

        

        void Temizle()

        {

            txtGiderid.Clear();
            dateTarih.ResetText();
            txtMutfak.Clear();
            txtTemizlik.Clear();
            txtTamirat.Clear();
            txtSu.Clear();
            txtElektrik.Clear();
            txtInternet.Clear();
            txtPersonel.Clear();
            txtDiger.Clear();


        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            GiderYenile();
            Temizle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtGiderid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dateTarih.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMutfak.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTemizlik.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTamirat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtElektrik.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtInternet.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtPersonel.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtDiger.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();


        }

        private void btnEkle_Click(object sender, EventArgs e)


        {
            SQL.GiderEkle(dateTarih.Text, txtMutfak.Text, txtTemizlik.Text, txtTamirat.Text, txtSu.Text, txtElektrik.Text, txtInternet.Text, txtPersonel.Text, txtDiger.Text);
            GiderYenile();
            Temizle();


        }


        private void btnSil_Click(object sender, EventArgs e)

        {

            SQL.GiderSil(Convert.ToInt32(txtGiderid.Text));
            GiderYenile();
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


            SQL.GiderGuncelle(Convert.ToInt32(txtGiderid.Text), dateTarih.Text, txtMutfak.Text, txtTemizlik.Text, txtTamirat.Text, txtSu.Text, txtElektrik.Text, txtInternet.Text, txtPersonel.Text, txtDiger.Text);
            GiderYenile();
            Temizle();

            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
        }
    

