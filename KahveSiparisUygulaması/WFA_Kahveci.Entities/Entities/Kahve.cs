using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Kahveci.Entities.Enums;

namespace WFA_Kahveci.Entities.Entities
{
    public class Kahve
    {
        public string Ad { get; set; }
        public byte Adet { get; set; }
        public double Fiyat { get; set; }
        public BoyutType Boyut { get; set; }
        public Shot Shot { get; set; }
        public Sut Sut { get; set; }

        public override string ToString()
        {
            return this.Ad;
        }
        public string GetInfo()
        {
            string kahve = $"{this.Ad},{this.Shot},{this.Sut},{this.Boyut},{this.Adet} : {this.Fiyat}";
            return kahve;
        }

    }
}
