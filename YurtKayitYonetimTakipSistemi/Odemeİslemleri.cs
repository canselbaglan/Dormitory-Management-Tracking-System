using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayitYonetimTakipSistemi
{
    class Odemeİslemleri
    {

        SqlBaglantisi bgln = new SqlBaglantisi();


        public DataTable OdemeGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT Odemeid,Odemeler.Ogrenciid,OgrenciAd,OgrenciSoyad,OgrenciTc,OdenmesiGereken,OdemeTarih,Odenen FROM Ogrenciler  join Odemeler ON Ogrenciler.Ogrenciid = Odemeler.Ogrenciid", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;




        }
        
        public void OdemeEkle(int Ogrenciid,string OdenmesiGereken, string OdemeTarih,string  Odenen)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "INSERT INTO Odemeler(Ogrenciid,OdenmesiGereken,OdemeTarih,Odenen)VALUES(@Ogrenciid,@OdenmesiGereken,@OdemeTarih,@Odenen)";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Ogrenciid", Ogrenciid);
            komut.Parameters.AddWithValue("@OdenmesiGereken",OdenmesiGereken);
            komut.Parameters.AddWithValue("@OdemeTarih",OdemeTarih);
            komut.Parameters.AddWithValue("@Odenen",Odenen);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }



        public void OdemeSil(int Odemeid)
        {
            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "DELETE From Odemeler where Odemeid=@Odemeid";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Odemeid",Odemeid );
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();





        }


        public void OdemeGuncelle(int Ogrenciid,int Odemeid, string OdenmesiGereken, string OdemeTarih, string Odenen)
        {
            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "UPDATE Odemeler SET Ogrenciid=@Ogrenciid,OdenmesiGereken=@OdenmesiGereken,OdemeTarih=@OdemeTarih,Odenen=@Odenen where Odemeid=@Odemeid";
            SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Ogrenciid", Ogrenciid);
            komut.Parameters.AddWithValue("@Odemeid",Odemeid);
            komut.Parameters.AddWithValue("@OdenmesiGereken",OdenmesiGereken);
            komut.Parameters.AddWithValue("@OdemeTarih",OdemeTarih);
            komut.Parameters.AddWithValue("@Odenen",Odenen);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }
            
    }
}
