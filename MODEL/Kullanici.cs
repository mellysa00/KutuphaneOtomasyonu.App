using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }

        string ad;
        string sifre;

        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public string Sifre { get => sifre; set => sifre = value.ToUpper(); }


    }
}

