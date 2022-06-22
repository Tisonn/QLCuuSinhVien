using QLCuuSinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuuSinhVien.Forms
{
    public partial class Notifications : DevExpress.XtraEditors.XtraForm
    {
        private int ID;

        public Notifications(int ID)
        {
            this.ID = ID;
            InitializeComponent(); LoadData();
        }

        private void LoadData()
        {
            using (var context = new Context())
            {
                ThongBao thongBao = context.ThongBao.FirstOrDefault(p => p.IDThongBao == ID);
                pictureBox1.Image = Utility.LoadBitmapUnlocked(thongBao.AnhThongBao);
                txtChuDe.Text = context.ChuDe.FirstOrDefault(p => p.IDChuDe == thongBao.IDChuDe).TenChuDe.ToString();
                txtTieuDe.Text = thongBao.TieuDe.ToString();
                txtNguoiDang.Text = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == thongBao.IDNguoiDung).TenDangNhap.ToString();
                txtNoiDung.Text = thongBao.NoiDung.ToString();

            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Report report = new Report(ID);
            Hide();
            report.ShowDialog();
        }
    }
}
