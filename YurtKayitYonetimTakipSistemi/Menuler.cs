using System;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace YurtKayitYonetimTakipSistemi
{
    public partial class Menuler : Form
    {
        
        


        public Menuler()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgln = new SqlBaglantisi();
        Menuİslemleri SQL = new Menuİslemleri();


        public void MenuYenile()
        {

            dataGridView1.DataSource = SQL.MenuGetir();


        }




        void Temizle()
        {
            txtNo.Clear();
            msktxtTarih.Clear();
            txtYemek1.Clear();
            txtYemek2.Clear();
            txtYemek3.Clear();
            txtİcecek.Clear();
            txtTatli.Clear();
            txtMeyve.Clear();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            MenuYenile();
            Temizle();
           
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            msktxtTarih.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYemek1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtYemek2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtYemek3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtİcecek.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtTatli.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtMeyve.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        } 
        
    
        private void btnEkle_Click(object sender, EventArgs e)
        {

            Menuİslemleri SQL = new Menuİslemleri();
            
           
            SQL.MenuEkle(msktxtTarih.Text, txtYemek1.Text, txtYemek2.Text, txtYemek3.Text, txtİcecek.Text, txtTatli.Text, txtMeyve.Text);
           
            MenuYenile();
            Temizle();
            
          



        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            Menuİslemleri SQL = new Menuİslemleri();
            SQL.MenuSil(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            MenuYenile();
            Temizle();
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Menuİslemleri SQL = new Menuİslemleri();
            SQL.MenuGuncelle(Convert.ToInt32(txtNo.Text), msktxtTarih.Text, txtYemek1.Text, txtYemek2.Text, txtYemek3.Text, txtİcecek.Text, txtTatli.Text, txtMeyve.Text);
            MenuYenile();
            Temizle();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

    }
}
