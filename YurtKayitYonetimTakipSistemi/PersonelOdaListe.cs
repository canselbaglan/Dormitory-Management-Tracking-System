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
    public partial class PersonelOdaListe : Form
    {
        public PersonelOdaListe()
        {
            InitializeComponent();
        }




        PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();

        
       
        public void PersonelOdaYenile()
        {

            dataGridView1.DataSource = SQL.PersonelOdaGetir();



        }

        public static string GidenBilgi = "";
        private void PersonelOdaListe_Load(object sender, EventArgs e)
        {
            PersonelOdaYenile();
        }

        private void btnPersonelodasec_Click(object sender, EventArgs e)
        {
            PersonelGorev fr = new PersonelGorev();
            GidenBilgi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.Show();
            this.Hide();
        }
    }
}
