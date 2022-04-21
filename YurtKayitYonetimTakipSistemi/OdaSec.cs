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
    public partial class OdaSec : Form
    {
        public OdaSec()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgln = new SqlBaglantisi();
        Odaİslemleri SQL = new Odaİslemleri();

        public static string GidenBilgi = "";

        public void OdaYenile()
        {

            dataGridView1.DataSource = SQL.OdaGetir();



        }
        private void OdaSec_Load(object sender, EventArgs e)
        {
           OdaYenile();
        }




        
       


        private void btnSec_Click(object sender, EventArgs e)
        {
            OdaOzellik fr = new OdaOzellik();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
            this.Hide();

        }
    }



}
