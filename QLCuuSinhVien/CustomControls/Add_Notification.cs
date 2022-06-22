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
using QLCuuSinhVien.Models;

namespace QLCuuSinhVien.CustomControls
{
    public partial class Add_Notification : UserControl
    {
        NguoiDung nguoiDung;
        private string PATH = "";
        public Add_Notification(NguoiDung nguoiDung)
        {
            this.nguoiDung = nguoiDung;
            InitializeComponent();
            LoadChuDe();
        }

        public void LoadChuDe()
        {
            using (var context = new Context())
            {
                List<ChuDe> list = context.ChuDe.ToList();
                cboChuDe.DataSource = list;
                cboChuDe.DisplayMember = "TenChuDe";
                cboChuDe.ValueMember = "IDChuDe";
            }
        }

        [Category("VietTuan")]
        public string TenThongBao
        {
            get => txtTenBai_Add.Text.ToString();
            set => txtTenBai_Add.Text = value;
        }

        [Category("VietTuan")]
        public Image AnhThongBao
        {
            get => PbImage_Add_Notification.Image;
            set => PbImage_Add_Notification.Image = value;
        }

        [Category("VietTuan")]
        public string NoiDungThongBao
        {
            get => txtNoiDung_Add.Text.ToString();
            set => txtNoiDung_Add.Text = value;
        }
        public string ChuDe
        {
            get => cboChuDe.Text.ToString();
            set => cboChuDe.Text = value;
        }
        private void btnThemAnh_Add_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";


                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PATH = dialog.FileName;
                    PbImage_Add_Notification.Image = Utility.LoadBitmapUnlocked(dialog.FileName);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemBaiViet_Add_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                try
                {
                    ThongBao thongBao = new ThongBao();
                    thongBao.TieuDe = txtTenBai_Add.Text.ToString();
                    thongBao.NoiDung = txtNoiDung_Add.Text.ToString();
                    thongBao.IDNguoiDung = nguoiDung.IDNguoiDung;
                    thongBao.IDChuDe = Convert.ToInt32(cboChuDe.SelectedValue.ToString());
                    string id = Guid.NewGuid().ToString();
                    thongBao.AnhThongBao = @"D:\IMAGESERVER\" + id + ".jpeg";
                    thongBao.TinhTrang = true;
                    context.ThongBao.Add(thongBao);
                    context.SaveChanges();
                    if (PATH != null)
                    {
                        File.Copy(PATH, Path.Combine(@"D:\IMAGESERVER\", id + ".jpeg"), true);
                    }
                    MessageBox.Show("Thêm thông báo mới thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
