using QLCuuSinhVien.Forms;
using QLCuuSinhVien.Models;
using QLCuuSinhVien.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuuSinhVien.CustomControls
{
    public partial class Custom_Profile : UserControl
    {
        private string TenDangNhap;
        private int IDTaiKhoan;
        private NguoiDung nguoiDung;

        public Custom_Profile()
        {
            InitializeComponent();
        }

        public Custom_Profile(NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            LoadData();
        }

        public Custom_Profile(int IDTaiKhoan, string TenDangNhap)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.IDTaiKhoan = IDTaiKhoan;
        }

        private void LoadData()
        {
            if (nguoiDung != null)
            {
                using (var context = new Context())
                {
                    label1.Text = nguoiDung.HoTen.ToString();
                    if (nguoiDung.NgaySinh == null)
                    {
                        label2.Text = "";
                    }
                    else
                    {
                        label2.Text = nguoiDung.NgaySinh.ToString();
                    }
                    if (nguoiDung.IDBangCap == null)
                    {
                        label4.Text = "";
                    }
                    else
                    {
                        label4.Text = context.BangCap.FirstOrDefault(p => p.IDBangCap == nguoiDung.IDBangCap).TenBangCap.ToString();
                    }
                    if (nguoiDung.CongViecHienTai == null)
                    {
                        label5.Text = "";
                    }
                    else
                    {
                        label5.Text = nguoiDung.CongViecHienTai.ToString();
                    }
                    if (nguoiDung.AnhDaiDien == null)
                    {
                        pictureBox1.Image = Resources.Profile_pic;
                    }
                    else
                    {
                        pictureBox1.Image = Utility.LoadBitmapUnlocked(nguoiDung.AnhDaiDien);
                    }
                    txtEmail.Text = nguoiDung.Email.ToString();
                    NguoiDung nguoiDungg = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == IDTaiKhoan);
                    if (nguoiDung.TrangThai == false)
                    {
                        btnTheoDoi.Visible = false;
                    }
                }
            }
        }

        [Category("VietTuan")]
        public Image AnhDaiDien
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        [Category("VietTuan")]
        public string Ten
        {
            get => label1.Text;
            set => label1.Text = value;
        }

        [Category("VietTuan")]
        public string NamSinh
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        [Category("VietTuan")]
        public string TrinhDo
        {
            get => label4.Text;
            set => label4.Text = value;
        }

        [Category("VietTuan")]
        public string CongViecHienTai
        {
            get => label5.Text;
            set => label5.Text = value;
        }


        [Category("VietTuan")]
        public string TheoDoi
        {
            get => btnTheoDoi.Text;
            set => btnTheoDoi.Text = value;
        }

        [Category("VietTuan")]
        public string Email
        {
            get => txtEmail.Text;
            set => txtEmail.Text = value;
        }

        [Category("VietTuan")]
        public bool BtnCam
        {
            get => btnBan.Visible;
            set => btnBan.Visible = value;
        }

        [Category("VietTuan")]
        public bool BtnDuyet
        {
            get => btnDuyet.Visible;
            set => btnDuyet.Visible = value;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private List<string> listHoSoQuanTam()
        {
            using (var context = new Context())
            {
                List<string> list;
                string HoSo = context.NguoiDung.FirstOrDefault(p => p.TenDangNhap.Equals(TenDangNhap)).HoSoQuanTam;
                if (HoSo == null)
                {
                    list = new List<string>();
                }
                else
                {
                    list = new List<string>(HoSo.Split(','));
                }
                return list;
            }
        }

        private void btnTheoDoi_Click(object sender, EventArgs e)
        {
            List<string> DsQuanTam = listHoSoQuanTam();
            HashSet<string> setQuanTam = new HashSet<string>();
            foreach (var item in DsQuanTam)
            {
                setQuanTam.Add(item);
            }
            if (btnTheoDoi.Text.Equals("Theo Dõi"))
            {
                //btnTheoDoi.BackColor = Color.
                btnTheoDoi.Text = "Đã Theo Dõi";
                setQuanTam.Add(IDTaiKhoan.ToString());
                string DSHoSo = string.Join(",", setQuanTam);

                using (var context = new Context())
                {
                    NguoiDung nguoiDung = context.NguoiDung.FirstOrDefault(p => p.TenDangNhap.Equals(TenDangNhap));
                    if (nguoiDung == null)
                    {
                        MessageBox.Show("Lỗi theo dõi người dùng");
                    }
                    else
                    {
                        nguoiDung.HoSoQuanTam = DSHoSo;
                        context.SaveChanges();
                    }
                }
            }
            else
            {
                //btnTheoDoi.BackColor = Color.
                btnTheoDoi.Text = "Theo Dõi";
                setQuanTam.Remove(IDTaiKhoan.ToString());
                string DSHoSo = string.Join(",", setQuanTam);
                using (var context = new Context())
                {
                    NguoiDung nguoiDung = context.NguoiDung.FirstOrDefault(p => p.TenDangNhap.Equals(TenDangNhap));
                    if (nguoiDung == null)
                    {
                        MessageBox.Show("Lỗi bỏ theo dõi người dùng");
                    }
                    else
                    {
                        nguoiDung.HoSoQuanTam = DSHoSo;
                        context.SaveChanges();
                    }
                }
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                if (nguoiDung != null)
                {
                    string sdt = nguoiDung.SDT;
                    NguoiDung nguoiDung1 = context.NguoiDung.FirstOrDefault(p => p.SDT == sdt);
                    nguoiDung1.TrangThai = true;
                    context.SaveChanges();
                    MessageBox.Show("Duyệt thành viên thành công");
                }
                else
                {
                    MessageBox.Show("Tài khoản này đã duyệt rồi!!!");
                }
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                NguoiDung nguoiDung = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == IDTaiKhoan);
                if (nguoiDung != null)
                {
                    Detail_Profile detail = new Detail_Profile(nguoiDung);
                    detail.Show();
                }
                else
                {
                    MessageBox.Show("Không tồn tại người dùng này...");
                }
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cấm?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NguoiDung nguoiDung1 = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == IDTaiKhoan);
                    if (nguoiDung1 != null)
                    {
                        nguoiDung1.TrangThai = false;
                        context.SaveChanges();
                        MessageBox.Show("Cấm thành viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra");
                    }
                }
            }
        }
    }
}
