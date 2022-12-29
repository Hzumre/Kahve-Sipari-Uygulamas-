using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Kahveci.Entities.Entities;
using WFA_Kahveci.Entities.Enums;

namespace WFA_Kahveci.Entities.Interfaces
{
    public interface ISiparis
    {
        
        public Urun Urun { get; set; }
        public byte Adet { get; set; }
        public Shot Shot { get; set; }
        public BoyutType Boyut { get; set; }
        public Sut Sut { get; set; }
        public double ToplamTutar { get; }
    }
}
