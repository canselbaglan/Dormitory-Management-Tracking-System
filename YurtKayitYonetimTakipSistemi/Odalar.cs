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
    public partial class Odalar : Form
    {

        

        public Odalar()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgln = new SqlBaglantisi();
        Odaİslemleri SQL = new Odaİslemleri();
        public void OdaYenile()
        {
            dataGridView1.DataSource = SQL.OdaGetir();


        }



        void Temizle()
        {

            txtOdaid.Clear();
            txtOdaNO.Clear();
            txtAktif.Clear();
            cmbOdaKapasite.ResetText();
            cmbOdaKat.ResetText();



        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            OdaYenile();
            Temizle();
        }


        private void txtOdaNO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                cmbOdaKapasite.Focus();
                this.ActiveControl = cmbOdaKapasite;


            }



        }

        private void cmbOdaKapasite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                cmbOdaKapasite.Focus();
                this.ActiveControl = cmbOdaKat;


            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            txtOdaid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOdaNO.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbOdaKapasite.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAktif.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbOdaKat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }
        public void OzellikYenile()
        {

            dataGridView1.DataSource = SQL.OdaOzellikGetir();




        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            Odaİslemleri SQL = new Odaİslemleri();
            SQL.OdaEkle(txtOdaNO.Text,cmbOdaKapasite.Text,cmbOdaKat.Text);
            OdaYenile();
            Temizle();
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Odaİslemleri SQL = new Odaİslemleri();
            SQL.OdaSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            OdaYenile();
            Temizle();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Odaİslemleri SQL = new Odaİslemleri();
            SQL.OdaGuncelle(Convert.ToInt32(txtOdaid.Text),txtOdaNO.Text, cmbOdaKapasite.Text, cmbOdaKat.Text);
            OdaYenile();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnOzellikgit_Click(object sender, EventArgs e)
        {
            OdaOzellik fr = new OdaOzellik();
            fr.Show();
            this.Hide();
        }
    }

}

