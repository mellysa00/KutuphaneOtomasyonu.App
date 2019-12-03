using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public class Kitap
    {
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public int Adet { get; set; }
        public string Yazar { get; set; }
        public int KitapTuruId { get; set; }
    }
}
