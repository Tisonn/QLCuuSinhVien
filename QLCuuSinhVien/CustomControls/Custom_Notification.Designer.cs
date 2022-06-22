namespace QLCuuSinhVien.CustomControls
{
    partial class Custom_Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom_Notification));
            this.btnXoaBaiViet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaBaiViet = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PbImage_Custom_Notification = new System.Windows.Forms.PictureBox();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.txtCre = new System.Windows.Forms.TextBox();
            this.txtIDThongBao = new System.Windows.Forms.TextBox();
            this.btnDuyet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage_Custom_Notification)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaBaiViet
            // 
            this.btnXoaBaiViet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBaiViet.ImageOptions.Image")));
            this.btnXoaBaiViet.Location = new System.Drawing.Point(283, 54);
            this.btnXoaBaiViet.Name = "btnXoaBaiViet";
            this.btnXoaBaiViet.Size = new System.Drawing.Size(37, 40);
            this.btnXoaBaiViet.TabIndex = 5;
            this.btnXoaBaiViet.Click += new System.EventHandler(this.btnXoaBaiViet_Click);
            // 
            // btnSuaBaiViet
            // 
            this.btnSuaBaiViet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBaiViet.ImageOptions.Image")));
            this.btnSuaBaiViet.Location = new System.Drawing.Point(340, 54);
            this.btnSuaBaiViet.Name = "btnSuaBaiViet";
            this.btnSuaBaiViet.Size = new System.Drawing.Size(37, 40);
            this.btnSuaBaiViet.TabIndex = 4;
            this.btnSuaBaiViet.Click += new System.EventHandler(this.btnSuaBaiViet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chủ Đề:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(83, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "CÔNG NGHỆ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(4, 160);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(373, 19);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Tiêu Đề";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(4, 185);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(372, 139);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Tóm tắt";
            // 
            // PbImage_Custom_Notification
            // 
            this.PbImage_Custom_Notification.Location = new System.Drawing.Point(4, 3);
            this.PbImage_Custom_Notification.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PbImage_Custom_Notification.Name = "PbImage_Custom_Notification";
            this.PbImage_Custom_Notification.Size = new System.Drawing.Size(219, 130);
            this.PbImage_Custom_Notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImage_Custom_Notification.TabIndex = 18;
            this.PbImage_Custom_Notification.TabStop = false;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Appearance.Options.UseFont = true;
            this.btnChiTiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.ImageOptions.Image")));
            this.btnChiTiet.Location = new System.Drawing.Point(283, 3);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(94, 45);
            this.btnChiTiet.TabIndex = 21;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // txtCre
            // 
            this.txtCre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCre.Location = new System.Drawing.Point(277, 118);
            this.txtCre.Name = "txtCre";
            this.txtCre.Size = new System.Drawing.Size(100, 15);
            this.txtCre.TabIndex = 22;
            this.txtCre.Text = "Cre:";
            // 
            // txtIDThongBao
            // 
            this.txtIDThongBao.Enabled = false;
            this.txtIDThongBao.Location = new System.Drawing.Point(4, 3);
            this.txtIDThongBao.Name = "txtIDThongBao";
            this.txtIDThongBao.Size = new System.Drawing.Size(17, 20);
            this.txtIDThongBao.TabIndex = 24;
            this.txtIDThongBao.Visible = false;
            // 
            // btnDuyet
            // 
            this.btnDuyet.Location = new System.Drawing.Point(299, 155);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(81, 24);
            this.btnDuyet.TabIndex = 23;
            this.btnDuyet.Text = "Duyệt Bài";
            this.btnDuyet.UseVisualStyleBackColor = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // Custom_Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txtIDThongBao);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.txtCre);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.PbImage_Custom_Notification);
            this.Controls.Add(this.btnXoaBaiViet);
            this.Controls.Add(this.btnSuaBaiViet);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.Name = "Custom_Notification";
            this.Size = new System.Drawing.Size(380, 327);
            this.Load += new System.EventHandler(this.Custom_Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage_Custom_Notification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSuaBaiViet;
        private DevExpress.XtraEditors.SimpleButton btnXoaBaiViet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox PbImage_Custom_Notification;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private System.Windows.Forms.TextBox txtCre;
        private System.Windows.Forms.TextBox txtIDThongBao;
        private System.Windows.Forms.Button btnDuyet;
    }
}
