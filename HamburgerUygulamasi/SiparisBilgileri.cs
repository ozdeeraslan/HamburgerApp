using HamburgerUygulamasi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerUygulamasi
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();

            GuncelleSiparisBilgileri();
            
        }

        private void SiparisEkle(Siparis siparis)
        {
            if (siparis != null && siparis.EkstraMalzemeler != null)
            {
                lstTumSiparisler.Items.Add(siparis.ToString());
            }
        }

        public void GuncelleSiparisBilgileri()
        {
            lstTumSiparisler.Items.Clear();
            if (SiparisEkleme.siparisler != null)
            {
                foreach (var siparis in SiparisEkleme.siparisler)
                {
                    SiparisEkle(siparis); // Sipariş listesini güncelle
                }
            }

            decimal toplamTutar = 0;
            int toplamSiparisSayisi = 0;
            decimal ekstraMalzemeTutari = 0;

            if (SiparisEkleme.siparisler != null)
            {
                foreach (var siparis in SiparisEkleme.siparisler)
                {
                    if (siparis != null && siparis.EkstraMalzemeler != null)
                    {
                        toplamTutar += siparis.HesaplaToplamTutar();
                        toplamSiparisSayisi += siparis.Adet;

                        // Ekstra malzemelerin null olmadığından ve her birinin null olmadığından emin olun
                        if (siparis.EkstraMalzemeler.Any(m => m == null))
                            continue;

                        foreach (var malzeme in siparis.EkstraMalzemeler)
                        {
                            if (malzeme != null)
                            {
                                ekstraMalzemeTutari += malzeme.MalzemeFiyat;
                            }
                        }
                    }
                }

                lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar} TL";
                lblToplamSiparisSayisi.Text = $"Toplam Sipariş Sayısı: {toplamSiparisSayisi}";
                lblEkstraMalzemeTutari.Text = $"Toplam Ekstra Malzeme Tutarı: {ekstraMalzemeTutari} TL";
            }
        }
    }

}
