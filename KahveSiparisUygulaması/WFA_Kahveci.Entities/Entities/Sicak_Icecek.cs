using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Kahveci.Entities.Enums;

namespace WFA_Kahveci.Entities.Entities
{
    public class Sicak_Icecek
    {
        public string Ad { get; set; }
        public byte Adet { get; set; }
        public double Fiyat { get; set; }
        public BoyutType Boyut { get; set; }
        public override string ToString()
        {
            return this.Ad;
        }

        public string GetInfo()
        {
            string sicak = $"{this.Ad},{this.Boyut},{this.Adet} : {this.Fiyat}";
            return sicak;
        }
    }
}
