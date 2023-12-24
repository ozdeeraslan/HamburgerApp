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
    public partial class MenuEkleme : Form
    {

        public MenuEkleme()
        {
            InitializeComponent(); 

        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            // Kullanıcı tarafından girilen verileri al
            string menuAdi = txtMenuAd.Text;
            decimal fiyat = nudMenuFiyat.Value;

            // Yeni bir menü öğesi oluştur
            Menu yeniMenu = new Menu(menuAdi, fiyat);
            
            // Veritabanı sınıfındaki MenuAdi'ni güncelle
            Veritabani.MenuAd = yeniMenu;

            // Diğer forma geçiş yap
            SiparisEkleme siparisEklemeFormu = new SiparisEkleme();

            // Başarılı kayıt mesajı göster
            MessageBox.Show("Menü başarıyla eklendi!");


        }
    }
}
