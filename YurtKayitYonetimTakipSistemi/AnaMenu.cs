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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }




        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            Ogrenciler fr = new Ogrenciler();
            fr.Show();
        }

        private void btnPersoneller_Click(object sender, EventArgs e)
        {
            Personeller fr = new Personeller();
            fr.Show();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Odalar fr = new Odalar();
            fr.Show();
        }

        private void btnMenuler_Click(object sender, EventArgs e)
        {
            Menuler fr = new Menuler();
            fr.Show();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            Odemeler fr = new Odemeler();
            fr.Show();

        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            Giderler fr = new Giderler();
            fr.Show();
        }

        private void btnSikayetler_Click(object sender, EventArgs e)
        {

            Sikayetler fr = new Sikayetler();
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            Duyurular fr = new Duyurular();
            fr.Show();
        }

        private void btnİzinler_Click(object sender, EventArgs e)
        {
            Ogrenciİzin fr = new Ogrenciİzin();
            fr.Show();
        }
    }
}
