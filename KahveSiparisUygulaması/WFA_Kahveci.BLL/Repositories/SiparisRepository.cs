using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Kahveci.DataAccess.Context;
using WFA_Kahveci.Entities.Entities;
using WFA_Kahveci.Entities.Enums;

namespace WFA_Kahveci.BLL.Repositories
{
    public class SiparisRepository
    {
        KahveciEntities db = new();
        public void Add(Siparis s)
        {
            KahveciEntities.Siparisler.Add(s);
        }

        public List<Siparis> GetAll()
        {
            return KahveciEntities.Siparisler;
        }

        public Siparis SiparisOlustur(Urun urun,byte adet,BoyutType boyut,Sut sut,Shot shot)
        {
            return new Siparis() { Urun = urun, Adet = adet, Boyut = boyut, Sut = sut, Shot = shot };
        }
    }
}
