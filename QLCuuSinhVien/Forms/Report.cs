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
    public partial class Report : Form
    {
        private int ID;

        public Report(int Id)
        {
            InitializeComponent();
            ID = Id;
        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                ThongBao thongBao = context.ThongBao.FirstOrDefault(p => p.IDThongBao == ID);
                if (thongBao != null)
                {
                    BaoCaoBaiViet baoCao = new BaoCaoBaiViet
                    {
                        IdThongBao = thongBao.IDThongBao,
                        TieuDe = txtTieuDe.Text.ToString(),
                        NoiDung = txtNoiDung.Text.ToString()
                    };
                    context.BaoCaoBaiViet.Add(baoCao);
                    context.SaveChanges();
                    MessageBox.Show("Gửi báo cáo thành công");
                    Hide();
                }
            }
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
