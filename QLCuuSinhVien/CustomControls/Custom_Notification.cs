using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuuSinhVien.Models;
using QLCuuSinhVien.Forms;
using QLCuuSinhVien.CustomControls;

namespace QLCuuSinhVien.CustomControls
{
    public partial class Custom_Notification : UserControl
    {
        NguoiDung nguoiDung;

        public Custom_Notification()
        {
            InitializeComponent();
        }

        public Custom_Notification(NguoiDung nguoiDung)
        {
            this.nguoiDung = nguoiDung;
            InitializeComponent();
        }

        private void Custom_Notification_Load(object sender, EventArgs e)
        {
            if (nguoiDung.PhanQuyen.Equals("user"))
            {
                btnSuaBaiViet.Enabled = false;
                btnXoaBaiViet.Enabled = false;
            }
            else
            {
                btnSuaBaiViet.Enabled = true;
                btnXoaBaiViet.Enabled = true;
            }
        }

        [Category("VietTuan")]
        public string NguoiDang
        {
            get => txtCre.Text;
            set => txtCre.Text = value;
        }

        [Category("VietTuan")]
        public string IDThongBao
        {
            get => txtIDThongBao.Text;
            set => txtIDThongBao.Text = value;
        }

        [Category("VietTuan")]
        public Image AnhThongBao
        {
            get => PbImage_Custom_Notification.Image;
            set => PbImage_Custom_Notification.Image = value;
        }

        [Category("VietTuan")]
        public string TenThongBao
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        [Category("VietTuan")]
        public string NoiDungThongBao
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }
        [Category("VietTuan")]
        public string ChuDe
        {
            get => textBox3.Text;
            set => textBox3.Text = value;
        }
        [Category("VietTuan")]
        public bool AnDuyetBai
        {
            set => btnDuyet.Visible = value;
        }
        [Category("VietTuan")]
        public bool AnXoaBai
        {
            set => btnXoaBaiViet.Visible = value;
        }
        [Category("VietTuan")]
        public bool AnSuaBaiViet
        {
            set => btnSuaBaiViet.Visible = value;
        }
        [Category("VietTuan")]
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void btnSuaBaiViet_Click(object sender, EventArgs e)
        {
            string TieuDe = textBox1.Text.ToString();
            string NoiDung = textBox2.Text.ToString();
            string ChuDe = textBox3.Text.ToString();
            Image AnhThongBao = PbImage_Custom_Notification.Image;
            Edit change_Notification = new Edit(nguoiDung, TieuDe, NoiDung, AnhThongBao, ChuDe);
            change_Notification.Show();
        }

        private void btnXoaBaiViet_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtIDThongBao.Text.ToString());

            using (var context = new Context())
            {
                ThongBao thongBao = context.ThongBao.FirstOrDefault(p => p.IDThongBao == ID);

                if (thongBao == null)
                {
                    MessageBox.Show("Lỗi NULL");
                }
                else
                {
                    context.ThongBao.Remove(thongBao);
                    context.SaveChanges();
                    MessageBox.Show("Xoá thành công");
                    Parent.Controls.Remove(this);

                }
            }
        }


        private void btnDuyet_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtIDThongBao.Text.ToString());

            using (var context = new Context())
            {
                ThongBao thongBao = context.ThongBao.FirstOrDefault(p => p.IDThongBao == ID);
                if (thongBao == null)
                {
                    MessageBox.Show("Lỗi NULL");
                }
                else
                {
                    thongBao.TinhTrang = true;
                    context.SaveChanges();
                    MessageBox.Show("Duyệt bài viết thành công");
                }
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDThongBao);

            Notifications notifications = new Notifications(ID);
            notifications.Show();
        }
    }
}