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
    public partial class OgrenciListesi5 : Form
    {



        Ogrenciİslemleri SQL = new Ogrenciİslemleri();

        SqlBaglantisi bgln = new SqlBaglantisi();

        public static string GidenBilgi = "";
        public OgrenciListesi5()
        {
            InitializeComponent();
        }

        public void OgrenciYenile()
        {


            dataGridView1.DataSource = SQL.OgrenciGetir();



        }

        private void OgrİzinKontrol_Load(object sender, EventArgs e)
        {
            OgrenciYenile();
        }

        private void btnOgrenciSec_Click(object sender, EventArgs e)
        {
            GirisCikis fr = new GirisCikis();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
            fr.ShowDialog();
        }
    }
}
