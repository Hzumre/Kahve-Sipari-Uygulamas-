using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Kahveci.Entities.Interfaces;

namespace WFA_Kahveci.Entities.Entities
{
    public class Musteri:IMusteri
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
    }
}
