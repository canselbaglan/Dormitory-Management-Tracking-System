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
    class OgrenciOdaİslemleri
    {
        SqlBaglantisi bgln = new SqlBaglantisi();


        public DataTable OgrenciOdaGetir()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT Ogrenciler_Odalar_id,Ogrenciler_Odalar.Ogrenciid,Ogrenciler_Odalar.Odaid,OgrenciAd,OgrenciSoyad,OgrenciTc,Odalar.OdaNo,OdaGirisTarihi,OdaKapasite,OdaAktif,OdaKat FROM Ogrenciler_Odalar join Ogrenciler ON Ogrenciler.Ogrenciid = Ogrenciler_Odalar.Ogrenciid join Odalar ON Odalar.Odaid = Ogrenciler_Odalar.Odaid", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }




        public void OgrenciOdaEkle(int Ogrenciid,int Odaid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "INSERT INTO Ogrenciler_Odalar (Ogrenciid,Odaid) VALUES (@Ogrenciid,@Odaid)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@Ogrenciid", Ogrenciid);
            komut.Parameters.AddWithValue("@Odaid",Odaid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }






        public void OgrenciOdaSil(int Ogrenciler_Odalar_id)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "DELETE From Ogrenciler_Odalar Where Ogrenciler_Odalar_id=@Ogrenciler_Odalar_id";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Ogrenciler_Odalar_id",Ogrenciler_Odalar_id);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }





        public void OgrenciOdaGuncelle(int Ogrenciler_Odalar_id,int Ogrenciid,int Odaid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();

            String Sorgu = "UPDATE Ogrenciler_Odalar SET Ogrenciid=@Ogrenciid,Odaid=@Odaid Where Ogrenciler_Odalar_id=@Ogrenciler_Odalar_id";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@Ogrenciler_Odalar_id",Ogrenciler_Odalar_id);
            komut.Parameters.AddWithValue("@Ogrenciid",Ogrenciid);
            komut.Parameters.AddWithValue("@Odaid",Odaid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }

        public void OdaAktifArttir(int Odaid)

        {
            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "Update Odalar set OdaAktif=OdaAktif+1 Where Odaid=@Odaid";
            SqlCommand komutekle = new SqlCommand(sorgu, bgln.baglanti());

            komutekle.Parameters.AddWithValue("@Odaid",Odaid);
            komutekle.ExecuteNonQuery();
            bgln.baglanti().Close();


        }






        public void OdaAktifAzalt(int Odaid)
        {
            SqlBaglantisi bgln = new SqlBaglantisi();
            String sorgu = "Update Odalar  set OdaAktif=OdaAktif-1 Where Odaid=@Odaid";
            SqlCommand komutsil = new SqlCommand(sorgu, bgln.baglanti());
            komutsil.Parameters.AddWithValue("@Odaid", Odaid);
            komutsil.ExecuteNonQuery();
            bgln.baglanti().Close();



        }




    }
}
