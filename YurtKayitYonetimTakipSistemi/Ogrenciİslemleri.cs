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



    class Ogrenciİslemleri
    {




        SqlBaglantisi bgln = new SqlBaglantisi();

        public DataTable OgrenciGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select*from Ogrenciler", bgln.baglanti());
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            bgln.baglanti().Close();
            return tbl;
        }

        





        public void OgrenciEkle(string Yeni_OgrenciAd, string Yeni_OgrenciSoyad, string Yeni_OdaGirisTarihi, string Yeni_OgrenciTc, string Yeni_OgrenciTel, string Yeni_Ogrenciil, string Yeni_OgrenciMail, string Yeni_OgrenciDogumTarihi, string Yeni_OgrenciBolum, string Yeni_OgrenciVeliAd, string Yeni_OgrenciVeliSoyad, string Yeni_OgrenciVeliTel1, string Yeni_OgrenciVeliTel2, string Yeni_OgrenciVeliAdres)
        {
            

            String sorgu = "INSERT INTO  Ogrenciler (OgrenciAd,OgrenciSoyad,OdaGirisTarihi,OgrenciTc,OgrenciTel,Ogrenciil,OgrenciMail,OgrenciDogumTarihi,OgrenciBolum,OgrenciVeliAd,OgrenciVeliSoyad,OgrenciVeliTel1,OgrenciVeliTel2,OgrenciVeliAdres) Values (@OgrenciAd,@OgrenciSoyad,@OdaGirisTarihi,@OgrenciTc,@OgrenciTel,@Ogrenciil,@OgrenciMail,@OgrenciDogumTarihi,@OgrenciBolum,@OgrenciVeliAd,@OgrenciVeliSoyad,@OgrenciVeliTel1,@OgrenciVeliTel2,@OgrenciVeliAdres)";
            SqlCommand komutekle = new SqlCommand(sorgu, bgln.baglanti());
            komutekle.Parameters.AddWithValue("@OgrenciAd", Yeni_OgrenciAd);
            komutekle.Parameters.AddWithValue("@OgrenciSoyad", Yeni_OgrenciSoyad);
            komutekle.Parameters.AddWithValue("@OdaGirisTarihi", Yeni_OdaGirisTarihi);
            komutekle.Parameters.AddWithValue("@OgrenciTc", Yeni_OgrenciTc);
            komutekle.Parameters.AddWithValue("@OgrenciTel", Yeni_OgrenciTel);
            komutekle.Parameters.AddWithValue("@Ogrenciil", Yeni_Ogrenciil);
            komutekle.Parameters.AddWithValue("@OgrenciMail", Yeni_OgrenciMail);
            komutekle.Parameters.AddWithValue("@OgrenciDogumTarihi", Yeni_OgrenciDogumTarihi);
            komutekle.Parameters.AddWithValue("@OgrenciBolum", Yeni_OgrenciBolum);
            komutekle.Parameters.AddWithValue("@OgrenciVeliAd", Yeni_OgrenciVeliAd);
            komutekle.Parameters.AddWithValue("@OgrenciVeliSoyad", Yeni_OgrenciVeliSoyad);
            komutekle.Parameters.AddWithValue("@OgrenciVeliTel1", Yeni_OgrenciVeliTel1);
            komutekle.Parameters.AddWithValue("@OgrenciVeliTel2", Yeni_OgrenciVeliTel2);
            komutekle.Parameters.AddWithValue("@OgrenciVeliAdres", Yeni_OgrenciVeliAdres);
            komutekle.ExecuteNonQuery();
            bgln.baglanti().Close();

        }


        




        public void OgrenciSil(int Ogrenciid)
            {

            String sorgu = "DELETE FROM Ogrenciler Where Ogrenciid=@Ogrenciid";
            SqlCommand komutsil = new SqlCommand(sorgu, bgln.baglanti());
            komutsil.Parameters.AddWithValue("@Ogrenciid",Ogrenciid);
            komutsil.ExecuteNonQuery();
            bgln.baglanti().Close();
        }

       




        public void OgrenciGuncelle(int Ogrenciid,string OgrenciAd,string OgrenciSoyad,string OdaGirisTarihi,string OgrenciTc,string OgrenciTel,string Ogrenciil,string OgrenciMail,string OgrenciDogumTarihi,string OgrenciBolum,string OgrenciVeliAd,string OgrenciVeliSoyad,string OgrenciVeliTel1,string OgrenciVeliTel2, string OgrenciVeliAdres)

        {
            
            String sorgu = " UPDATE Ogrenciler SET OgrenciAd=@OgrenciAd,OgrenciSoyad=@OgrenciSoyad,OdaGirisTarihi=@OdaGirisTarihi,OgrenciTc=@OgrenciTc,OgrenciTel=@OgrenciTel,Ogrenciil=@Ogrenciil,OgrenciMail=@OgrenciMail,OgrenciDogumTarihi=@OgrenciDogumTarihi,OgrenciBolum=@OgrenciBolum,OgrenciVeliAd=@OgrenciVeliAd,OgrenciVeliSoyad=@OgrenciVeliSoyad,OgrenciVeliTel1=@OgrenciVeliTel1,OgrenciVeliTel2=@OgrenciVeliTel2,OgrenciVeliAdres=@OgrenciVeliAdres Where Ogrenciid=@Ogrenciid";
            SqlCommand komutguncelle = new SqlCommand(sorgu, bgln.baglanti());
            
            komutguncelle.Parameters.AddWithValue("@Ogrenciid",Ogrenciid);
            komutguncelle.Parameters.AddWithValue("@OgrenciAd",OgrenciAd);
            komutguncelle.Parameters.AddWithValue("@OgrenciSoyad",OgrenciSoyad);
            komutguncelle.Parameters.AddWithValue("@OdaGirisTarihi",OdaGirisTarihi);
            komutguncelle.Parameters.AddWithValue("@OgrenciTc",OgrenciTc );
            komutguncelle.Parameters.AddWithValue("@OgrenciTel",OgrenciTel);
            komutguncelle.Parameters.AddWithValue("@Ogrenciil", Ogrenciil);
            komutguncelle.Parameters.AddWithValue("@OgrenciMail",OgrenciMail );
            komutguncelle.Parameters.AddWithValue("@OgrenciDogumTarihi",OgrenciDogumTarihi);
            komutguncelle.Parameters.AddWithValue("@OgrenciBolum",OgrenciBolum );
            komutguncelle.Parameters.AddWithValue("@OgrenciVeliAd",OgrenciVeliAd);
            komutguncelle.Parameters.AddWithValue("@OgrenciVeliSoyad",OgrenciVeliSoyad );
            komutguncelle.Parameters.AddWithValue("@OgrenciVeliTel1",OgrenciVeliTel1 );
            komutguncelle.Parameters.AddWithValue("@OgrenciVeliTel2",OgrenciVeliTel2 );
            komutguncelle.Parameters.AddWithValue("@OgrenciVeliAdres",OgrenciVeliAdres);
            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();

        }

    }

   
    

   

    


    
       




}
