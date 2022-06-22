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

namespace QLCuuSinhVien.Forms
{
    public partial class Register : DevExpress.XtraEditors.XtraForm
    {
        public Register()
        {
            InitializeComponent();
            CenterToScreen();
            txtSDT.MaxLength = 10;
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!txtMatKhau.Text.Equals(txtNhapLaiMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không khớp, kiểm tra lại");
            }
            if (!CheckType(txtTenDangNhap.Text)
                || !CheckType(txtHoTen.Text)
                || !CheckType(txtNhapLaiMatKhau.Text)
                || !CheckType(txtMatKhau.Text)
                || !CheckType(txtEmail.Text)
                || (!CheckType(txtSDT.Text)))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                NguoiDung nguoiDung = new NguoiDung
                {
                    HoTen = txtHoTen.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                    MatKhau = txtMatKhau.Text,
                    TenDangNhap = txtTenDangNhap.Text,
                    TrangThai = false,
                    PhanQuyen = "User"
                };
                using (var context = new Context())
                {
                    if (context.NguoiDung.Any(p => p.SDT == nguoiDung.SDT))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại ở tài khoản khác");
                    }
                    else
                    {
                        context.NguoiDung.Add(nguoiDung);
                        context.SaveChanges();
                        DialogResult dialog = MessageBox.Show("Success", "Đăng ký thành công, vui lòng đăng nhập", MessageBoxButtons.OK);
                        if (dialog == DialogResult.OK)
                        {
                            Hide();
                            Login login = new Login();
                            login.ShowDialog();
                        }
                    }
                }
            }
        }

        private bool CheckType(string A)
        {
            if (A.Length == 0 || String.IsNullOrEmpty(A))
            {
                return false;
            }
            return true;
        }
    }
}
