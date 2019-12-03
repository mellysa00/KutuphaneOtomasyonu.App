using KitapDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace KitapBLL
{
    public class KitapBL : IDisposable
    {
        Helper hlp = new Helper();

        public bool KitapEkle(Kitap ktp)
        {
            System.Data.SqlClient.SqlParameter[] p = { new SqlParameter("@KitapAd", ktp.KitapAd), new SqlParameter("@KitapId", ktp.KitapId), new SqlParameter("@KitapTuruId", ktp.KitapTuruId), new SqlParameter("@Yazar", ktp.Yazar) };
            int sonuc = hlp.ExecuteNonQuery("Insert into tblKITAPLAR values(@KitapAd,@KitapId,@KitapTuruId,@Yazar)", p);
            return sonuc > 0;
        }

        public bool KitapGuncelle(Kitap ktp)
        {
            System.Data.SqlClient.SqlParameter[] p = { new SqlParameter("@KitapAd", ktp.KitapAd), new SqlParameter("@KitapId", ktp.KitapId), new SqlParameter("@KitapTuruId", ktp.KitapTuruId), new SqlParameter("@Yazar", ktp.Yazar) };
            int sonuc = hlp.ExecuteNonQuery("Insert into tblKITAPLAR values(@KitapAd,@KitapId,@KitapTuruId,@Yazar)", p);
            return sonuc > 0;
        }

        public Kitap KitapBul(string KitapAd)
        {
            SqlParameter[] p = { new SqlParameter("@KitapAd", KitapAd) };
            SqlDataReader dr = hlp.ExecuteReader("Select KitapAd,KitapId,KitapTuruId,Yazar from tblKITAPLAR Where KitapAd=@KitapAd", p);
            Kitap k = null;
            if (dr.Read())
            {
                k = new Kitap();
                k.KitapAd = dr["KitapAd"].ToString();
                k.Yazar = dr["Yazar"].ToString();
                k.KitapTuruId = Convert.ToInt32(dr["KitapTuruId"]);
                k.KitapId = Convert.ToInt32(dr["KitapId"]);
            }
            dr.Close();

            return k;
        }
        public bool KitapSil(int KitapId)
        {
            SqlParameter[] p = { new SqlParameter("@KitapId", KitapId) };
            return hlp.ExecuteNonQuery("delete from tblKITAPLAR where KitapId=@KitapId", p) > 0;
        }
        public void Dispose()
        {
            hlp.Dispose();
        }
    }
    

    }

