using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuuSinhVien.Forms;
using QLCuuSinhVien.Models;

namespace QLCuuSinhVien.CustomControls
{
    public delegate void CloseForm();
    public partial class Change_Profile : UserControl
    {
        private bool isUploaded = false;
        public event CloseForm CloseForm;

        private NguoiDung nguoiDung;
        private string PATH = "";
        public Change_Profile()
        {
            InitializeComponent();
        }
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public Change_Profile(NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            InitControl();
            InitData(); 
        }

        private void InitControl()
        {
            using (var context = new Context())
            {
                List<BangCap> bangCapList = context.BangCap.ToList();
                List<Nganh> nganhs = context.Nganh.ToList();

                cboBangCap.DataSource = bangCapList;
                cboBangCap.ValueMember = "IDBangCap";
                cboBangCap.DisplayMember = "TenBangCap";

                cboNganh.DataSource = nganhs;
                cboNganh.ValueMember = "IdNganh";
                cboNganh.DisplayMember = "TenNganh";
            }
        }

        private void InitData()
        {
            txtTenDangNhap_ChangeProfile.Text = nguoiDung.TenDangNhap.ToString();
            if (nguoiDung.NgaySinh == null)
            {
                dtpNgaySinh_ChangeProfile.Value = DateTime.Now;
            }
            else 
            {
                dtpNgaySinh_ChangeProfile.Value = DateTime.ParseExact(nguoiDung.NgaySinh.ToString(), "dd/MM/yyyy",
                                        System.Globalization.CultureInfo.InvariantCulture);
            }
            
            txtSDT_ChangeProfile.Text = nguoiDung.SDT.ToString();
            txtEmail_ChangeProfile.Text = nguoiDung.Email.ToString();
            if(nguoiDung.DiaChi == null)
            {
                txtDiaChi_ChangeProfile.Text = "Chưa có"; 
            }    
            else 
            {
                txtDiaChi_ChangeProfile.Text = nguoiDung.DiaChi.ToString();
            }
            for (int i = 0; i < cboBangCap.Items.Count; i++)
            {
                cboBangCap.SelectedIndex = i;
                if (cboBangCap.SelectedValue.ToString() == nguoiDung.IDBangCap.ToString())
                {
                    break;
                }
            }

            for (int i = 0; i < cboNganh.Items.Count; i++)
            {
                cboNganh.SelectedIndex = i;
                if (cboNganh.SelectedValue.ToString() == nguoiDung.IDBangCap.ToString())
                {
                    break;
                }
            }
            if(nguoiDung.CongViecHienTai == null)
            {
                txtCV_ChangeProfile.Text = "";
            }
            else
            {
                txtCV_ChangeProfile.Text = nguoiDung.CongViecHienTai.ToString();
            }
            if(nguoiDung.MoTa == null)
            {
                txtMoTa_ChangeProfile.Text = "";
            }
            else
            {
                txtMoTa_ChangeProfile.Text = nguoiDung.MoTa.ToString();
            }
            if(nguoiDung.HoTen == null)
            {
                txtTen_ChangeProfile.Text =  "";
            }
            else
            {
                txtTen_ChangeProfile.Text = nguoiDung.HoTen.ToString();
            }
            if (nguoiDung.AnhDaiDien == null)
            {
                imgAnhDaiDien_ChangeProfile.Image = null;
            }
            else
            {
                imgAnhDaiDien_ChangeProfile.Image = Utility.LoadBitmapUnlocked(nguoiDung.AnhDaiDien);
            }
            // them da lam viec
        }

        [Category("VietTuan")]
        public Image AnhDaiDien
        {
            get => imgAnhDaiDien_ChangeProfile.Image;
            set => imgAnhDaiDien_ChangeProfile.Image = value;
        }

        [Category("VietTuan")]
        public string Ten
        {
            get => txtTen_ChangeProfile.Text.ToString();
            set => txtTen_ChangeProfile.Text = value;
        }

        [Category("VietTuan")]
        public string TenDangNhap
        {
            get => txtTenDangNhap_ChangeProfile.Text.ToString().Trim();
            set => txtTenDangNhap_ChangeProfile.Text = value;
        }

        [Category("VietTuan")]
        public string NgaySinh
        {
            get => dtpNgaySinh_ChangeProfile.Value.ToShortDateString().Trim();
            set => dtpNgaySinh_ChangeProfile.Value = Convert.ToDateTime(value);
        }

        [Category("VietTuan")]
        public string SDT
        {
            get => txtSDT_ChangeProfile.Text.ToString().Trim();
            set => txtSDT_ChangeProfile.Text = value;
        }

        [Category("VietTuan")]
        public string Email
        {
            get => txtEmail_ChangeProfile.ToString().Trim();
            set => txtEmail_ChangeProfile.Text = value;
        }

        [Category("VietTuan")]
        public string BangCap
        {
            get => cboBangCap.ToString().Trim();
            set => cboBangCap.ValueMember = value;
        }

        [Category("VietTuan")]
        public string DiaChi
        {
            get => txtDiaChi_ChangeProfile.ToString().Trim();
            set => txtDiaChi_ChangeProfile.Text = value;
        }

        [Category("VietTuan")]
        public string CongViec
        {
            get => txtCV_ChangeProfile.ToString().Trim();
            set => txtCV_ChangeProfile.Text = value;
        }

        [Category("VietTuan")]
        public string MoTa
        {
            get => txtMoTa_ChangeProfile.ToString().Trim();
            set => txtMoTa_ChangeProfile.Text = value;
        }

        [Category("VietTuan")]
        public string DaLamViec
        {
            get => txtDaLamViec_ChangeProfile.ToString().Trim();
            set => txtDaLamViec_ChangeProfile.Text = value;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void btnCapNhap_ChangeProfile_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                NguoiDung nguoiDung = context.NguoiDung.FirstOrDefault(p => p.TenDangNhap == TenDangNhap);
                nguoiDung.HoTen = txtTen_ChangeProfile.Text.ToString();
                nguoiDung.NgaySinh = dtpNgaySinh_ChangeProfile.Value.ToShortDateString().Trim();
                nguoiDung.SDT = txtSDT_ChangeProfile.Text.ToString().Trim();
                nguoiDung.Email = txtEmail_ChangeProfile.Text.ToString().Trim();
                nguoiDung.IDBangCap = Convert.ToInt32(cboBangCap.SelectedValue.ToString());
                nguoiDung.IdNganh = Convert.ToInt32(cboBangCap.SelectedValue.ToString());
                nguoiDung.DiaChi = txtDiaChi_ChangeProfile.Text.ToString().Trim();
                if (PATH != null && isUploaded)
                {
                    string id = Guid.NewGuid().ToString();
                    File.Copy(PATH, Path.Combine(@"D:\IMAGESERVER\", id + ".jpeg"), true);
                    nguoiDung.AnhDaiDien = @"D:\IMAGESERVER\" + id + ".jpeg";
                } 
                nguoiDung.CongViecHienTai = txtCV_ChangeProfile.Text.ToString().Trim();
                nguoiDung.MoTa = txtMoTa_ChangeProfile.Text.ToString().Trim();
                context.SaveChanges();
                MessageBox.Show("Cập Nhật Thành Công");
                Parent.Controls.Remove(this);
            }
            CloseForm();
            Login login = new Login();
            login.Show();
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";


                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PATH = dialog.FileName;
                    imgAnhDaiDien_ChangeProfile.Image = Utility.LoadBitmapUnlocked(dialog.FileName);
                    isUploaded = !isUploaded;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
