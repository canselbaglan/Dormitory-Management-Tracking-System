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
    class Odaİslemleri
    {

        SqlBaglantisi bgln = new SqlBaglantisi();

        //String Sorgu = "select OdaNo from Odalar where OdaKapasite != OdaAktif";


        


        public DataTable OdaOzellikGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT Oda_ozellikid,Odalar.OdaNo,Oda_ozellik.Ozellik,Oda_ozellik.BaslangicTarih,Oda_ozellik.BitisTarih,Oda_ozellik.Durum FROM Odalar join Oda_ozellik ON Odalar.Odaid = Oda_ozellik.Odaid", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;


        }


        public DataTable BosOdaGetir()
        {
           
            SqlDataAdapter da = new SqlDataAdapter("Select *from Odalar where OdaKapasite != OdaAktif ", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;

        }




        
        public DataTable OdaGetir()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select Odaid,OdaNo,OdaKapasite,OdaAktif,OdaKat from Odalar ", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;

        }

        public void OdaEkle(string OdaNo,string  OdaKapasite,string OdaKat)
        {
            
            String Sorgu = "INSERT INTO Odalar(OdaNo,OdaKapasite,OdaKat)VALUES(@OdaNO,@OdaKapasite,@OdaKat)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@OdaNo",OdaNo);
            komut.Parameters.AddWithValue("@OdaKapasite",OdaKapasite );
            komut.Parameters.AddWithValue("@OdaKat",OdaKat);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();
  
        }

        public void OdaSil(int Odaid)
        {
            
            String Sorgu = "DELETE FROM Odalar where Odaid=@Odaid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Odaid",Odaid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }

        public void OdaGuncelle(int Odaid,string OdaNo, string OdaKapasite, string OdaKat)
        {

            String Sorgu = "UPDATE Odalar SET OdaNo=@OdaNo,OdaKapasite=@OdaKapasite,OdaKat=@OdaKat Where Odaid=@Odaid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Odaid",Odaid);
            komut.Parameters.AddWithValue("@OdaNo",OdaNo);
            komut.Parameters.AddWithValue("@OdaKapasite",OdaKapasite);
            komut.Parameters.AddWithValue("@OdaKat",OdaKat);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }






        public void OdaOzellikSil(int Oda_ozellikid)
        {
            SqlBaglantisi bgln = new SqlBaglantisi();

            String Sorgu = "DELETE FROM Oda_ozellik where Oda_ozellikid=@Oda_ozellikid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Oda_ozellikid", Oda_ozellikid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();





        }




        public void OdaOzellikGuncelle(int Oda_ozellikid,string Ozellik, string BaslangicTarih, string BitisTarih,string Durum)
        {
            SqlBaglantisi bgln = new SqlBaglantisi();

            String Sorgu = "UPDATE  Oda_ozellik SET Ozellik=@Ozellik,BaslangicTarih=@BaslangicTarih,BitisTarih=@BitisTarih,Durum=@Durum where Oda_ozellikid=@Oda_ozellikid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Oda_ozellikid", Oda_ozellikid);
            komut.Parameters.AddWithValue("@Ozellik", Ozellik);
            komut.Parameters.AddWithValue("@BaslangicTarih", BaslangicTarih);
            komut.Parameters.AddWithValue("@BitisTarih", BitisTarih);
            komut.Parameters.AddWithValue("@Durum",Durum);


            komut.ExecuteNonQuery();
            bgln.baglanti().Close();


        }


      

        


        public void OdaOzellikEkle(int Odaid,string Ozellik,string BaslangicTarih, string BitisTarih,string Durum)
        {
            SqlBaglantisi bgln = new SqlBaglantisi();

            String Sorgu = "INSERT INTO  Oda_ozellik(Odaid,Ozellik,BaslangicTarih,BitisTarih,Durum)VALUES(@Odaid,@Ozellik,@BaslangicTarih,@BitisTarih,@Durum)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@Odaid", Odaid);
            komut.Parameters.AddWithValue("@Ozellik", Ozellik);
            komut.Parameters.AddWithValue("@BaslangicTarih", BaslangicTarih);
            komut.Parameters.AddWithValue("@BitisTarih",BitisTarih);
            komut.Parameters.AddWithValue("@Durum",Durum);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();


        }
        
    }

    }

