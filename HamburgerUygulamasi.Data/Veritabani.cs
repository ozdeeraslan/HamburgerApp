using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerUygulamasi.Data
{
    // Static bir sınıf tanimla (menü ekleme ve ekstra malzeme ekleme icin)
    public static class Veritabani
    {
        public static Menu MenuAd { get; set; } = new Menu();


        public static List<Malzeme> EkstraMalzemeler { get; set; } = new List<Malzeme>();

    }
}
