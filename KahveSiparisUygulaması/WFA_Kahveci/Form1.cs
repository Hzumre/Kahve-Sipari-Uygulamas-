
using WFA_Kahveci.Entities.Entities;
using WFA_Kahveci.Entities.Enums;

namespace WFA_Kahveci
{
    public partial class Form1 : Form
    {
        Siparis yeniSiparis;
        public Form1()
        {
            InitializeComponent();
        }

        List<Kahve> kahve = new List<Kahve>()
            {

                new Kahve() { Ad = "Misto" ,Fiyat = 4.5 },
                new Kahve() { Ad = "Americano", Fiyat = 5.75 },
                new Kahve() { Ad = "Bianco", Fiyat = 6 },
                new Kahve() { Ad = "Cappucino", Fiyat = 7.5 },
                new Kahve() { Ad = "Macchiato", Fiyat = 6.75 },
                new Kahve() { Ad = "Con Panna", Fiyat = 8 },
                new Kahve() { Ad = "Mocha", Fiyat = 7.75 },
            };


        List<Sicak_Icecek> sýcakIcecek = new List<Sicak_Icecek>()
            {

                new Sicak_Icecek() { Ad = "Çay" ,Fiyat = 3 },
                new Sicak_Icecek() { Ad = "Hot Chocolate ", Fiyat = 4.5 },
                new Sicak_Icecek() { Ad = "Chai Tea Latte", Fiyat = 6.5 },
                
            };

        List<Soguk_Icecek> sogukIcecek = new List<Soguk_Icecek>()
            {

                new Soguk_Icecek() { Ad = "Kola" ,Fiyat = 5.5 },
                new Soguk_Icecek() { Ad = "Limonata ", Fiyat = 5.5 },
                new Soguk_Icecek() { Ad = "Sprite", Fiyat = 5.5 },
                new Soguk_Icecek() { Ad = "Portakal Suyu",  Fiyat = 5.5 },

            };


        private void Form1_Load(object sender, EventArgs e)
        {
            UrunDoldur();
        }


        private void UrunDoldur()
        {

            foreach (Kahve item in kahve)
            {
                
                cmbKahve.Items.Add(item);
            }
            cmbKahve.Items.Insert(0, "Lütfen Seçiniz...");
            cmbKahve.SelectedIndex = 0;


                   foreach (Sicak_Icecek item in sýcakIcecek)
            {

                cmbSicak.Items.Add(item);
            }
            cmbSicak.Items.Insert(0, "Lütfen Seçiniz...");
            cmbSicak.SelectedIndex = 0;


            foreach (Soguk_Icecek item in sogukIcecek)
            {

                cmbSoguk.Items.Add(item);
            }
            cmbSoguk.Items.Insert(0, "Lütfen Seçiniz...");
            cmbSoguk.SelectedIndex = 0;
        }

        
    private void SiparisleriListele()
        {
            //lstSiparisListesi.Items.Clear();
            //foreach(Siparis siparis in siparisRepository.GetAll())
            //{
            //    lstSiparisListesi.Items.Add(siparis);
            //}
        }
        

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Kahve kahve = new();
            kahve = (Kahve)cmbKahve.SelectedItem;
            kahve.Adet =(byte) numericUpDown1.Value;
            kahve.Sut = rbYagsýz.Checked ? Sut.Yagsýz : Sut.Soya;
            kahve.Shot= cb1x.Checked ?Shot._1x: Shot._2x;
            kahve.Boyut= rbGrande.Checked ? BoyutType.Grande : rbVenti.Checked ? BoyutType.Venti : BoyutType.Tall;


            Soguk_Icecek sogukIcecek = new();
            sogukIcecek= (Soguk_Icecek)cmbSoguk.SelectedItem;
            sogukIcecek.Adet= (byte)numericUpDown2.Value;
            sogukIcecek.Boyut= rbGrande.Checked ? BoyutType.Grande : rbVenti.Checked ? BoyutType.Venti : BoyutType.Tall;


            Sicak_Icecek sicakIcecek = new();
            sicakIcecek= (Sicak_Icecek)cmbSicak.SelectedItem;
            sicakIcecek.Adet= (byte)numericUpDown3.Value;
            sicakIcecek.Boyut= rbGrande.Checked ? BoyutType.Grande : rbVenti.Checked ? BoyutType.Venti : BoyutType.Tall;

            Urun urun = new();
            urun.Kahve = kahve;
            urun.Sicak_Icecek = sicakIcecek;
            urun.Soguk_Icecek = sogukIcecek;

            yeniSiparis = new();
            yeniSiparis.Urun = urun;

            lstSiparisListesi.Items.Add(kahve.GetInfo());
            lstSiparisListesi.Items.Add(sicakIcecek.GetInfo());
            lstSiparisListesi.Items.Add(sogukIcecek.GetInfo());


        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            double toplamTutar = yeniSiparis.ToplamTutar;
            MessageBox.Show(toplamTutar.ToString());
        }
    }
}