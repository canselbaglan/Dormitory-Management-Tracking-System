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
    class Menuİslemleri
    {

        SqlBaglantisi bgln = new SqlBaglantisi();

        public DataTable MenuGetir()
        {


            SqlDataAdapter da = new SqlDataAdapter("Select * from Menuler", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }

        public void MenuEkle(string MenuTarih, string YemekAd1, string YemekAd2, string YemekAd3,string  İcecekAd, string TatliAd,string MeyveAd)
        {
            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "INSERT INTO Menuler(MenuTarih,YemekAd1,YemekAd2,YemekAd3,İcecekAd,TatliAd,MeyveAd)VALUES (@MenuTarih,@YemekAd1,@YemekAd2,@YemekAd3,@İcecekad,@TatliAd,@MeyveAd)";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@MenuTarih",MenuTarih);
            komut.Parameters.AddWithValue("@YemekAd1",YemekAd1);
            komut.Parameters.AddWithValue("@YemekAd2",YemekAd2);
            komut.Parameters.AddWithValue("@YemekAd3",YemekAd3);
            komut.Parameters.AddWithValue("@İcecekAd",İcecekAd);
            komut.Parameters.AddWithValue("@TatliAd",TatliAd);
            komut.Parameters.AddWithValue("@MeyveAd",MeyveAd);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }





        public void MenuSil(int Menuid)
        {
            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "DELETE FROM Menuler WHERE Menuid =@Menuid";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Menuid",Menuid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }

        public void MenuGuncelle(int Menuid,string MenuTarih, string YemekAd1, string YemekAd2, string YemekAd3, string İcecekAd, string TatliAd, string MeyveAd)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "UPDATE Menuler SET MenuTarih=@MenuTarih,YemekAd1=@YemekAd1,YemekAd2=@YemekAd2,YemekAd3=@YemekAd3,İcecekAd=@İcecekAd,TatliAd=@TatliAd,MeyveAd=@MeyveAd WHERE Menuid=@Menuid";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Menuid",Menuid);
            komut.Parameters.AddWithValue("@MenuTarih",MenuTarih);
            komut.Parameters.AddWithValue("@YemekAd1",YemekAd1);
            komut.Parameters.AddWithValue("@YemekAd2",YemekAd2);
            komut.Parameters.AddWithValue("@YemekAd3",YemekAd3);
            komut.Parameters.AddWithValue("@İcecekAd",İcecekAd);
            komut.Parameters.AddWithValue("@TatliAd",TatliAd);
            komut.Parameters.AddWithValue("@MeyveAd",MeyveAd);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }




    }
}
