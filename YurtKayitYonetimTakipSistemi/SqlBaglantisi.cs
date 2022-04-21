using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayitYonetimTakipSistemi
{
   public class SqlBaglantisi
    {

        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-FP752VET\\SQLEXPRESS;Initial Catalog=YurtKayitTakipSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
