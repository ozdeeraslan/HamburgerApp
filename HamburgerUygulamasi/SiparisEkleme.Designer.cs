namespace HamburgerUygulamasi
{
    partial class SiparisEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkleme));
            label5 = new Label();
            lblToplamTutar = new Label();
            btnSiparisEkle = new Button();
            nudAdet = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            rdbBuyuk = new RadioButton();
            rdbOrta = new RadioButton();
            rdbKucuk = new RadioButton();
            label2 = new Label();
            cmbMenuSec = new ComboBox();
            label1 = new Label();
            lstTumSiparisler = new ListBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 561);
            label5.Name = "label5";
            label5.Size = new Size(130, 50);
            label5.TabIndex = 31;
            label5.Text = "TOPLAM TUTAR";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.BorderStyle = BorderStyle.Fixed3D;
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(152, 561);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(177, 43);
            lblToplamTutar.TabIndex = 29;
            lblToplamTutar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisEkle.Location = new Point(11, 515);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(318, 36);
            btnSiparisEkle.TabIndex = 28;
            btnSiparisEkle.Text = "SIPARIS EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(86, 482);
            nudAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(150, 27);
            nudAdet.TabIndex = 27;
            nudAdet.TextAlign = HorizontalAlignment.Center;
            nudAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 482);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 26;
            label4.Text = "ADET";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 304);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 25;
            label3.Text = "MALZEME SECINIZ";
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Location = new Point(177, 265);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(69, 24);
            rdbBuyuk.TabIndex = 24;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(102, 265);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(59, 24);
            rdbOrta.TabIndex = 23;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(18, 265);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(69, 24);
            rdbKucuk.TabIndex = 22;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Kücük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 230);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 21;
            label2.Text = "BOYUT SECINIZ";
            // 
            // cmbMenuSec
            // 
            cmbMenuSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuSec.FormattingEnabled = true;
            cmbMenuSec.Location = new Point(12, 188);
            cmbMenuSec.Name = "cmbMenuSec";
            cmbMenuSec.Size = new Size(317, 28);
            cmbMenuSec.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 154);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 19;
            label1.Text = "MENÜ SECINIZ";
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 20;
            lstTumSiparisler.Location = new Point(335, 16);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(776, 584);
            lstTumSiparisler.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(18, 330);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(311, 133);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // SiparisEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 617);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(lblToplamTutar);
            Controls.Add(btnSiparisEkle);
            Controls.Add(nudAdet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rdbBuyuk);
            Controls.Add(rdbOrta);
            Controls.Add(rdbKucuk);
            Controls.Add(label2);
            Controls.Add(cmbMenuSec);
            Controls.Add(label1);
            Controls.Add(lstTumSiparisler);
            Controls.Add(pictureBox1);
            Name = "SiparisEkleme";
            Text = "SiparisEkleme";
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label lblToplamTutar;
        private Button btnSiparisEkle;
        private NumericUpDown nudAdet;
        private Label label4;
        private Label label3;
        private RadioButton rdbBuyuk;
        private RadioButton rdbOrta;
        private RadioButton rdbKucuk;
        private Label label2;
        private ComboBox cmbMenuSec;
        private Label label1;
        private ListBox lstTumSiparisler;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}