using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuuSinhVien.CustomControl
{
    public partial class MyProfile : UserControl
    {
        public MyProfile()
        {
            InitializeComponent();
        }


        [Category("VietTuan")]
        public Image AnhDaiDien
        {
            get => imgAnhDaiDien_MyProfile.Image;
            set => imgAnhDaiDien_MyProfile.Image = value;
        }

        [Category("VietTuan")]
        public string Ten
        {
            get => txtTen_MyProfile.Text.ToString().Trim();
            set => txtTen_MyProfile.Text = value;
        }

        [Category("VietTuan")]
        public string TenDangNhap
        {
            get => txtTenDangNhap_MyProfile.Text.ToString().Trim();
            set => txtTenDangNhap_MyProfile.Text = value;
        }

        [Category("VietTuan")]
        public string NgaySinh
        {
            get => dtpNgaySinh_MyProfile.Value.ToShortDateString().Trim();
            set => dtpNgaySinh_MyProfile.Value = Convert.ToDateTime(value);
        }

        [Category("VietTuan")]
        public string SDT
        {
            get => txtSDT_MyProfile.Text.ToString().Trim();
            set => txtSDT_MyProfile.Text = value;
        }

        [Category("VietTuan")]
        public string Email
        {
            get => txtEmail_MyProfile.ToString().Trim();
            set => txtEmail_MyProfile.Text = value;
        }

        [Category("VietTuan")]
        public string BangCap
        {
            get => txtBangCap_MyProfile.ToString().Trim();
            set => txtBangCap_MyProfile.Text = value;
        }

        [Category("VietTuan")]
        public string DiaChi
        {
            get => txtDiaChi_MyProfile.ToString().Trim();
            set => txtDiaChi_MyProfile.Text = value;
        }

        [Category("VietTuan")]
        public string CongViec
        {
            get => txtCV_MyProfile.ToString().Trim();
            set => txtCV_MyProfile.Text = value;
        }

        [Category("VietTuan")]
        public string MoTa
        {
            get => txtMoTa_MyProfile.ToString().Trim();
            set => txtMoTa_MyProfile.Text = value;
        }

        [Category("VietTuan")]
        public string DaLamViec
        {
            get => txtDaLamViec_MyProfile.ToString().Trim();
            set => txtDaLamViec_MyProfile.Text = value;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
