using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuuSinhVien.Forms;
using QLCuuSinhVien.Models;

namespace QLCuuSinhVien.CustomControls
{
    public partial class ChangePass : DevExpress.XtraEditors.XtraUserControl
    {
        public event CloseForm CloseForm;
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                string TenDN = txtUsername.Text.ToString().Trim();
                NguoiDung nguoiDung = context.NguoiDung.FirstOrDefault(p => p.TenDangNhap == TenDN);

                string MatKhauCu = nguoiDung.MatKhau;
                if (MatKhauCu != txtOldPassword.Text.ToString())
                {
                    MessageBox.Show("Mật khẩu cũ không đúng");
                }
                else
                {
                    if (txtNewPassword.Text.ToString() != txtConfirmPassword.Text.ToString())
                    {
                        MessageBox.Show("Mật khẩu không khớp");
                    }
                    else
                    {
                        try
                        {
                            nguoiDung.MatKhau = txtConfirmPassword.Text.ToString();
                            context.SaveChanges();
                            MessageBox.Show("Thay đổi mật khẩu thành công");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                }
                CloseForm();
                Login login = new Login();
                login.Show();
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel6_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxStrength_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxMatch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
