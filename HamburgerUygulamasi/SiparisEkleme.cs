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
    public partial class SiparisEkleme : Form
    {
        public static List<Menu> menuListesi;
        public static List<Malzeme> ekstraMalzemeler;
        public static List<Siparis> siparisler;

        private decimal toplamSiparisTutari = 0;

        public SiparisEkleme()
        {
            InitializeComponent();



            // Menü listesini oluştur
            menuListesi = new List<Menu>
            {
                new Menu("Big King Menü", 20),
                new Menu("Double King Chicken Menü", 18),
                new Menu("Steakhouse Menü",  15),
                new Menu("Whooper Menü",  17),
                new Menu("Whooper Jr. Menü",  13),
                new Menu("Chicken Royal Menü",  14)
            };

            // Ekstra malzemeleri oluştur
            ekstraMalzemeler = new List<Malzeme>
            {
                new Malzeme("Ketcap", 0.5m),
                new Malzeme("Mayonez", 0.75m),
                new Malzeme("Hardal", 1.0m),
                new Malzeme("BBQ", 1.25m),
                new Malzeme("Ranch", 1.5m),
                new Malzeme("Buffalo", 1.75m)
            };

            // ComboBox'a menüleri ekle
            foreach (var menu in menuListesi)
            {
                cmbMenuSec.Items.Add(menu);
            }

            // CheckBox'lara ekstra malzemeleri ekle
            foreach (var malzeme in ekstraMalzemeler)
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = malzeme.MalzemeAd,
                    Tag = malzeme,
                    AutoSize = true
                };
                flowLayoutPanel1.Controls.Add(checkBox);
            }

            // Yeni bir sipariş listesi oluştur
            siparisler = new List<Siparis>();
            
            // MenuAdi'ni ComboBox'a ekle
            cmbMenuSec.Items.Add(Veritabani.MenuAd);


            // flowLayoutPanel'e ekleme
            foreach (var malzeme in Veritabani.EkstraMalzemeler)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = malzeme.ToString();
                checkBox.Tag = malzeme; 
                flowLayoutPanel1.Controls.Add(checkBox);

            }
        }


        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            // Yeni bir sipariş oluştur
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.Menu = (Menu)cmbMenuSec.SelectedItem;

            if (cmbMenuSec.SelectedItem != null && cmbMenuSec.SelectedItem is Menu)
            {
                Menu secilenMenu = (Menu)cmbMenuSec.SelectedItem;

                //string secilenMenu = cmbMenuSec.SelectedItem.ToString();

                yeniSiparis.Boyut = rdbKucuk.Checked ? MenuBoyutu.Kucuk : (rdbOrta.Checked ? MenuBoyutu.Orta : MenuBoyutu.Buyuk);
                yeniSiparis.Adet = (int)nudAdet.Value; // nudAdet bileşeninden seçilen adet sayısını ekle

                // Seçilen ekstra malzemeleri ekle
                foreach (CheckBox checkBox in flowLayoutPanel1.Controls)
                {
                    if (checkBox.Checked)
                    {
                        yeniSiparis.EkstraMalzemeler.Add((Malzeme)checkBox.Tag);
                    }
                }
                // Sipariş listesine ekle
                siparisler.Add(yeniSiparis);

                // Sipariş listesini göster
                lstTumSiparisler.Items.Clear();
                foreach (var siparis in siparisler)
                {
                    lstTumSiparisler.Items.Add(siparis.ToString());
                }

                // Toplam tutarı label'a yazdir
                toplamSiparisTutari += yeniSiparis.HesaplaToplamTutar();
                lblToplamTutar.Text = $"{toplamSiparisTutari} TL"; // Label'ı güncelle
            }
            else
            {
                MessageBox.Show("Lütfen önce bir menü seçin!");
            }
        }

    }
}
