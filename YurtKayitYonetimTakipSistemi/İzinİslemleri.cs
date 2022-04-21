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
    class İzinİslemleri
    {

        SqlBaglantisi bgln = new SqlBaglantisi();



        public DataTable OgrenciİzinGetir()


        {

        SqlDataAdapter da = new SqlDataAdapter("SELECT İzinid,İzinler.Ogrenciid,OgrenciAd,OgrenciSoyad,OgrenciTc,OgrenciTel,AlinanTarih,BaslangicTarih,BitisTarih,İzinSebebi,Gidilenİl FROM Ogrenciler join İzinler ON Ogrenciler.Ogrenciid = İzinler.Ogrenciid", bgln.baglanti());
        DataTable tablo = new DataTable();
        da.Fill(tablo);
        bgln.baglanti().Close();
        return tablo;



    }


        public void OgrenciİzinEkle( int Ogrenciid, string AlinanTarih,string BaslangicTarih,string BitisTarih, string İzinSebebi, string Gidilenİl)
        {

           
            String Sorgu = "INSERT INTO İzinler(Ogrenciid,AlinanTarih,BaslangicTarih,BitisTarih,İzinSebebi,Gidilenİl)VALUES(@Ogrenciid,@AlinanTarih,@BaslangicTarih,@BitisTarih,@İzinSebebi,@Gidilenİl)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Ogrenciid",Ogrenciid);
            komut.Parameters.AddWithValue("@AlinanTarih",AlinanTarih);
             komut.Parameters.AddWithValue("@BaslangicTarih",BaslangicTarih);
            komut.Parameters.AddWithValue("@BitisTarih",BitisTarih);
            komut.Parameters.AddWithValue("@İzinSebebi",İzinSebebi);
            komut.Parameters.AddWithValue("@Gidilenil",Gidilenİl);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }




        public void OgrenciİzinSil(int İzinid)
        {

            String Sorgu = "DELETE FROM İzinler where İzinid=@İzinid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@İzinid",İzinid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();


        }


        public void OgrenciİzinGuncelle(int İzinid,int Ogrenciid,string AlinanTarih,string BaslangicTarih,string BitisTarih,string  İzinSebebi,string Gidilenİl)
        {
            String Sorgu = "UPDATE İzinler SET Ogrenciid=@Ogrenciid,AlinanTarih=@AlinanTarih,BaslangicTarih=@BaslangicTarih,BitisTarih=@BitisTarih,İzinSebebi=@İzinSebebi,Gidilenİl=@Gidilenİl Where İzinid=@İzinid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            
            komut.Parameters.AddWithValue("@İzinid",İzinid);
            komut.Parameters.AddWithValue("@Ogrenciid", Ogrenciid);
            komut.Parameters.AddWithValue("@AlinanTarih",AlinanTarih );
            komut.Parameters.AddWithValue("@BaslangicTarih",BaslangicTarih);
            komut.Parameters.AddWithValue("@BitisTarih", BitisTarih);
            komut.Parameters.AddWithValue("@İzinSebebi",İzinSebebi);
            komut.Parameters.AddWithValue("@Gidilenİl",Gidilenİl);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();





        }


        public DataTable PersonelİzinGetir()


        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT İzinid,İzinler.Personelid,PersonelAd,PersonelSoyad,PersonelTc,PersonelTel,AlinanTarih,BaslangicTarih,BitisTarih,İzinSebebi,Gidilenİl FROM Personeller join İzinler ON Personeller.Personelid = İzinler.Personelid", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }


        public void PersonelİzinEkle(int Personelid,string AlinanTarih, string BaslangicTarih, string BitisTarih, string İzinSebebi, string Gidilenİl)
        {
            String Sorgu = "INSERT INTO İzinler(Personelid,AlinanTarih,BaslangicTarih,BitisTarih,İzinSebebi,Gidilenİl)VALUES(@Personelid,@AlinanTarih,@BaslangicTarih,@BitisTarih,@İzinSebebi,@Gidilenİl)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Personelid", Personelid);
            komut.Parameters.AddWithValue("@AlinanTarih", AlinanTarih);
            komut.Parameters.AddWithValue("@BaslangicTarih", BaslangicTarih);
            komut.Parameters.AddWithValue("@BitisTarih", BitisTarih);
            komut.Parameters.AddWithValue("@İzinSebebi", İzinSebebi);
            komut.Parameters.AddWithValue("@Gidilenil", Gidilenİl);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }




        public void PersonelİzinSil(int İzinid)
        {

            String Sorgu = "DELETE FROM İzinler where İzinid=@İzinid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@İzinid", İzinid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();


        }


        public void PersonelİzinGuncelle(int İzinid,int Personelid, string AlinanTarih, string BaslangicTarih, string BitisTarih, string İzinSebebi, string Gidilenİl)
        {
            String Sorgu = "UPDATE İzinler SET Personelid=@Personelid, AlinanTarih=@AlinanTarih,BaslangicTarih=@BaslangicTarih,BitisTarih=@BitisTarih,İzinSebebi=@İzinSebebi,Gidilenİl=@Gidilenİl Where İzinid=@İzinid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            
           
            komut.Parameters.AddWithValue("@İzinid", İzinid);
            komut.Parameters.AddWithValue("@Personelid", Personelid);
            komut.Parameters.AddWithValue("@AlinanTarih", AlinanTarih);
            komut.Parameters.AddWithValue("@BaslangicTarih", BaslangicTarih);
            komut.Parameters.AddWithValue("@BitisTarih", BitisTarih);
            komut.Parameters.AddWithValue("@İzinSebebi", İzinSebebi);
            komut.Parameters.AddWithValue("@Gidilenİl", Gidilenİl);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();





        }


    }
}
