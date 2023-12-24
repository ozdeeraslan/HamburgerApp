using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerUygulamasi.Data
{
    public class Malzeme
    {
        public string MalzemeAd { get; set; } 
        public decimal MalzemeFiyat { get; set; } 

        public Malzeme(string ad, decimal fiyat)
        {
            MalzemeAd = ad;
            MalzemeFiyat = fiyat;
        }

        public override string ToString()
        {
            return $"{MalzemeAd}";
        }

        
    }
}
