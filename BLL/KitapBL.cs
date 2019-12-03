using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    class KitapBL : IDisposable
    {
        Helper hlp = new Helper();
        public bool KitapEkle(KitapBL ktp)
        {
            SqlParameter[] p = { new SqlParameter("@Ad", ktp.Ad), new SqlParameter("@Yazar", ktp.Yazar), new SqlParameter("@Numara", ogr.Numara), new SqlParameter("@SinifId", ogr.Sinifid) };
            int sonuc = hlp.ExecuteNonQuery("Insert into tblKITAPLAR values(@Ad,@Soyad,@Numara,@SinifId)", p);
            return sonuc > 0;
        }

        public bool KitapGuncelle(Kitap ktp)
        {
            SqlParameter[] p = { new SqlParameter("@Ad", ogr.Ad), new SqlParameter("@Soyad", ogr.Soyad), new SqlParameter("@Numara", ogr.Numara), new SqlParameter("@SinifId", 1), new SqlParameter("@Ogrenciid", ogr.Ogrenciid) };

            int sonuc = hlp.ExecuteNonQuery("Update tblOgrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara,SinifId=@SinifId where OgrenciId=@OgrenciId", p);
            return sonuc > 0;
        }

        public Ogrenci OgrenciBul(int numara)
        {
            SqlParameter[] p = { new SqlParameter("@Numara", numara) };
            SqlDataReader dr = hlp.ExecuteReader("Select Ad,Soyad,Numara,SinifId,OgrenciId from tblOgrenciler Where Numara=@Numara", p);
            Ogrenci o = null;
            if (dr.Read())
            {
                o = new Ogrenci();
                o.Ad = dr["Ad"].ToString();
                o.Soyad = dr["Soyad"].ToString();
                o.Numara = dr["Numara"].ToString();
                o.Sinifid = Convert.ToInt32(dr["SinifId"]);
                o.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
            }
            dr.Close();

            return o;
        }
        public bool OgrenciSil(int ogrenciid)
        {
            SqlParameter[] p = { new SqlParameter("@OgrenciId", ogrenciid) };
            return hlp.ExecuteNonQuery("delete from tblOgrenciler where Ogrenciid=@OgrenciId", p) > 0;
        }
        public void Dispose()
        {
            hlp.Dispose();
        }
    }
    {
    }
}
