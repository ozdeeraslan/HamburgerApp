using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerUygulamasi.Data
{
    public class Menu
    {
        public Menu(string ad, decimal fiyat)
        {
            MenuAd = ad;
            MenuFiyat = fiyat;
        }

        public Menu()
        {
            
        }

        public string MenuAd { get; set; }
        public decimal MenuFiyat { get; set; }


        public override string ToString()
        {
            return $"{MenuAd}"; 
        }

        
    }
}
