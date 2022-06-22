namespace QLCuuSinhVien.CustomControls
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.txtConfirmPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtNewPassword = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtOldPassword = new Krypton.Toolkit.KryptonTextBox();
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.cbxStrength = new Krypton.Toolkit.KryptonCheckBox();
            this.cbxMatch = new Krypton.Toolkit.KryptonCheckBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(307, 428);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleDarkMode;
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(479, 28);
            this.txtConfirmPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirmPassword.StateCommon.Border.Rounding = 5F;
            this.txtConfirmPassword.StateCommon.Border.Width = 1;
            this.txtConfirmPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtConfirmPassword.TabIndex = 55;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(307, 336);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleDarkMode;
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(479, 28);
            this.txtNewPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPassword.StateCommon.Border.Rounding = 5F;
            this.txtNewPassword.StateCommon.Border.Width = 1;
            this.txtNewPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtNewPassword.TabIndex = 54;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(307, 393);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(158, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 56;
            this.kryptonLabel6.Values.Text = "Nhập lại mật khẩu";
            this.kryptonLabel6.Click += new System.EventHandler(this.kryptonLabel6_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(307, 301);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(122, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 57;
            this.kryptonLabel5.Values.Text = "Mật khẩu mới";
            this.kryptonLabel5.Click += new System.EventHandler(this.kryptonLabel5_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(307, 220);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(92, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 58;
            this.kryptonLabel2.Values.Text = "Mật Khẩu";
            this.kryptonLabel2.Click += new System.EventHandler(this.kryptonLabel2_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(307, 136);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(138, 26);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 59;
            this.kryptonLabel1.Values.Text = "Tên Đăng Nhập";
            this.kryptonLabel1.Click += new System.EventHandler(this.kryptonLabel1_Click);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(307, 255);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleDarkMode;
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(479, 28);
            this.txtOldPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOldPassword.StateCommon.Border.Rounding = 5F;
            this.txtOldPassword.StateCommon.Border.Width = 1;
            this.txtOldPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtOldPassword.TabIndex = 52;
            this.txtOldPassword.TextChanged += new System.EventHandler(this.txtOldPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom3;
            this.txtUsername.Location = new System.Drawing.Point(307, 171);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurple;
            this.txtUsername.Size = new System.Drawing.Size(479, 28);
            this.txtUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsername.StateCommon.Border.Rounding = 5F;
            this.txtUsername.StateCommon.Border.Width = 1;
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtUsername.TabIndex = 51;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // cbxStrength
            // 
            this.cbxStrength.AutoCheck = false;
            this.cbxStrength.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.CheckedNormal")));
            this.cbxStrength.Images.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.CheckedPressed")));
            this.cbxStrength.Images.CheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.CheckedTracking")));
            this.cbxStrength.Images.Common = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.Common")));
            this.cbxStrength.Images.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.UncheckedDisabled")));
            this.cbxStrength.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.UncheckedNormal")));
            this.cbxStrength.Images.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.UncheckedPressed")));
            this.cbxStrength.Images.UncheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxStrength.Images.UncheckedTracking")));
            this.cbxStrength.Location = new System.Drawing.Point(810, 336);
            this.cbxStrength.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStrength.Name = "cbxStrength";
            this.cbxStrength.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxStrength.Size = new System.Drawing.Size(26, 16);
            this.cbxStrength.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxStrength.TabIndex = 50;
            this.cbxStrength.TabStop = false;
            this.cbxStrength.Values.Text = "";
            this.cbxStrength.Visible = false;
            this.cbxStrength.CheckedChanged += new System.EventHandler(this.cbxStrength_CheckedChanged);
            // 
            // cbxMatch
            // 
            this.cbxMatch.AutoCheck = false;
            this.cbxMatch.Images.CheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.CheckedNormal")));
            this.cbxMatch.Images.CheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.CheckedPressed")));
            this.cbxMatch.Images.CheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.CheckedTracking")));
            this.cbxMatch.Images.Common = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.Common")));
            this.cbxMatch.Images.UncheckedDisabled = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.UncheckedDisabled")));
            this.cbxMatch.Images.UncheckedNormal = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.UncheckedNormal")));
            this.cbxMatch.Images.UncheckedPressed = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.UncheckedPressed")));
            this.cbxMatch.Images.UncheckedTracking = ((System.Drawing.Image)(resources.GetObject("cbxMatch.Images.UncheckedTracking")));
            this.cbxMatch.Location = new System.Drawing.Point(810, 428);
            this.cbxMatch.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMatch.Name = "cbxMatch";
            this.cbxMatch.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            this.cbxMatch.Size = new System.Drawing.Size(26, 16);
            this.cbxMatch.StateCommon.Padding = new System.Windows.Forms.Padding(5);
            this.cbxMatch.TabIndex = 49;
            this.cbxMatch.TabStop = false;
            this.cbxMatch.Values.Text = "";
            this.cbxMatch.Visible = false;
            this.cbxMatch.CheckedChanged += new System.EventHandler(this.cbxMatch_CheckedChanged);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(397, 504);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(324, 63);
            this.btnChangePassword.TabIndex = 60;
            this.btnChangePassword.Text = "Đổi Mật Khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // ChangePass
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cbxStrength);
            this.Controls.Add(this.cbxMatch);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChangePass";
            this.Size = new System.Drawing.Size(1123, 725);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtConfirmPassword;
        private Krypton.Toolkit.KryptonTextBox txtNewPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtOldPassword;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonCheckBox cbxStrength;
        private Krypton.Toolkit.KryptonCheckBox cbxMatch;
        private System.Windows.Forms.Button btnChangePassword;
    }
}
