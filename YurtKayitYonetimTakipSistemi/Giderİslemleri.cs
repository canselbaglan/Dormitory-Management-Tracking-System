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
    class Giderİslemleri
    {

        SqlBaglantisi bgln = new SqlBaglantisi();

        public DataTable GiderGetir()

        {
            
                SqlDataAdapter da = new SqlDataAdapter("select *from Giderler", bgln.baglanti());
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                bgln.baglanti().Close();
                return tablo;



        }


        public void GiderEkle(string Tarih, string MutfakMalzeme, string TemizlikMalzeme, string Tamirat,string  Su,string  Elektrik,string İnternet,string Personel,string Diger)
        {


            SqlBaglantisi bgln = new SqlBaglantisi();
            if (MessageBox.Show("Kayıt Ekleme işlemini onaylıyor musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                String sorgu = " INSERT INTO Giderler(Tarih,MutfakMalzeme,TemizlikMalzeme,Tamirat,Su,Elektrik,İnternet,Personel,Diger)VALUES(@Tarih,@MutfakMalzeme,@TemizlikMalzeme,@Tamirat,@Su,@Elektrik,@İnternet,@Personel,@Diger) ";
                SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());

                komut.Parameters.AddWithValue("@Tarih",Tarih);
                komut.Parameters.AddWithValue("@MutfakMalzeme",MutfakMalzeme);
                komut.Parameters.AddWithValue("@TemizlikMalzeme",TemizlikMalzeme);
                komut.Parameters.AddWithValue("@Tamirat",Tamirat);
                komut.Parameters.AddWithValue("@Su",Su);
                komut.Parameters.AddWithValue("@Elektrik",Elektrik);
                komut.Parameters.AddWithValue("@İnternet",İnternet );
                komut.Parameters.AddWithValue("@Personel",Personel );
                komut.Parameters.AddWithValue("@Diger",Diger);
                komut.ExecuteNonQuery();
                bgln.baglanti().Close();


                MessageBox.Show("Kayıt Eklendi");

            }

            else
            {

                MessageBox.Show("Kayıt Ekleme işlemi iptal edildi");

            }




        }



        public void GiderSil(int Giderid)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            if (MessageBox.Show("Kayıt Silme işlemini onaylıyor musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String sorgu = "DELETE from Giderler where Giderid=@Giderid";
                SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
                komut.Parameters.AddWithValue("@Giderid", Giderid);
                komut.ExecuteNonQuery();
                bgln.baglanti().Close();

                MessageBox.Show("Kayıt Silindi");

            }


            else
            {

                MessageBox.Show("Kayıt Silme işlemi iptal edildi");

            }


        }


        public void GiderGuncelle(int Giderid, string Tarih, string MutfakMalzeme, string TemizlikMalzeme, string Tamirat, string Su, string Elektrik, string İnternet, string Personel,string Diger)
        {

            SqlBaglantisi bgln = new SqlBaglantisi();
            if (MessageBox.Show("Kayıt Güncelleme işlemini onaylıyor musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                string sorgu = "UPDATE Giderler SET Tarih=@Tarih,MutfakMalzeme=@MutfakMalzeme,TemizlikMalzeme=@TemizlikMalzeme,Tamirat=@Tamirat,Su=@Su,Elektrik=@Elektrik,İnternet=@İnternet,Personel=@Personel,Diger=@Diger where Giderid=@Giderid";
                SqlCommand komut = new SqlCommand(sorgu, bgln.baglanti());
                komut.Parameters.AddWithValue("@Giderid",Giderid);
                komut.Parameters.AddWithValue("@Tarih",Tarih);
                komut.Parameters.AddWithValue("@MutfakMalzeme",MutfakMalzeme);
                komut.Parameters.AddWithValue("@TemizlikMalzeme",TemizlikMalzeme);
                komut.Parameters.AddWithValue("@Tamirat",Tamirat);
                komut.Parameters.AddWithValue("@Su",Su);
                komut.Parameters.AddWithValue("@Elektrik",Elektrik);
                komut.Parameters.AddWithValue("@İnternet",İnternet);
                komut.Parameters.AddWithValue("@Personel",Personel);
                komut.Parameters.AddWithValue("@Diger",Diger);
                komut.ExecuteNonQuery();
                bgln.baglanti().Close();

                MessageBox.Show("Kayıt Güncellendi");

            }

            else
            {

                MessageBox.Show("Kayıt Güncelleme işlemi iptal edildi");
            }





        }



    }
}
