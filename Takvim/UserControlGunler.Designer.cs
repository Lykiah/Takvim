namespace Takvim
{
    partial class UserControlGunler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGun = new Label();
            SuspendLayout();
            // 
            // lblGun
            // 
            lblGun.AutoSize = true;
            lblGun.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGun.Location = new Point(18, 14);
            lblGun.Name = "lblGun";
            lblGun.Size = new Size(27, 19);
            lblGun.TabIndex = 0;
            lblGun.Text = "00";
            // 
            // UserControlGunler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblGun);
            Name = "UserControlGunler";
            Size = new Size(150, 100);
            Click += UserControlGunler_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGun;
    }
}
