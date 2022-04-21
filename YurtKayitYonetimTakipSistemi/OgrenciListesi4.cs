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
    public partial class OgrenciListesi4 : Form
    {
        public static string GidenBilgi = "";
        public OgrenciListesi4()
        {
            InitializeComponent();
        }

        public void OgrenciYenile()
        {


            dataGridView1.DataSource = SQL.OgrenciGetir();



        }

        Ogrenciİslemleri SQL = new Ogrenciİslemleri();

        SqlBaglantisi bgln = new SqlBaglantisi();

       

        private void OgrenciListesi4_Load(object sender, EventArgs e)
        {
            OgrenciYenile();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            
            Ogrenciİzin fr = new Ogrenciİzin();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.Hide();
            fr.ShowDialog(); 
            

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
