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
    class Sikayetİslemleri
    {
        SqlBaglantisi bgln = new SqlBaglantisi();




        public DataTable SikayetGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT Sikayetid,Sikayetler.Ogrenciid,OgrenciAd,OgrenciSoyad,OgrenciTc,OgrenciTel,SikayetTur,Sikayet,SikayetTarih,SonDurum,CozumTarih FROM Ogrenciler join Sikayetler ON Ogrenciler.Ogrenciid = Sikayetler.Ogrenciid", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }


        public void SikayetEkle(int Ogrenciid,string SikayetTur, string Sikayet,string  SikayetTarih,string SonDurum, string CozumTarih)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = " INSERT INTO Sikayetler(Ogrenciid,SikayetTur,Sikayet,SikayetTarih,SonDurum,CozumTarih)VALUES(@Ogrenciid,@SikayetTur,@Sikayet,@SikayetTarih,@SonDurum,@CozumTarih)";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Ogrenciid",Ogrenciid);
            komut.Parameters.AddWithValue("@SikayetTur",SikayetTur);
            komut.Parameters.AddWithValue("@Sikayet",Sikayet);
            komut.Parameters.AddWithValue("@SikayetTarih",SikayetTarih);
            komut.Parameters.AddWithValue("@SonDurum",SonDurum);
            komut.Parameters.AddWithValue("@CozumTarih",CozumTarih);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();


        }


        public void SikayetSil(int Sikayetid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "DELETE From Sikayetler where Sikayetid=@Sikayetid";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Sikayetid",Sikayetid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }





        public void SikayetGuncelle(int Ogrenciid,int Sikayetid,string SikayetTur, string Sikayet, string SikayetTarih, string SonDurum, string CozumTarih)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "UPDATE Sikayetler SET Ogrenciid=@Ogrenciid,SikayetTur=@SikayetTur,Sikayet=@Sikayet,SikayetTarih=@SikayetTarih,SonDurum=@SonDurum,CozumTarih=@CozumTarih WHERE Sikayetid=@Sikayetid ";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Ogrenciid", Ogrenciid);
            komut.Parameters.AddWithValue("@Sikayetid",Sikayetid);
            komut.Parameters.AddWithValue("@SikayetTur", SikayetTur);
            komut.Parameters.AddWithValue("@Sikayet", Sikayet);
            komut.Parameters.AddWithValue("@SikayetTarih", SikayetTarih);
            komut.Parameters.AddWithValue("@SonDurum", SonDurum);
            komut.Parameters.AddWithValue("@CozumTarih", CozumTarih);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }


    }
}
