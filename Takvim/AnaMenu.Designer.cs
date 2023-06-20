namespace Takvim
{
    partial class AnaMenu
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
            btnTakvim = new Button();
            button2 = new Button();
            btnCikis = new Button();
            DGVEtkinlik = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVEtkinlik).BeginInit();
            SuspendLayout();
            // 
            // btnTakvim
            // 
            btnTakvim.Location = new Point(458, 68);
            btnTakvim.Name = "btnTakvim";
            btnTakvim.Size = new Size(75, 23);
            btnTakvim.TabIndex = 0;
            btnTakvim.Text = "Takvim";
            btnTakvim.UseVisualStyleBackColor = true;
            btnTakvim.Click += btnTakvim_Click;
            // 
            // button2
            // 
            button2.Location = new Point(61, 68);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Yeni Kayit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(458, 465);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(75, 23);
            btnCikis.TabIndex = 2;
            btnCikis.Text = "Cikis";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // DGVEtkinlik
            // 
            DGVEtkinlik.AllowUserToAddRows = false;
            DGVEtkinlik.AllowUserToDeleteRows = false;
            DGVEtkinlik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVEtkinlik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVEtkinlik.Location = new Point(61, 179);
            DGVEtkinlik.Name = "DGVEtkinlik";
            DGVEtkinlik.ReadOnly = true;
            DGVEtkinlik.RowTemplate.Height = 25;
            DGVEtkinlik.Size = new Size(472, 259);
            DGVEtkinlik.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 127);
            label1.Name = "label1";
            label1.Size = new Size(248, 21);
            label1.TabIndex = 5;
            label1.Text = "Var Olan Etkinlik Hatirlatmalari";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 500);
            Controls.Add(label1);
            Controls.Add(DGVEtkinlik);
            Controls.Add(btnCikis);
            Controls.Add(button2);
            Controls.Add(btnTakvim);
            Name = "AnaMenu";
            Text = "AnaMenu";
            Load += AnaMenu_Load;
            ((System.ComponentModel.ISupportInitialize)DGVEtkinlik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTakvim;
        private Button button2;
        private Button btnCikis;
        private DataGridView DGVEtkinlik;
        private Label label1;
    }
}