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
    public partial class PersonelListesi1 : Form
    {
        public PersonelListesi1()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgln = new SqlBaglantisi();
        Personelİslemleri SQL = new Personelİslemleri();


        public void PersonelYenile()
        {

            dataGridView1.DataSource = SQL.PersonelGetir();



        }

        public static string GidenBilgi = "";
       
        private void PersonelListele_Load(object sender, EventArgs e)
        {
            PersonelYenile();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Personel_OdaKayit fr = new Personel_OdaKayit();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
            this.Hide();
        }

        void PersonelAra()
        {
            SqlBaglantisi bgln = new SqlBaglantisi();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personeller where PersonelSoyad like'" + txtAra.Text + "'", bgln.baglanti());

            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgln.baglanti().Close();




        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            PersonelAra();
         

        }
    }
}
