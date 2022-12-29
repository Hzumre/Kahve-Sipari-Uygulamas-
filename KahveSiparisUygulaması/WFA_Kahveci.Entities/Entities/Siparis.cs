using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Kahveci.Entities.Enums;
using WFA_Kahveci.Entities.Interfaces;

namespace WFA_Kahveci.Entities.Entities
{
    public class Siparis 
    {

        public double ToplamTutar
        {
            get
            {
                double shotFiyat = Urun.Kahve.Shot == Shot._1x ? 0.75 : 1.5;
                double sutFiyat = Urun.Kahve.Sut == Sut.Yagsız ? 0.5 : 1;
                double boyutKatsayi = Urun.Kahve.Boyut == BoyutType.Tall ? 1 : Urun.Kahve.Boyut == BoyutType.Grande ? 1.25 : 1.75;

                double kahveFiyat = (Urun.Kahve.Fiyat * Urun.Kahve.Adet + shotFiyat + sutFiyat) * boyutKatsayi;



                double boyutKatsayi1 = Urun.Sicak_Icecek.Boyut == BoyutType.Tall ? 1 : Urun.Sicak_Icecek.Boyut == BoyutType.Grande ? 1.25 : 1.75;

                double sicakIcecekFiyat = Urun.Sicak_Icecek.Fiyat * Urun.Sicak_Icecek.Adet * boyutKatsayi1;


                double boyutKatsayi2 = Urun.Soguk_Icecek.Boyut == BoyutType.Tall ? 1 : Urun.Soguk_Icecek.Boyut == BoyutType.Grande ? 1.25 : 1.75;

                double sogukIcecekFiyat = Urun.Soguk_Icecek.Fiyat * Urun.Soguk_Icecek.Adet * boyutKatsayi2;


                return kahveFiyat +sicakIcecekFiyat+sogukIcecekFiyat;




            }
        }


        public Urun Urun { get ; set ; }


    }
}
