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
namespace QLCuuSinhVien
{
    public partial class TimKiem : DevExpress.XtraEditors.XtraForm
    {
        public TimKiem()
        {
            InitializeComponent();
            LoadBangCap();
            LoadNganh();
        }

        private void LoadBangCap()
        {
            cboNganh.Items.Add("");
            using (var context = new Context())
            {
                List<BangCap> list = context.BangCap.ToList();

                foreach (var item in list)
                {
                    cboBangCap.Items.Add(item.TenBangCap);
                }
            }
        }

        private void LoadNganh()
        {
            using (var context = new Context())
            {
                List<Nganh> list = context.Nganh.ToList();
                foreach (var item in list)
                {
                    cboNganh.Items.Add(item.TenNganh);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string noidung = txtNoiDung.Text;
            string bangCap = cboBangCap.Text.ToString();
            string nganh = cboNganh.Text.ToString();
            using (var context = new Context())
            {
                List<NguoiDung> dsNguoiDung = new List<NguoiDung>();
                if (bangCap.Equals("") && nganh.Equals(""))
                {
                    dsNguoiDung = context.NguoiDung.ToList();
                }
                else if (nganh.Equals(""))
                {
                    dsNguoiDung = (from A in context.NguoiDung
                                   join B in context.BangCap
                                   on A.IDBangCap equals B.IDBangCap
                                   where B.TenBangCap == bangCap
                                   && A.HoTen.Contains(noidung)
                                   && A.TenDangNhap.Contains(noidung)
                                   select A).ToList();
                }
                else if (bangCap.Equals(""))
                {
                    dsNguoiDung = (from A in context.NguoiDung
                                   join B in context.Nganh
                                   on A.IdNganh equals B.IdNganh
                                   where B.TenNganh == nganh
                                   && A.HoTen.Contains(noidung)
                                   && A.TenDangNhap.Contains(noidung)
                                   select A).ToList();
                }
                else
                {
                    dsNguoiDung = (from A in context.NguoiDung
                                   join B in context.BangCap
                                   on A.IDBangCap equals B.IDBangCap
                                   join C in context.Nganh
                                   on A.IdNganh equals C.IdNganh
                                   where B.TenBangCap.Equals(bangCap)
                                   && C.TenNganh.Equals(nganh)
                                   && A.HoTen.Contains(noidung)
                                   && A.TenDangNhap.Contains(noidung)
                                   select A).ToList();
                }

                LocalVar.SET_DATA(null);
                LocalVar.SET_DATA(dsNguoiDung);
                Close();
            }
        }
    }
}
