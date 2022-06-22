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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
            LoadBangCap();
            LoadNganh();
        }

        private void LoadBangCap()
        {
            using (var context = new Context())
            {
                List<BangCap> list = context.BangCap.ToList();
                cboBangCap.DataSource = list;
                cboBangCap.ValueMember = "IDBangCap";
                cboBangCap.DisplayMember = "TenBangCap";
            }
        }

        private void LoadNganh()
        {
            using (var context = new Context())
            {
                List<Nganh> list = context.Nganh.ToList();
                cboNganh.DataSource = list;
                cboNganh.DisplayMember = "TenNganh";
                cboNganh.ValueMember = "IdNganh";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string bangCap = cboBangCap.Text.ToString();
            string nganh = cboNganh.Text.ToString();
            using (var context = new Context())
            {
                List<NguoiDung> nguoiDungTheoBangCap = (from A in context.NguoiDung
                                                        join B in context.BangCap
                                                        on A.IDBangCap equals B.IDBangCap
                                                        join C in context.Nganh
                                                        on A.IdNganh equals C.IdNganh
                                                        where B.TenBangCap.Equals(bangCap)
                                                        && C.TenNganh.Equals(nganh)
                                                        select A).ToList();
                                                     
                LocalVar.SET_DATA(null);
                LocalVar.SET_DATA(nguoiDungTheoBangCap);
                Close();
            }
        }

        private void TimKiem_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
