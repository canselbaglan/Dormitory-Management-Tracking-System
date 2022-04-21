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
    class Personelİslemleri
    {

        SqlBaglantisi bgln = new SqlBaglantisi();

        public DataTable PersonelGetir()
        {


        SqlDataAdapter da = new SqlDataAdapter("Select *from Personeller ", bgln.baglanti());
        DataTable tablo = new DataTable();
        da.Fill(tablo);
        bgln.baglanti().Close();
        return tablo;

        }

        public void PersonelEkle(string PersonelAd, string PersonelSoyad, string PersonelTc,string PersonelMail,string Personelİl, string PersonelMaas,string PersonelTel,string PersonelDogum,string PersonelCinsiyet,string İseGirisTarih,string İstenCikisTarih,string PersonelDurum)
        {

            String Sorgu = "INSERT INTO Personeller (PersonelAd,PersonelSoyad,PersonelTc,PersonelMail,Personelİl,PersonelMaas,PersonelTel,PersonelDogum,PersonelCinsiyet,İseGirisTarih,İstenCikisTarih,PersonelDurum) VALUES (@PersonelAd,@PersonelSoyad,@PersonelTc,@PersonelMail,@Personelİl,@PersonelMaas,@PersonelTel,@PersonelDogum,@PersonelCinsiyet,@İseGirisTarih,@İstenCikisTarih,@PersonelDurum)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@PersonelAd",PersonelAd);
            komut.Parameters.AddWithValue("@PersonelSoyad", PersonelSoyad);
            komut.Parameters.AddWithValue("@PersonelTc",PersonelTc);
            komut.Parameters.AddWithValue("@PersonelMail",PersonelMail);
            komut.Parameters.AddWithValue("@Personelİl",Personelİl);
            komut.Parameters.AddWithValue("@PersonelMaas",PersonelMaas);
            komut.Parameters.AddWithValue("@PersonelTel",PersonelTel);
            komut.Parameters.AddWithValue("@PersonelDogum",PersonelDogum);
            komut.Parameters.AddWithValue("@PersonelCinsiyet",PersonelCinsiyet);
            komut.Parameters.AddWithValue("@İseGirisTarih",İseGirisTarih);
            komut.Parameters.AddWithValue("@İstenCikisTarih",İstenCikisTarih);
            komut.Parameters.AddWithValue("@PersonelDurum",PersonelDurum);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }

        public void PersonelSil(int Personelid)
        {

            String Sorgu = "DELETE From Personeller Where Personelid=@Personelid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Personelid",Personelid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();
        }


        public void PersonelGuncelle(int Personelid,string PersonelAd, string PersonelSoyad, string PersonelTc, string PersonelMail, string Personelİl, string PersonelMaas, string PersonelTel, string PersonelDogum, string PersonelCinsiyet, string İseGirisTarih, string İstenCikisTarih, string PersonelDurum)
        {


            String Sorgu = "UPDATE Personeller SET PersonelAd=@PersonelAd,PersonelSoyad=@PersonelSoyad,PersonelTc=@PersonelTc,PersonelMail=@PersonelMail,Personelİl=@Personelİl,PersonelMaas=@PersonelMaas,PersonelTel=@PersonelTel,PersonelDogum=@PersonelDogum,PersonelCinsiyet=@PersonelCinsiyet,İseGirisTarih=@İseGirisTarih,İstenCikisTarih=@İstenCikisTarih,PersonelDurum=@PersonelDurum Where Personelid=@Personelid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@Personelid",Personelid);
            komut.Parameters.AddWithValue("@PersonelAd", PersonelAd);
            komut.Parameters.AddWithValue("@PersonelSoyad",PersonelSoyad );
            komut.Parameters.AddWithValue("@PersonelTc", PersonelTc);
            komut.Parameters.AddWithValue("@PersonelMail",PersonelMail);
            komut.Parameters.AddWithValue("@Personelİl",Personelİl );
            komut.Parameters.AddWithValue("@PersonelMaas",PersonelMaas);
            komut.Parameters.AddWithValue("@PersonelTel",PersonelTel);
            komut.Parameters.AddWithValue("@PersonelDogum",PersonelDogum);
            komut.Parameters.AddWithValue("@PersonelCinsiyet",PersonelCinsiyet);
            komut.Parameters.AddWithValue("@İseGirisTarih",İseGirisTarih);
            komut.Parameters.AddWithValue("@İstenCikisTarih",İstenCikisTarih);
            komut.Parameters.AddWithValue("@PersonelDurum",PersonelDurum);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }


    }
}
