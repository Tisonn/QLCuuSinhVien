namespace QLCuuSinhVien.Forms
{
    partial class Notifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtNguoiDang = new System.Windows.Forms.TextBox();
            this.txtChuDe = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Report = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.AllowDrop = true;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(12, 234);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ReadOnly = true;
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoiDung.Size = new System.Drawing.Size(705, 608);
            this.txtNoiDung.TabIndex = 4;
            this.txtNoiDung.Text = "Nội Dung";
            // 
            // txtNguoiDang
            // 
            this.txtNguoiDang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNguoiDang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNguoiDang.Enabled = false;
            this.txtNguoiDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiDang.Location = new System.Drawing.Point(475, 142);
            this.txtNguoiDang.Multiline = true;
            this.txtNguoiDang.Name = "txtNguoiDang";
            this.txtNguoiDang.Size = new System.Drawing.Size(132, 36);
            this.txtNguoiDang.TabIndex = 6;
            this.txtNguoiDang.Text = "Người Đăng";
            this.txtNguoiDang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChuDe
            // 
            this.txtChuDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuDe.ForeColor = System.Drawing.Color.Red;
            this.txtChuDe.Location = new System.Drawing.Point(448, 12);
            this.txtChuDe.Multiline = true;
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.ReadOnly = true;
            this.txtChuDe.Size = new System.Drawing.Size(269, 36);
            this.txtChuDe.TabIndex = 7;
            this.txtChuDe.Text = "Chủ Đề";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuDe.Location = new System.Drawing.Point(351, 54);
            this.txtTieuDe.Multiline = true;
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.ReadOnly = true;
            this.txtTieuDe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTieuDe.Size = new System.Drawing.Size(366, 71);
            this.txtTieuDe.TabIndex = 8;
            this.txtTieuDe.Text = "Tiêu đề";
            this.txtTieuDe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLCuuSinhVien.Properties.Resources.background1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(626, 189);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(88, 39);
            this.Report.TabIndex = 9;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quan Tâm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chủ đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Người đăng";
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(726, 854);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtNguoiDang);
            this.Controls.Add(this.txtChuDe);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notifications";
            this.Text = "Chi Tiết Bài Viết";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtNguoiDang;
        private System.Windows.Forms.TextBox txtChuDe;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}