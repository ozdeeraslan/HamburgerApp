namespace HamburgerUygulamasi
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            siparisYönetimiToolStripMenuItem = new ToolStripMenuItem();
            siparisOlusturToolStripMenuItem = new ToolStripMenuItem();
            siparisBilgileriToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            ürünEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparisYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparisYönetimiToolStripMenuItem
            // 
            siparisYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparisOlusturToolStripMenuItem, siparisBilgileriToolStripMenuItem });
            siparisYönetimiToolStripMenuItem.Name = "siparisYönetimiToolStripMenuItem";
            siparisYönetimiToolStripMenuItem.Size = new Size(129, 24);
            siparisYönetimiToolStripMenuItem.Text = "Siparis Yönetimi";
            // 
            // siparisOlusturToolStripMenuItem
            // 
            siparisOlusturToolStripMenuItem.Name = "siparisOlusturToolStripMenuItem";
            siparisOlusturToolStripMenuItem.Size = new Size(191, 26);
            siparisOlusturToolStripMenuItem.Text = "Siparis Olustur";
            siparisOlusturToolStripMenuItem.Click += siparisOlusturToolStripMenuItem_Click;
            // 
            // siparisBilgileriToolStripMenuItem
            // 
            siparisBilgileriToolStripMenuItem.Name = "siparisBilgileriToolStripMenuItem";
            siparisBilgileriToolStripMenuItem.Size = new Size(191, 26);
            siparisBilgileriToolStripMenuItem.Text = "Siparis Bilgileri";
            siparisBilgileriToolStripMenuItem.Click += siparisBilgileriToolStripMenuItem_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ürünEkleToolStripMenuItem, ekstraMalzemeEkleToolStripMenuItem });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(116, 24);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // ürünEkleToolStripMenuItem
            // 
            ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            ürünEkleToolStripMenuItem.Size = new Size(227, 26);
            ürünEkleToolStripMenuItem.Text = "Menü Ekle";
            ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            ekstraMalzemeEkleToolStripMenuItem.Size = new Size(227, 26);
            ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            ekstraMalzemeEkleToolStripMenuItem.Click += ekstraMalzemeEkleToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            Text = "AnaForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparisYönetimiToolStripMenuItem;
        private ToolStripMenuItem siparisOlusturToolStripMenuItem;
        private ToolStripMenuItem siparisBilgileriToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
    }
}