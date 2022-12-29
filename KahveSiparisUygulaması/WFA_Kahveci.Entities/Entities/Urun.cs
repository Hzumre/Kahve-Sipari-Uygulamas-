using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Kahveci.Entities.Interfaces;

namespace WFA_Kahveci.Entities.Entities
{
    public class Urun
    {
        public Kahve Kahve { get; set; }
        public Sicak_Icecek Sicak_Icecek { get; set; }
        public Soguk_Icecek Soguk_Icecek { get; set; }

        
    }
}
