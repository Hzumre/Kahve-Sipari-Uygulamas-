using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Kahveci.Entities.Interfaces
{
    public interface IMusteri
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
    }
}
