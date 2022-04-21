using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YurtKayitYonetimTakipSistemi
{
    public partial class GirisCikis : Form
    {
        public GirisCikis()
        {
            InitializeComponent();
        }



        SqlBaglantisi bgln = new SqlBaglantisi();
        GirisCikisİslemleri SQL = new GirisCikisİslemleri();

        private void btnOgrenciSec_Click(object sender, EventArgs e)
        {
            OgrenciListesi5 fr1 = new OgrenciListesi5();
            this.Hide();
            fr1.ShowDialog();

        }

        public string Bilgi;


        public void OgrenciGirisCikisGetirYenile()
        {

            dataGridView1.DataSource = SQL.OgrenciGirisCikisGetir();


        }

        private void GirisCikis_Load(object sender, EventArgs e)
        {
            
            Bilgi = OgrenciListesi5.GidenBilgi.ToString();
             OgrenciGirisCikisGetirYenile();
            Temizle();



        }


        void Temizle()
        {
            dateTarih.ResetText();
            txtGiris.Clear();
            txtCikis.Clear();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            GirisCikisİslemleri SQL = new GirisCikisİslemleri();
            SQL.OgrenciGirisCikisEkle(Convert.ToInt32(Bilgi),dateTarih.Text,txtGiris.Text,txtCikis.Text);
            OgrenciGirisCikisGetirYenile();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            GirisCikisİslemleri SQL = new GirisCikisİslemleri();
            SQL.OgrenciGirisCikisSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            OgrenciGirisCikisGetirYenile();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GirisCikisİslemleri SQL = new GirisCikisİslemleri();
            SQL.OgrenciGirisCikisGuncelle(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),dateTarih.Text,txtGiris.Text,txtCikis.Text);
            OgrenciGirisCikisGetirYenile();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnSuanGiris_Click(object sender, EventArgs e)
        {
            // DateTime tarih = new DateTime();
            //tarih = DateTime.Now;
             txtGiris.Text=DateTime.Now.ToString("HH:mm");
            //txtGiris.Text = Convert.ToString(tarih);

        }

        private void btnSuanCikis_Click(object sender, EventArgs e)
        {
            //DateTime tarih = new DateTime();
            //tarih = DateTime.Now;
            // txtCikis.Text = Convert.ToString(tarih);
            txtCikis.Text= DateTime.Now.ToString("HH:mm");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dateTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGiris.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCikis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void GirisCikis_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaSayfa frm = new AnaSayfa();
            frm.OgrencierkengecGirisCikisYenile();
            AnaSayfa frm2 = new AnaSayfa();
            frm2.Show();
        }
    }
}
