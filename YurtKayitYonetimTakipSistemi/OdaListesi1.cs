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
    public partial class OdaListesi1 : Form
    {

        public static string GidenBilgi = "";
    
      
        public OdaListesi1()
        {
            InitializeComponent();
        }




        SqlBaglantisi bgln = new SqlBaglantisi();
        Odaİslemleri SQL = new Odaİslemleri();
        Personel_OdaKayit po = new Personel_OdaKayit();
        

        
        public void OdaYenile()
        {
            dataGridView1.DataSource = SQL.OdaGetir();

        }
            private void OdaListesi1_Load(object sender, EventArgs e)
        {
            OdaYenile();

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
           
            Personel_OdaKayit fr = new Personel_OdaKayit();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           
            fr.Show();
            this.Hide();
           
            
        }
    }
}
