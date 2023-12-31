﻿using HamburgerUygulamasi.Data;
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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        public void FormGoster(Form secilenForm)
        {
            secilenForm.StartPosition = 0;

            // bu ana formun cocuklari (MDI: ic ice acilan form) icerisinde gezelim.
            bool durum = false; // en basta ana formun hic cocugu olmadigi icin foreach'e girmez. O yüzden durum degiskenini tanimladik.

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true;
                    form.Show(); // istenen formun acilmasi
                }
                else
                    form.Close(); // acik olan varsa kapatilsin
            }

            if (!durum) // eger ilk acilis ise ve hic cocuk yoksa o zaman burayi calistir.
            {
                secilenForm.MdiParent = this;
                secilenForm.Show();
            }
        }

        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisEkleme());
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgileri());

        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new EkstraMalzemeEkleme());

        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new MenuEkleme());

        }
    }
}

