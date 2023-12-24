namespace HamburgerUygulamasi
{
    partial class EkstraMalzemeEkleme
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
            btnEkstraMalzemeKaydet = new Button();
            nudEkstraMalzemeFiyat = new NumericUpDown();
            label3 = new Label();
            txtEkstraMalzeme = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // btnEkstraMalzemeKaydet
            // 
            btnEkstraMalzemeKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkstraMalzemeKaydet.Location = new Point(219, 146);
            btnEkstraMalzemeKaydet.Name = "btnEkstraMalzemeKaydet";
            btnEkstraMalzemeKaydet.Size = new Size(291, 73);
            btnEkstraMalzemeKaydet.TabIndex = 17;
            btnEkstraMalzemeKaydet.Text = "EKSTRA MALZEMEYI KAYDET";
            btnEkstraMalzemeKaydet.UseVisualStyleBackColor = true;
            btnEkstraMalzemeKaydet.Click += btnEkstraMalzemeKaydet_Click;
            // 
            // nudEkstraMalzemeFiyat
            // 
            nudEkstraMalzemeFiyat.Location = new Point(215, 96);
            nudEkstraMalzemeFiyat.Minimum = new decimal(new int[] { 100, 0, 0, 131072 });
            nudEkstraMalzemeFiyat.Name = "nudEkstraMalzemeFiyat";
            nudEkstraMalzemeFiyat.Size = new Size(295, 27);
            nudEkstraMalzemeFiyat.TabIndex = 16;
            nudEkstraMalzemeFiyat.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(119, 96);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 15;
            label3.Text = "Fiyat:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtEkstraMalzeme
            // 
            txtEkstraMalzeme.Location = new Point(211, 43);
            txtEkstraMalzeme.Multiline = true;
            txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            txtEkstraMalzeme.Size = new Size(299, 34);
            txtEkstraMalzeme.TabIndex = 14;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(190, 31);
            label2.TabIndex = 13;
            label2.Text = "Ekstra Malzeme Adi:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(486, 31);
            label1.TabIndex = 12;
            label1.Text = "EKSTRA MALZEME BILGILERI";
            // 
            // EkstraMalzemeEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 271);
            Controls.Add(btnEkstraMalzemeKaydet);
            Controls.Add(nudEkstraMalzemeFiyat);
            Controls.Add(label3);
            Controls.Add(txtEkstraMalzeme);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EkstraMalzemeEkleme";
            Text = "EkstraMalzemeEkleme";
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkstraMalzemeKaydet;
        private NumericUpDown nudEkstraMalzemeFiyat;
        private Label label3;
        private TextBox txtEkstraMalzeme;
        private Label label2;
        private Label label1;
    }
}