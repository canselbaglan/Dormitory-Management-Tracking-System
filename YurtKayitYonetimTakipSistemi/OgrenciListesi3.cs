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
    public partial class OgrenciListesi3 : Form
    {
        public OgrenciListesi3()
        {
            InitializeComponent();
        }

        public void OgrenciYenile()
        {


            dataGridView1.DataSource = SQL.OgrenciGetir();



        }



        Ogrenciİslemleri SQL = new Ogrenciİslemleri();

        SqlBaglantisi bgln = new SqlBaglantisi();

        public static string GidenBilgi = "";
        private void OgrenciListesi3_Load(object sender, EventArgs e)
        {
            OgrenciYenile();
        }



        
       
        private void btnSec_Click(object sender, EventArgs e)
        {
            Ogrenci_OdaKayit fr = new Ogrenci_OdaKayit();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
            this.Hide();

            




        }

        void OgrenciAra()
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
