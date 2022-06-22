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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                DangNhap();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            string username = txtUsername.Text.ToString().Trim();
            string password = txtPassword.Text.ToString().Trim();

            var errors = new List<string>();
            if (username.Length <= 0) errors.Add(@"Bạn chưa nhập tên đăng nhập");
            if (password.Length <= 0) errors.Add(@"Bạn chưa nhập mật khẩu");

            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join(Environment.NewLine, errors), @"Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            using (var context = new Context())
            {
                if (context.NguoiDung.Any(p => p.TenDangNhap.Equals(username)))
                {
                    NguoiDung nguoiDung = context.NguoiDung.FirstOrDefault(p => p.TenDangNhap == username);

                    if (password == nguoiDung.MatKhau)
                    {
                        if (nguoiDung.TrangThai == false)
                        {
                            MessageBox.Show("Tài khoản của bạn chưa được duyệt. Vui lòng thử lại sau");
                        }
                        else
                        {
                            txtUsername.Clear();
                            txtPassword.Clear();
                            Admin admin = new Admin(nguoiDung);
                            Hide();
                            admin.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Sai thông tin đăng nhập!", @"Lỗi đăng nhập", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show(@"Không tìm thấy người dùng này!", @"Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Register DangKi = new Register();
            DangKi.Show();
        }
    }
}
