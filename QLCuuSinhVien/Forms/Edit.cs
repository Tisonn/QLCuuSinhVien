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
    public partial class Edit : DevExpress.XtraEditors.XtraForm
    {
        NguoiDung nguoiDung;
        string TieuDe, NoiDung, ChuDe;
        Image AnhThongBao;

        public Edit()
        {
            InitializeComponent();
            LoadChuDe();
        }

        public void LoadChuDe()
        {
            using (var context = new Context())
            {
                List<ChuDe> list = context.ChuDe.ToList();
                cbChuDe_Edit.DataSource = list;
                cbChuDe_Edit.DisplayMember = "TenChuDe";
                cbChuDe_Edit.ValueMember = "IDChuDe";
            }
        }

        public Edit(NguoiDung nguoiDung, string TieuDe, string NoiDung, Image AnhThongBao, string ChuDe)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.TieuDe = TieuDe;
            this.NoiDung = NoiDung;
            this.AnhThongBao = AnhThongBao;
            this.ChuDe = ChuDe;
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            txtTenBai_Edit.Text = TieuDe;
            txtNoiDung_Edit.Text = NoiDung;
            cbChuDe_Edit.Text = ChuDe;
            pictureBox1.Image = AnhThongBao;
        }

        private void btnThemBaiViet_Edit_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                ThongBao thongBao = context.ThongBao.FirstOrDefault(p => p.TieuDe.Equals(TieuDe) && p.NoiDung.Equals(NoiDung));
                try
                {
                    thongBao.TieuDe = txtTenBai_Edit.Text.ToString();
                    thongBao.NoiDung = txtNoiDung_Edit.Text.ToString();
                    thongBao.IDChuDe = Convert.ToInt32(cbChuDe_Edit.SelectedValue.ToString());
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công");
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
