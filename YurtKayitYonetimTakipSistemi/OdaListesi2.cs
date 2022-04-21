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
    public partial class OdaListesi2 : Form
    {
        public OdaListesi2()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgln = new SqlBaglantisi();
        Odaİslemleri SQL = new Odaİslemleri();


        public void OdaYenile()
        {
            dataGridView1.DataSource = SQL.BosOdaGetir();


        }
        public static string GidenBilgi = "";
       
        private void OdaListesi_Load(object sender, EventArgs e)
        {
            OdaYenile();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Ogrenci_OdaKayit fr = new Ogrenci_OdaKayit();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
            this.Hide();
        }
    }
}
