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
    public class UrunRepository
    {
        public List<Urun> Urunler()
        {
            
            return KahveciEntities.Urunler = new List<Urun>()

            {
                
                new Urun() { Ad = "Misto",Tur="Kahve" ,Fiyat = 4.5 },
                new Urun() { Ad = "Americano", Tur = "Kahve", Fiyat = 5.75 },
                new Urun() { Ad = "Bianco", Tur = "Kahve", Fiyat = 6 },
                new Urun() { Ad = "Cappucino", Tur = "Kahve", Fiyat = 7.5 },
                new Urun() { Ad = "Macchiato", Tur = "Kahve", Fiyat = 6.75 },
                new Urun() { Ad = "Con Panna", Tur = "Kahve", Fiyat = 8 },
                new Urun() { Ad = "Mocha", Tur = "Kahve", Fiyat = 7.75 },
            };


            



        }
    }
}
