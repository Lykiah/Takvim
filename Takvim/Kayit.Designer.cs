namespace Takvim
{
    partial class Kayit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            txtIsimSoyisim = new TextBox();
            txtTel = new TextBox();
            txtTCKimlik = new TextBox();
            txtKullaniciTipi = new TextBox();
            txtAdres = new TextBox();
            label9 = new Label();
            btnGeri = new Button();
            btnKayit = new Button();
            checkBox1 = new CheckBox();
            label10 = new Label();
            txtEmail = new TextBox();
            DGVKayitlar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVKayitlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 72);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "KullaniciAdi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 110);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Sifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 144);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Sifre Tekrar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 202);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 4;
            label4.Text = "Isim Soyisim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 271);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 5;
            label5.Text = "TC Kimlik";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 240);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 6;
            label6.Text = "Telefon Numarasi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 361);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 7;
            label7.Text = "Adres";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 304);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 8;
            label8.Text = "Kullanici Tipi";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(126, 69);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(194, 23);
            txtKullaniciAdi.TabIndex = 9;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(126, 107);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(194, 23);
            txtSifre.TabIndex = 10;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(126, 141);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(194, 23);
            txtSifreTekrar.TabIndex = 11;
            // 
            // txtIsimSoyisim
            // 
            txtIsimSoyisim.Location = new Point(126, 202);
            txtIsimSoyisim.Name = "txtIsimSoyisim";
            txtIsimSoyisim.Size = new Size(194, 23);
            txtIsimSoyisim.TabIndex = 12;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(126, 237);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(194, 23);
            txtTel.TabIndex = 13;
            // 
            // txtTCKimlik
            // 
            txtTCKimlik.Location = new Point(126, 271);
            txtTCKimlik.Name = "txtTCKimlik";
            txtTCKimlik.Size = new Size(194, 23);
            txtTCKimlik.TabIndex = 14;
            // 
            // txtKullaniciTipi
            // 
            txtKullaniciTipi.Location = new Point(126, 304);
            txtKullaniciTipi.Name = "txtKullaniciTipi";
            txtKullaniciTipi.Size = new Size(194, 23);
            txtKullaniciTipi.TabIndex = 15;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(126, 361);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(194, 104);
            txtAdres.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(284, 482);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 18;
            label9.Text = "Sifirla";
            label9.Click += label9_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(126, 511);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 19;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(245, 511);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(75, 23);
            btnKayit.TabIndex = 21;
            btnKayit.Text = "Kayit";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(126, 170);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Sifreyi Goster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(29, 335);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 23;
            label10.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 335);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 24;
            // 
            // DGVKayitlar
            // 
            DGVKayitlar.AllowUserToAddRows = false;
            DGVKayitlar.AllowUserToDeleteRows = false;
            DGVKayitlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVKayitlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVKayitlar.Location = new Point(326, 66);
            DGVKayitlar.Name = "DGVKayitlar";
            DGVKayitlar.ReadOnly = true;
            DGVKayitlar.RowTemplate.Height = 25;
            DGVKayitlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVKayitlar.Size = new Size(693, 399);
            DGVKayitlar.TabIndex = 25;
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 567);
            Controls.Add(DGVKayitlar);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(checkBox1);
            Controls.Add(btnKayit);
            Controls.Add(btnGeri);
            Controls.Add(label9);
            Controls.Add(txtAdres);
            Controls.Add(txtKullaniciTipi);
            Controls.Add(txtTCKimlik);
            Controls.Add(txtTel);
            Controls.Add(txtIsimSoyisim);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Kayit";
            Text = "Kayit";
            Load += Kayit_Load;
            ((System.ComponentModel.ISupportInitialize)DGVKayitlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private TextBox txtIsimSoyisim;
        private TextBox txtTel;
        private TextBox txtTCKimlik;
        private TextBox txtKullaniciTipi;
        private TextBox txtAdres;
        private Button button1;
        private Label label9;
        private Button btnGeri;
        private Button btnKayit;
        private CheckBox checkBox1;
        private Label label10;
        private TextBox txtEmail;
        private DataGridView DGVKayitlar;
        private Label label11;
        private TextBox txtID;
    }
}