namespace HamburgerUygulamasi
{
    partial class SiparisBilgileri
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
            lblEkstraMalzemeTutari = new Label();
            label7 = new Label();
            lblToplamSiparisSayisi = new Label();
            label5 = new Label();
            lblToplamTutar = new Label();
            label2 = new Label();
            lstTumSiparisler = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEkstraMalzemeTutari
            // 
            lblEkstraMalzemeTutari.BorderStyle = BorderStyle.Fixed3D;
            lblEkstraMalzemeTutari.ForeColor = Color.Red;
            lblEkstraMalzemeTutari.Location = new Point(694, 243);
            lblEkstraMalzemeTutari.Name = "lblEkstraMalzemeTutari";
            lblEkstraMalzemeTutari.Size = new Size(294, 25);
            lblEkstraMalzemeTutari.TabIndex = 15;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(694, 199);
            label7.Name = "label7";
            label7.Size = new Size(294, 31);
            label7.TabIndex = 14;
            label7.Text = "Ekstra Malzeme Geliri";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.BorderStyle = BorderStyle.Fixed3D;
            lblToplamSiparisSayisi.ForeColor = Color.Red;
            lblToplamSiparisSayisi.Location = new Point(694, 151);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(294, 25);
            lblToplamSiparisSayisi.TabIndex = 13;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(694, 107);
            label5.Name = "label5";
            label5.Size = new Size(294, 31);
            label5.TabIndex = 12;
            label5.Text = "Toplam Siparis Sayisi";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.BorderStyle = BorderStyle.Fixed3D;
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(694, 59);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(294, 25);
            lblToplamTutar.TabIndex = 11;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(694, 15);
            label2.Name = "label2";
            label2.Size = new Size(293, 31);
            label2.TabIndex = 10;
            label2.Text = "Toplam Tutar";
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 20;
            lstTumSiparisler.Location = new Point(19, 55);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(654, 584);
            lstTumSiparisler.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 11);
            label1.Name = "label1";
            label1.Size = new Size(454, 31);
            label1.TabIndex = 8;
            label1.Text = "TÜM SIPARISLER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SiparisBilgileri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 648);
            Controls.Add(lblEkstraMalzemeTutari);
            Controls.Add(label7);
            Controls.Add(lblToplamSiparisSayisi);
            Controls.Add(label5);
            Controls.Add(lblToplamTutar);
            Controls.Add(label2);
            Controls.Add(lstTumSiparisler);
            Controls.Add(label1);
            Name = "SiparisBilgileri";
            Text = "SiparisBilgileri";
            ResumeLayout(false);
        }

        #endregion

        private Label lblEkstraMalzemeTutari;
        private Label label7;
        private Label lblToplamSiparisSayisi;
        private Label label5;
        private Label lblToplamTutar;
        private Label label2;
        private ListBox lstTumSiparisler;
        private Label label1;
    }
}