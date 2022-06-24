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

namespace QLCuuSinhVien.CustomControls
{
    public partial class Report_Custom : UserControl
    {
        private List<BaoCaoBaiViet> baoCaos;
        private DataTable data;

        public Report_Custom(List<BaoCaoBaiViet> baoCaoBaiViets)
        {
            InitializeComponent();
            baoCaos = baoCaoBaiViets;
            InitData();
            FillData();
        }

        private void InitData()
        {
            data = new DataTable();
            data.Columns.Add("Mã Bài Viết", typeof(int));
            data.Columns.Add("Tiêu Đề", typeof(string));
            data.Columns.Add("Nội Dung", typeof(string));
            data.Columns.Add("User",typeof(string));
            dgvReport.DataSource = data;
        }

        private void FillData()
        {
            data.Rows.Clear();
            foreach (var item in baoCaos)
            {
                DataRow row = data.NewRow();
                row["Mã Bài Viết"] = item.ID;
                row["Tiêu Đề"] = item.TieuDe;
                row["Nội Dung"] = item.NoiDung;
                data.Rows.Add(row);
            }
        }
    }
}
