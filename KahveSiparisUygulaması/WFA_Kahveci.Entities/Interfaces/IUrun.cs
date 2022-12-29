using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WFA_Kahveci.Entities.Interfaces
{
    public interface IUrun
    {
        public string Tur { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        
    }
}
