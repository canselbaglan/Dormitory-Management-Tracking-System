using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayitYonetimTakipSistemi
{
    public partial class İzinLİstesi : Form
    {


        İzinİslemleri SQL = new İzinİslemleri();
        

        SqlBaglantisi bgln = new SqlBaglantisi();



        public static string GidenBilgi = "";
        public İzinLİstesi()
        {
            InitializeComponent();
        }


        public void OgrenciİzinYenile()
        {


            dataGridView1.DataSource = SQL.OgrenciİzinGetir();



        }

        private void OgrenciListesi5_Load(object sender, EventArgs e)
        {

            OgrenciİzinYenile();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            İzinGirisCikis fr = new İzinGirisCikis();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
            this.Hide();

        }
    }
}
