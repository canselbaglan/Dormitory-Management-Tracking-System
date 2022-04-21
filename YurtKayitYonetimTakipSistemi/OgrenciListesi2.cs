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
    public partial class OgrenciListesi2 : Form
    {

        public static string GidenBilgi = "";
        public OgrenciListesi2()
        {
            InitializeComponent();
        }

        public string OgrenciAd;
        public void OgrenciYenile()
        {

            txtAra.Text = OgrenciAd;
            dataGridView1.DataSource = SQL.OgrenciGetir();
            


        }



        Ogrenciİslemleri SQL = new Ogrenciİslemleri();

        SqlBaglantisi bgln = new SqlBaglantisi();


        private void OgrenciListesi2_Load(object sender, EventArgs e)
        {
            OgrenciYenile();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Odemeler fr = new Odemeler();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
            this.Hide();

        }



        public void OgrenciAra()
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenciler where OgrenciSoyad like'" + txtAra.Text + "'", bgln.baglanti());

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgln.baglanti().Close();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OgrenciAra();
        }






        


    }

        
    }

