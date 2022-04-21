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
    class GirisCikisİslemleri
    {
        SqlBaglantisi bgln = new SqlBaglantisi();

        public DataTable GirisCikisGetir()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT İzingiriscikis.İzingiriscikisid,Ogrenciler.OgrenciAd,Ogrenciler.OgrenciSoyad,Ogrenciler.OgrenciTc,İzinler.AlinanTarih,İzinler.BaslangicTarih,İzinler.BitisTarih,İzinler.İzinSebebi,İzinler.Gidilenİl,İzinGirisCikis.GirisTarihi,İzinGirisCikis.CikisTarihi FROM İzinGirisCikis  join İzinler  ON İzinGirisCikis.İzinid= İzinler.İzinid join Ogrenciler ON İzinler.Ogrenciid = Ogrenciler.Ogrenciid", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }
        public DataTable erkengecGirisCikisGetir()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT  Ogrenciler.OgrenciAd, Ogrenciler.OgrenciSoyad, Ogrenciler.OgrenciTc,İzinler.BaslangicTarih, İzinler.BitisTarih, İzinGirisCikis.GirisTarihi, İzinGirisCikis.CikisTarihi FROM İzinGirisCikis  join İzinler  ON İzinGirisCikis.İzinid = İzinler.İzinid join Ogrenciler ON İzinler.Ogrenciid = Ogrenciler.Ogrenciid where (GirisTarihi not BETWEEN BaslangicTarih AND BitisTarih)  OR (CikisTarihi not BETWEEN BaslangicTarih AND BitisTarih)", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }
        //SELECT İzingiriscikis.İzingiriscikisid,Ogrenciler.OgrenciAd,Ogrenciler.OgrenciSoyad,Ogrenciler.OgrenciTc,İzinler.AlinanTarih,İzinler.BaslangicTarih,İzinler.BitisTarih,İzinler.İzinSebebi,İzinler.Gidilenİl,İzinGirisCikis.GirisTarihi,İzinGirisCikis.CikisTarihi FROM İzinGirisCikis  join İzinler  ON İzinGirisCikis.İzinid= İzinler.İzinid join Ogrenciler ON İzinler.Ogrenciid = Ogrenciler.Ogrenciid




        public DataTable OgrencierkengecGirisCikisGetir()
        {


            SqlDataAdapter da = new SqlDataAdapter("Select Ogrenciler.Ogrenciid,GirisCikis.Tarih,Ogrenciler.OgrenciAd,Ogrenciler.OgrenciSoyad,Ogrenciler.OgrenciTc,max(GirisTarih) AS SonGiris,max(CikisTarih) AS SonÇıkış, min(GirisTarih)  AS İlkGiris,min(CikisTarih) AS İlkCikis from GirisCikis join Ogrenciler ON Ogrenciler.Ogrenciid=GirisCikis.Ogrenciid GROUP BY GirisCikis.Tarih,GirisCikis.Ogrenciid, Ogrenciler.Ogrenciid,Ogrenciler.OgrenciAd,Ogrenciler.OgrenciSoyad,Ogrenciler.OgrenciTc Having   (min(CikisTarih)  BETWEEN '00:00' AND '06:00') or (min(GirisTarih)  BETWEEN  '00:00' AND  '06:00') or(max(GirisTarih) not BETWEEN  '06:00' AND  '23:00') or ( max(CikisTarih) not BETWEEN '06:00' AND '23:00')", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }
        public DataTable OgrenciGetir()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Ogrenciler", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }


      


        public void GirisCikisEkle(int İzinid, string GirisTarihi,string CikisTarihi)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "INSERT INTO İzinGirisCikis (İzinid,GirisTarihi,CikisTarihi) VALUES (@İzinid,@GirisTarihi,@CikisTarihi)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@İzinid", İzinid);
            komut.Parameters.AddWithValue("@GirisTarihi",GirisTarihi);
            komut.Parameters.AddWithValue("@CikisTarihi",CikisTarihi);
            komut.ExecuteNonQuery();
                bgln.baglanti().Close();

        }








        public void GirisCikisSil(int İzingiriscikisid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "DELETE From İzinGirisCikis Where İzingiriscikisid=@İzingiriscikisid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@İzingiriscikisid", İzingiriscikisid);
            
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }

        public void GirisCikisGuncelle(int İzingiriscikisid,string GirisTarihi,string CikisTarihi)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "UPDATE İzinGirisCikis Set GirisTarihi=@GirisTarihi,CikisTarihi=@CikisTarihi  Where İzingiriscikisid=@İzingiriscikisid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@İzingiriscikisid", İzingiriscikisid);
            komut.Parameters.AddWithValue("@GirisTarihi",GirisTarihi);
            komut.Parameters.AddWithValue("@CikisTarihi",CikisTarihi);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }


        public DataTable OgrenciGirisCikisGetir()
        {


            SqlBaglantisi bgln = new SqlBaglantisi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT giriscikisid,Ogrenciler.OgrenciAd,Ogrenciler.OgrenciSoyad,GirisCikis.Tarih,GirisCikis.GirisTarih,GirisCikis.CikisTarih FROM GirisCikis  join Ogrenciler  ON GirisCikis.Ogrenciid= Ogrenciler.Ogrenciid ", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }


        public void OgrenciGirisCikisEkle(int Ogrenciid, string Tarih,string  GirisTarih,string  CikisTarih)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "INSERT INTO GirisCikis (Ogrenciid,Tarih,GirisTarih,CikisTarih) VALUES (@Ogrenciid,@Tarih,@GirisTarih,@CikisTarih)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@Ogrenciid", Ogrenciid);
            komut.Parameters.AddWithValue("@Tarih", Tarih);
            komut.Parameters.AddWithValue("@GirisTarih", GirisTarih);
            komut.Parameters.AddWithValue("@CikisTarih", CikisTarih);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }



        public void OgrenciGirisCikisSil(int giriscikisid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "DELETE From GirisCikis Where giriscikisid=@giriscikisid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@giriscikisid", giriscikisid);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }


        public void OgrenciGirisCikisGuncelle(int giriscikisid, string Tarih,string GirisTarih, string CikisTarih)
        {


            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "UPDATE GirisCikis Set Tarih=@Tarih,GirisTarih=@GirisTarih,CikisTarih=@CikisTarih  Where giriscikisid=@giriscikisid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@giriscikisid", giriscikisid);
            komut.Parameters.AddWithValue("@Tarih", Tarih);
            komut.Parameters.AddWithValue("@GirisTarih", GirisTarih);
            komut.Parameters.AddWithValue("@CikisTarih", CikisTarih);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }
    }
}
