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
    class PersonelOdaİslemleri
    {

        SqlBaglantisi bgln = new SqlBaglantisi();



        public DataTable PersonelOdaGetir()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT Personeller_Odalar_id,PersonelAd,PersonelSoyad,PersonelTc,OdaNo,OdaKat FROM Personeller_Odalar join Personeller ON Personeller.Personelid = Personeller_Odalar.Personelid join Odalar ON Personeller_Odalar.Odaid = Odalar.Odaid", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }

        //"SELECT PersonelAd,PersonelSoyad,PersonelTc,OdaNo,Tarih,Gorevdurumu FROM Personeller_Odalar join Personeller ON Personeller.Personelid = Personeller_Odalar.Personelid join Odalar ON Personeller_Odalar.Odaid = Odalar.Odaid", bgln.baglanti()

        //SELECT PersonelAd,PersonelSoyad,PersonelTc,OdaNo,Tarih,GorevDurum FROM Personeller_Odalar join Personeller ON Personeller.Personelid = Personeller_Odalar.Personelid join Odalar ON Personeller_Odalar.Odaid = Odalar.Odaid join  PersonelGorev ON Personeller_Odalar.Personeller_Odalar_id = PersonelGorev.Personeller_Odalar_id
       
        
        public DataTable PersonelOdaGorevGetir()
        {


            SqlDataAdapter da = new SqlDataAdapter("SELECT Gorevid, Tarih,pp.PersonelAd, pp.PersonelSoyad,pp.PersonelTc,oo.OdaNo,GorevDurum FROM Personel_Gorev pg join Personeller_Odalar po ON po.Personeller_Odalar_id = pg.Personeller_Odalar_id join Odalar od ON po.Odaid = od.Odaid join Personeller pp on pp.Personelid = po.Personelid join Odalar oo ON oo.Odaid=po.Odaid", bgln.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }


        public void PersonelOdaEkle(int Personelid, int Odaid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "INSERT INTO Personeller_Odalar (Personelid,Odaid) VALUES (@Personelid,@Odaid)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@Personelid",Personelid);
            komut.Parameters.AddWithValue("@Odaid", Odaid);
           
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }






        public void PersonelOdaSil(int Personeller_Odalar_id)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "DELETE From Personeller_Odalar Where Personeller_Odalar_id=@Personeller_Odalar_id";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Personeller_Odalar_id", Personeller_Odalar_id);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }




        public void PersonelOdaGuncelle(int Personeller_Odalar_id, int Personelid, int Odaid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();

            String Sorgu = "UPDATE Personeller_Odalar SET Personelid=@Personelid,Odaid=@Odaid  Where Personeller_Odalar_id=@Personeller_Odalar_id";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@Personeller_Odalar_id", Personeller_Odalar_id);
            komut.Parameters.AddWithValue("@Personelid", Personelid);
            komut.Parameters.AddWithValue("@Odaid", Odaid);
           
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }


        public void PersonelGorevEkle( int Personeller_Odalar_id, string Tarih, string GorevDurum)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "INSERT INTO Personel_Gorev(Personeller_Odalar_id,Tarih,GorevDurum) VALUES (@Personeller_Odalar_id,@Tarih,@GorevDurum)";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());

            komut.Parameters.AddWithValue("@Personeller_Odalar_id", Personeller_Odalar_id);
            komut.Parameters.AddWithValue("@Tarih", Tarih);
            komut.Parameters.AddWithValue("@GorevDurum", GorevDurum);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();

        }

         public void PersonelGorevSil(int Gorevid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            String Sorgu = "DELETE From Personel_Gorev Where Gorevid=@Gorevid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Gorevid",Gorevid);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }
        public void PersonelGorevGuncelle(int Gorevid,string Tarih, string GorevDurum)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();

            String Sorgu = "UPDATE Personel_Gorev SET Tarih=@Tarih,GorevDurum=@GorevDurum Where Gorevid=@Gorevid";
            SqlCommand komut = new SqlCommand(Sorgu, bgln.baglanti());
            komut.Parameters.AddWithValue("@Gorevid", Gorevid);
           // komut.Parameters.AddWithValue("@Personeller_Odalar_id", Personeller_Odalar_id);
            komut.Parameters.AddWithValue("@Tarih", Tarih);
            komut.Parameters.AddWithValue("@GorevDurum", GorevDurum);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();



        }
        

        public DataTable PersonelGorevGetir()
        {



            SqlDataAdapter da = new SqlDataAdapter("SELECT Tarih, pp.PersonelAd, pp.PersonelSoyad, pp.PersonelTc, oo.OdaNo, GorevDurum FROM Personel_Gorev pg join Personeller_Odalar po ON po.Personeller_Odalar_id = pg.Personeller_Odalar_id join Odalar od ON po.Odaid = od.Odaid join Personeller pp on pp.Personelid = po.Personelid join Odalar oo ON oo.Odaid = po.Odaid where GorevDurum = 'TAMAMLANMADI'", bgln.baglanti());
            
               
                                           
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            bgln.baglanti().Close();
            return tablo;



        }



    }
}
