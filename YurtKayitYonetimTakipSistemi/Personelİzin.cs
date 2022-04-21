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
    public partial class Personelİzin : Form
    {
        public Personelİzin()
        {
            InitializeComponent();
        }




        SqlBaglantisi bgln = new SqlBaglantisi();
        İzinİslemleri SQL = new İzinİslemleri();


        public void PersonelİzinYenile()
        {

            dataGridView1.DataSource = SQL.PersonelİzinGetir();


        }



        void Temizle()
        {

            txtİzinid.Clear();
            txtPersonelid.Clear();
            dateİzinAlinan.ResetText();
            dateİzinBaslama.ResetText();
            dateİzinBitis.ResetText();
            txtSebep.Clear();
            cmbizinil.ResetText();


        }

        private void Personelİzin_Load(object sender, EventArgs e)
        {

            
            
           PersonelİzinYenile();
            Temizle();
            txtPersonelid.Text = PersonelListesi2.GidenBilgi.ToString();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtİzinid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateİzinAlinan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dateİzinBaslama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateİzinBitis.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSebep.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            cmbizinil.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            İzinİslemleri SQL = new İzinİslemleri();
            SQL.PersonelİzinEkle(Convert.ToInt32(txtPersonelid.Text), dateİzinAlinan.Text, dateİzinBaslama.Text, dateİzinBitis.Text, txtSebep.Text, cmbizinil.Text);
            PersonelİzinYenile();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            İzinİslemleri SQL = new İzinİslemleri();
            SQL.PersonelİzinSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            PersonelİzinYenile();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            İzinİslemleri SQL = new İzinİslemleri();
            SQL.PersonelİzinGuncelle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()), dateİzinAlinan.Text, dateİzinBaslama.Text, dateİzinBitis.Text, txtSebep.Text, cmbizinil.Text);
            PersonelİzinYenile();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();

        }

        private void btnPersonelİzinListesi_Click(object sender, EventArgs e)
        {
            PersonelListesi2 fr = new PersonelListesi2();
            fr.Show();
           
        }
    }


}
