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
    public partial class Detail_Profile : DevExpress.XtraEditors.XtraForm
    {
        private NguoiDung nguoiDung;

        public Detail_Profile()
        {
            InitializeComponent();
        }

        public Detail_Profile(NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new Context())
            {
                txtTen_MyProfile.Text = nguoiDung.HoTen.ToString();
                if (nguoiDung.NgaySinh == null)
                {
                    dtpNgaySinh_DetailProfile.Value = DateTime.Today;
                }
                else
                {
                    dtpNgaySinh_DetailProfile.Value = Convert.ToDateTime(nguoiDung.NgaySinh.ToString());
                }
                txtSDT_DetailProfile.Text = nguoiDung.SDT.ToString();
                txtEmail_DetailProfile.Text = nguoiDung.Email.ToString();
                ;
                if (nguoiDung.IDBangCap == null)
                {
                    txtBangCap_DetailProfile.Text = "";
                }
                else
                {
                    txtBangCap_DetailProfile.Text = context.BangCap.FirstOrDefault(p => p.IDBangCap == nguoiDung.IDBangCap).TenBangCap.ToString();
                }
                if (nguoiDung.DiaChi == null)
                {
                    txtDiaChi_DetailProfile.Text = "";
                }
                else
                {
                    txtDiaChi_DetailProfile.Text = nguoiDung.DiaChi.ToString();
                }
                if (nguoiDung.DaLamViecTai == null)
                {
                    txtCV_DetailProfile.Text = "";
                }
                else
                {
                    txtCV_DetailProfile.Text = nguoiDung.DaLamViecTai.ToString();
                }
                if (nguoiDung.MoTa == null)
                {
                    txtMoTa_DetailProfile.Text = "";
                }
                else
                {
                    txtMoTa_DetailProfile.Text = nguoiDung.MoTa.ToString();
                }
                if (nguoiDung.DaLamViecTai == null)
                {
                    txtMoTa_DetailProfile.Text = "";
                }
                else
                {
                    txtMoTa_DetailProfile.Text = nguoiDung.DaLamViecTai.ToString();
                }
                if (nguoiDung.AnhDaiDien == null)
                {
                    imgAnhDaiDien_MyProfile.Image = null;
                }
                else
                {
                    imgAnhDaiDien_MyProfile.Image = Utility.LoadBitmapUnlocked(nguoiDung.AnhDaiDien);
                }
            } 
        }
    }
}
