using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    class KullaniciBL : IDisposable
    {
        Helper hlp = new Helper();

        public List<Sinif> SinifListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select SinifId,SinifAd,Kontenjan from tblSiniflar", null);
            List<Sinif> lst = new List<Sinif>();
            while (dr.Read())
            {
                lst.Add(new Sinif { Kontenjan = Convert.ToInt32(dr["Kontenjan"]), Sinifad = dr["SinifAd"].ToString(), Sinifid = Convert.ToInt32(dr["SinifId"]) });
            }
            dr.Close();
            lst.Insert(0, new Sinif { Sinifad = "Seçiniz" });
            return lst;
        }


        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
    {
    }
}
