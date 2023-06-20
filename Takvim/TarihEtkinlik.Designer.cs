namespace Takvim
{
    partial class TarihEtkinlik
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
            lblTarih = new Label();
            lblEtkinlik = new Label();
            txtTarih = new TextBox();
            txtEtkinlik = new TextBox();
            btnKaydet = new Button();
            btnTemizle = new Button();
            btnGeri = new Button();
            label1 = new Label();
            txtZaman = new TextBox();
            SuspendLayout();
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(79, 8);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(32, 15);
            lblTarih.TabIndex = 0;
            lblTarih.Text = "Tarih";
            // 
            // lblEtkinlik
            // 
            lblEtkinlik.AutoSize = true;
            lblEtkinlik.Location = new Point(79, 71);
            lblEtkinlik.Name = "lblEtkinlik";
            lblEtkinlik.Size = new Size(45, 15);
            lblEtkinlik.TabIndex = 1;
            lblEtkinlik.Text = "Etkinlik";
            // 
            // txtTarih
            // 
            txtTarih.Location = new Point(79, 38);
            txtTarih.Name = "txtTarih";
            txtTarih.ReadOnly = true;
            txtTarih.Size = new Size(284, 23);
            txtTarih.TabIndex = 2;
            // 
            // txtEtkinlik
            // 
            txtEtkinlik.Location = new Point(79, 99);
            txtEtkinlik.Name = "txtEtkinlik";
            txtEtkinlik.Size = new Size(284, 23);
            txtEtkinlik.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(288, 197);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(185, 197);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 5;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(79, 197);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 6;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 134);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 7;
            label1.Text = "Ne Zaman";
            // 
            // txtZaman
            // 
            txtZaman.Location = new Point(79, 156);
            txtZaman.Name = "txtZaman";
            txtZaman.Size = new Size(284, 23);
            txtZaman.TabIndex = 8;
            // 
            // TarihEtkinlik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 241);
            Controls.Add(txtZaman);
            Controls.Add(label1);
            Controls.Add(btnGeri);
            Controls.Add(btnTemizle);
            Controls.Add(btnKaydet);
            Controls.Add(txtEtkinlik);
            Controls.Add(txtTarih);
            Controls.Add(lblEtkinlik);
            Controls.Add(lblTarih);
            Name = "TarihEtkinlik";
            Text = "TarihEtkinlik";
            Load += TarihEtkinlik_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTarih;
        private Label lblEtkinlik;
        private TextBox txtTarih;
        private TextBox txtEtkinlik;
        private Button btnKaydet;
        private Button btnTemizle;
        private Button btnGeri;
        private Label label1;
        private TextBox txtZaman;
    }
}