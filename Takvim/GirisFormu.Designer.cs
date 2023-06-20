namespace Takvim
{
    partial class GirisFormu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Kullanici = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtboxKullanici = new TextBox();
            txtboxSifre = new TextBox();
            label2 = new Label();
            lblTemizle = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // Kullanici
            // 
            Kullanici.AutoSize = true;
            Kullanici.Location = new Point(94, 142);
            Kullanici.Name = "Kullanici";
            Kullanici.Size = new Size(52, 15);
            Kullanici.TabIndex = 0;
            Kullanici.Text = "Kullanici";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 205);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Sifre";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(157, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 1);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(157, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 1);
            panel2.TabIndex = 3;
            // 
            // txtboxKullanici
            // 
            txtboxKullanici.Location = new Point(157, 134);
            txtboxKullanici.Name = "txtboxKullanici";
            txtboxKullanici.Size = new Size(290, 23);
            txtboxKullanici.TabIndex = 4;
            // 
            // txtboxSifre
            // 
            txtboxSifre.Location = new Point(157, 197);
            txtboxSifre.Name = "txtboxSifre";
            txtboxSifre.PasswordChar = '*';
            txtboxSifre.Size = new Size(290, 23);
            txtboxSifre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 64);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "Giris";
            // 
            // lblTemizle
            // 
            lblTemizle.AutoSize = true;
            lblTemizle.Location = new Point(401, 243);
            lblTemizle.Name = "lblTemizle";
            lblTemizle.Size = new Size(46, 15);
            lblTemizle.TabIndex = 7;
            lblTemizle.Text = "Temizle";
            lblTemizle.Click += lblTemizle_Click;
            // 
            // button1
            // 
            button1.Location = new Point(263, 278);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Giris";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(263, 326);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Cikis";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(263, 242);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Sifreyi Goster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // GirisFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(576, 385);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTemizle);
            Controls.Add(label2);
            Controls.Add(txtboxSifre);
            Controls.Add(txtboxKullanici);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Kullanici);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GirisFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirisFormu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Kullanici;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtboxKullanici;
        private TextBox txtboxSifre;
        private Label label2;
        private Label lblTemizle;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
    }
}