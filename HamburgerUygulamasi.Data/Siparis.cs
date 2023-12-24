using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerUygulamasi.Data
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        public MenuBoyutu Boyut { get; set; }
        public List<Malzeme> EkstraMalzemeler { get; set; } = new List<Malzeme>();
        public int Adet { get; set; }

        public Siparis()
        {
            Menu = new Menu(); // Menu özelliğini başlat
        }

        public decimal HesaplaToplamTutar()
        {
            decimal toplam = Menu != null ? Menu.MenuFiyat : 0; // Menu objesinin null olup olmadığını kontrol et

            if (EkstraMalzemeler != null)
            {
                foreach (var malzeme in EkstraMalzemeler)
                {
                    if (malzeme != null)
                    {
                        toplam += malzeme.MalzemeFiyat;
                    }
                }
            }

            return toplam * Adet;
        }

        public override string ToString()
        {
            string malzemeListesi = string.Join(", ", EkstraMalzemeler.Select(m => m.MalzemeAd));
            return $"{Menu.MenuAd} x {Adet} Adet, {Boyut} Boy, ({malzemeListesi}) - Toplam Tutar: {HesaplaToplamTutar()} TL";


        }
    }

}
