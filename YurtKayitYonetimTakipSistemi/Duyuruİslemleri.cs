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
    class Duyuruİslemleri
    {
        SqlBaglantisi bgln = new SqlBaglantisi();

        public DataTable DuyuruGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select *from Duyurular ", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;


        }


        public void DuyuruEkle(string DuyuruYayinlanmaTarihi, string DuyuruBaslangicTarih, string DuyuruBitisTarih, string DuyuruNot)
        {

            string sorgu = " INSERT INTO Duyurular(DuyuruYayinlanmaTarihi,DuyuruBaslangicTarih,DuyuruBitisTarih,DuyuruNot)VALUES(@DuyuruYayinlanmaTarihi,@DuyuruBaslangicTarih,@DuyuruBitisTarih,@DuyuruNot)";
            SqlCommand komutekle = new SqlCommand(sorgu, bgln.baglanti());
            komutekle.Parameters.AddWithValue("@DuyuruYayinlanmaTarihi", @DuyuruYayinlanmaTarihi);
            komutekle.Parameters.AddWithValue("@DuyuruBaslangicTarih", @DuyuruBaslangicTarih);
            komutekle.Parameters.AddWithValue("@DuyuruBitisTarih", @DuyuruBitisTarih);
            komutekle.Parameters.AddWithValue("@DuyuruNot", @DuyuruNot);
            komutekle.ExecuteNonQuery();
            bgln.baglanti().Close();





        }



        public void DuyuruSil(int Duyuruid)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (c == DialogResult.Yes)
            {

                string sorgu = "DELETE From Duyurular where Duyuruid=@Duyuruid";
                SqlCommand komutsil = new SqlCommand(sorgu, bgln.baglanti());
                komutsil.Parameters.AddWithValue("@Duyuruid", Duyuruid);
                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();


            }//if bitişi


        }



        public void DuyuruGuncelle(int Duyuruid,string DuyuruYayinlanmaTarihi,string DuyuruBaslangicTarih,string DuyuruBitisTarih,string DuyuruNot)
        {

            string sorgu = "UPDATE Duyurular SET DuyuruYayinlanmaTarihi=@DuyuruYayinlanmaTarihi,DuyuruBaslangicTarih=@DuyuruBaslangicTarih,DuyuruBitisTarih=@DuyuruBitisTarih,DuyuruNot=@DuyuruNot WHERE Duyuruid=@Duyuruid";
            SqlCommand komutguncelle = new SqlCommand(sorgu, bgln.baglanti());
            komutguncelle.Parameters.AddWithValue("@Duyuruid", Duyuruid);
            komutguncelle.Parameters.AddWithValue("@DuyuruYayinlanmaTarihi",DuyuruYayinlanmaTarihi );
            komutguncelle.Parameters.AddWithValue("@DuyuruBaslangicTarih",DuyuruBaslangicTarih );
            komutguncelle.Parameters.AddWithValue("@DuyuruBitisTarih",DuyuruBitisTarih );
            komutguncelle.Parameters.AddWithValue("@DuyuruNot",DuyuruNot);
            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();



        }



    }
}
