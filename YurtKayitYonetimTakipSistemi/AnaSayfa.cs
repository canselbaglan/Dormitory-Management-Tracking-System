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
    public partial class AnaSayfa : Form
    {

        public AnaSayfa()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgln = new SqlBaglantisi();
        PersonelOdaİslemleri SQL = new PersonelOdaİslemleri();
        GirisCikisİslemleri SQL2 = new GirisCikisİslemleri();

        public void PersonelGorevYenile()
        {

            dataGrid_gorev.DataSource = SQL.PersonelGorevGetir();



        }

        //izin
        public void erkengecGirisCikisYenile()
        {

            dataGrid_izin.DataSource = SQL2.erkengecGirisCikisGetir();



        }
        //genel
        public void OgrencierkengecGirisCikisYenile()
        {

            dataGrid_OgrenciGirisCikis.DataSource = SQL2.OgrencierkengecGirisCikisGetir();



        }
        private void öĞRENCİİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenciler fr = new Ogrenciler();
            fr.Show();

        }

        private void öĞRENCİODAİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenci_OdaKayit fr = new Ogrenci_OdaKayit();
            fr.Show();
        }

        private void oDALARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
        }

        private void pERSONELİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personeller fr = new Personeller();
            fr.Show();
        }

        private void pERSONELODAİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personel_OdaKayit fr = new Personel_OdaKayit();
            fr.Show();
        }

        private void öDEMELERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Odemeler fr = new Odemeler();
            fr.Show();
        }

        private void mENÜLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menuler fr = new Menuler();
            fr.Show();
        }

        private void dUYURULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }

        private void şİKAYETLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sikayetler fr = new Sikayetler();
            fr.Show();
        }

        private void öĞRENCİİZİNİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenciİzin fr = new Ogrenciİzin();
            fr.ShowDialog();

        }

        private void pERSONELİZİNİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Personelİzin fr = new Personelİzin();
            fr.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }


        void takip()

        {


            for (int i = 0; i < dataGrid_OgrenciGirisCikis.Rows.Count - 1; i++)

            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();





                string sabitgiris= Convert.ToString("06:00");
                string sabitcikis = Convert.ToString("23:00");
                string a = Convert.ToString("23:59");
                string songiris = Convert.ToString(dataGrid_OgrenciGirisCikis.Rows[i].Cells[5].Value);
                string soncikis = Convert.ToString(dataGrid_OgrenciGirisCikis.Rows[i].Cells[6].Value);
                string ilkgiris = Convert.ToString(dataGrid_OgrenciGirisCikis.Rows[i].Cells[7].Value);
                string ilkcikis = Convert.ToString(dataGrid_OgrenciGirisCikis.Rows[i].Cells[8].Value);





                if (Convert.ToDateTime(songiris)<Convert.ToDateTime(sabitgiris) || Convert.ToDateTime(sabitcikis) < Convert.ToDateTime(songiris) || Convert.ToDateTime(songiris) > Convert.ToDateTime(a))
                {
                    renk.BackColor = Color.Red;



                }
                if(Convert.ToDateTime(soncikis) > Convert.ToDateTime(songiris) || Convert.ToDateTime(soncikis) < Convert.ToDateTime(sabitgiris) || (Convert.ToDateTime(sabitcikis) < Convert.ToDateTime(soncikis) && Convert.ToDateTime(soncikis)<Convert.ToDateTime(a)))
                {


                    renk.BackColor = Color.Aqua;

                }

                else

                {

                    renk.BackColor = Color.Yellow;
                }


                dataGrid_OgrenciGirisCikis.Rows[i].DefaultCellStyle = renk;





            }

        }

            void izin()
            {


                for (int i = 0; i < dataGrid_izin.Rows.Count - 1; i++)

                {
                    DataGridViewCellStyle rengi = new DataGridViewCellStyle();


                    string baslangic = Convert.ToString(dataGrid_izin.Rows[i].Cells[3].Value);
                    string bitis = Convert.ToString(dataGrid_izin.Rows[i].Cells[4].Value);
                    string giris = Convert.ToString(dataGrid_izin.Rows[i].Cells[5].Value);
                    string cikis = Convert.ToString(dataGrid_izin.Rows[i].Cells[6].Value);

                    if ((Convert.ToDateTime(baslangic) < Convert.ToDateTime(giris) && Convert.ToDateTime(giris) < Convert.ToDateTime(bitis)))

                    {
                        rengi.BackColor = Color.Red;



                    }


                    else
                    {

                        rengi.BackColor = Color.Green;



                    }


                    dataGrid_izin.Rows[i].DefaultCellStyle = rengi;


                }


            }



        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            PersonelGorevYenile();
            erkengecGirisCikisYenile();
            OgrencierkengecGirisCikisYenile();
            izin();
            takip();



        }



       
        private void pERSONELGÖREVToolStripMenuItem_Click(object sender, EventArgs e)
                {

         
            PersonelGorev fr = new PersonelGorev();
            fr.Show();
            this.Hide();
            
         
           
          
     



        }

                private void iZİNGİRİŞÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    İzinGirisCikis fr = new İzinGirisCikis();
                    fr.Show();
                    this.Hide();

        }



                private void dataGrid_gorev_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
                    PersonelGorevYenile();
                }

                private void gİRİŞÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    GirisCikis fr = new GirisCikis();
                    fr.Show();
                    this.Hide();
                }

        private void gİDERLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giderler fr = new Giderler();
            fr.Show();
        }
    }

        }
    





















