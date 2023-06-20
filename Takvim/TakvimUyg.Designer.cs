namespace Takvim
{
    partial class TakvimUyg
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnGeri = new Button();
            btnIleri = new Button();
            btnAnaMenu = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblAyYil = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 125);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1098, 544);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(917, 694);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 1;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnIleri
            // 
            btnIleri.Location = new Point(1026, 694);
            btnIleri.Name = "btnIleri";
            btnIleri.Size = new Size(75, 23);
            btnIleri.TabIndex = 2;
            btnIleri.Text = "Ileri";
            btnIleri.UseVisualStyleBackColor = true;
            btnIleri.Click += btnIleri_Click;
            // 
            // btnAnaMenu
            // 
            btnAnaMenu.Location = new Point(46, 694);
            btnAnaMenu.Name = "btnAnaMenu";
            btnAnaMenu.Size = new Size(75, 23);
            btnAnaMenu.TabIndex = 3;
            btnAnaMenu.Text = "Ana Menu";
            btnAnaMenu.UseVisualStyleBackColor = true;
            btnAnaMenu.Click += btnAnaMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 83);
            label1.Name = "label1";
            label1.Size = new Size(47, 21);
            label1.TabIndex = 4;
            label1.Text = "Pazar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(212, 83);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 5;
            label2.Text = "Pazartesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(376, 83);
            label3.Name = "label3";
            label3.Size = new Size(35, 21);
            label3.TabIndex = 6;
            label3.Text = "Sali";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(508, 83);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 7;
            label4.Text = "Carsamba";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(662, 83);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 8;
            label5.Text = "Persembe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(828, 83);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 9;
            label6.Text = "Cuma";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(969, 83);
            label7.Name = "label7";
            label7.Size = new Size(81, 21);
            label7.TabIndex = 10;
            label7.Text = "Cumartesi";
            // 
            // lblAyYil
            // 
            lblAyYil.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAyYil.Location = new Point(376, 26);
            lblAyYil.Name = "lblAyYil";
            lblAyYil.Size = new Size(335, 37);
            lblAyYil.TabIndex = 11;
            lblAyYil.Text = "AY / YIL";
            lblAyYil.TextAlign = ContentAlignment.TopCenter;
            // 
            // TakvimUyg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 729);
            Controls.Add(lblAyYil);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAnaMenu);
            Controls.Add(btnIleri);
            Controls.Add(btnGeri);
            Controls.Add(flowLayoutPanel1);
            Name = "TakvimUyg";
            Text = "Takvim";
            Load += Takvim_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnGeri;
        private Button btnIleri;
        private Button btnAnaMenu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblAyYil;
    }
}