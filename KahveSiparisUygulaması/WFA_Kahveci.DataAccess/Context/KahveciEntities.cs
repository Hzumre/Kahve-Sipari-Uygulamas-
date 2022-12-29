using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Kahveci.Entities.Entities;

namespace WFA_Kahveci.DataAccess.Context
{
    public class KahveciEntities
    {
      
        public static List<Urun> Urunler { get; set; }
        public static List<Musteri> Musteriler { get; set; }
        public static List<Siparis> Siparisler { get; set; }
    }
}
