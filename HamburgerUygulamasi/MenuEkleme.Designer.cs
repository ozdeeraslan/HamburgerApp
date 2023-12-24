namespace HamburgerUygulamasi
{
    partial class MenuEkleme
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
            btnMenuKaydet = new Button();
            nudMenuFiyat = new NumericUpDown();
            label3 = new Label();
            txtMenuAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).BeginInit();
            SuspendLayout();
            // 
            // btnMenuKaydet
            // 
            btnMenuKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuKaydet.Location = new Point(218, 167);
            btnMenuKaydet.Name = "btnMenuKaydet";
            btnMenuKaydet.Size = new Size(291, 61);
            btnMenuKaydet.TabIndex = 11;
            btnMenuKaydet.Text = "MENÜYÜ KAYDET";
            btnMenuKaydet.UseVisualStyleBackColor = true;
            btnMenuKaydet.Click += btnMenuKaydet_Click;
            // 
            // nudMenuFiyat
            // 
            nudMenuFiyat.Location = new Point(214, 117);
            nudMenuFiyat.Minimum = new decimal(new int[] { 100, 0, 0, 131072 });
            nudMenuFiyat.Name = "nudMenuFiyat";
            nudMenuFiyat.Size = new Size(295, 27);
            nudMenuFiyat.TabIndex = 10;
            nudMenuFiyat.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(118, 117);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 9;
            label3.Text = "Fiyat:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtMenuAd
            // 
            txtMenuAd.Location = new Point(210, 64);
            txtMenuAd.Multiline = true;
            txtMenuAd.Name = "txtMenuAd";
            txtMenuAd.Size = new Size(299, 34);
            txtMenuAd.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(101, 73);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 7;
            label2.Text = "Menü Adi:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(486, 31);
            label1.TabIndex = 6;
            label1.Text = "MENÜ BILGILERI";
            // 
            // MenuEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 267);
            Controls.Add(btnMenuKaydet);
            Controls.Add(nudMenuFiyat);
            Controls.Add(label3);
            Controls.Add(txtMenuAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuEkleme";
            Text = "MenuEkleme";
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuKaydet;
        private NumericUpDown nudMenuFiyat;
        private Label label3;
        private TextBox txtMenuAd;
        private Label label2;
        private Label label1;
    }
}