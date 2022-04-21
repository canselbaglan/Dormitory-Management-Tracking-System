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
    public partial class PersonelListesi2 : Form
    {

        public static string GidenBilgi = "";
        public PersonelListesi2()
        {
            InitializeComponent();
        }



        SqlBaglantisi bgln = new SqlBaglantisi();
        Personelİslemleri SQL = new Personelİslemleri();


        public void PersonelYenile()
        {

            dataGridView1.DataSource = SQL.PersonelGetir();



        }
        private void PersonelListesi2_Load(object sender, EventArgs e)
        {

            PersonelYenile();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            Personelİzin fr = new Personelİzin();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
            this.Hide();
        }
    }
}
