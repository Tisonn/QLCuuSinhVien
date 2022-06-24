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
using QLCuuSinhVien.CustomControls;
using QLCuuSinhVien.Properties;
using QLCuuSinhVien.CustomControl;

namespace QLCuuSinhVien.Forms
{
    public partial class Admin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        NguoiDung nguoiDung;

        public Admin(NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = nguoiDung.TenDangNhap.ToString();
            string showString = string.Format("Xin Chào {0}", nguoiDung.HoTen);
            lbNamePage.Text = showString.ToString();
            if (!nguoiDung.PhanQuyen.Equals("Admin"))
            {
                ribbonPage3.Visible = false;
            }
        }

        private void btn_HoSoCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (var context = new Context())
            {
                lbNamePage.Text = ("Hồ Sơ Cá Nhân").ToString();
                pnlContainer.Controls.Clear();
                pnlContainer2.Controls.Clear();
                MyProfile myProfile = new MyProfile();
                if (nguoiDung != null)
                {
                    myProfile.Ten = nguoiDung.HoTen.ToString();
                    myProfile.TenDangNhap = nguoiDung.TenDangNhap.ToString();
                    if (nguoiDung.NgaySinh == null)
                    {
                        myProfile.NgaySinh = "1/1/2000";
                    }
                    else
                    {
                        myProfile.NgaySinh = nguoiDung.NgaySinh.ToString();
                    }
                    if (nguoiDung.SDT == null)
                    {
                        myProfile.SDT = "";
                    }
                    else
                    {
                        myProfile.SDT = nguoiDung.SDT.ToString();
                    }
                    if (nguoiDung.Email == null)
                    {
                        myProfile.Email = "";
                    }
                    else
                    {
                        myProfile.Email = nguoiDung.Email.ToString();
                    }

                    if (nguoiDung.IDBangCap == null || nguoiDung.IdNganh == null)
                    {
                        myProfile.BangCap = "";
                    }
                    else
                    {
                        int IDBangCap = Convert.ToInt32(nguoiDung.IDBangCap.ToString());
                        string TenBangCap = context.BangCap.FirstOrDefault(p => p.IDBangCap == IDBangCap).TenBangCap;
                        int IDNganh = Convert.ToInt32(nguoiDung.IdNganh.ToString());
                        string TenNganh = context.Nganh.FirstOrDefault(p => p.IdNganh == IDNganh).TenNganh;
                        myProfile.BangCap = TenBangCap + " ngành " + TenNganh;

                    }
                    if (nguoiDung.DiaChi == null)
                    {
                        nguoiDung.DiaChi = "";
                    }
                    else
                    {
                        myProfile.DiaChi = nguoiDung.DiaChi.ToString();
                    }
                    if (nguoiDung.CongViecHienTai == null)
                    {
                        myProfile.CongViec = "";
                    }
                    else
                    {
                        myProfile.CongViec = nguoiDung.CongViecHienTai.ToString();
                    }
                    if (nguoiDung.MoTa == null)
                    {
                        myProfile.MoTa = "Chưa có";
                    }
                    else
                    {
                        myProfile.MoTa = nguoiDung.MoTa.ToString();
                    }
                    if (myProfile == null)
                    {
                        myProfile.DaLamViec = "";
                    }
                    else
                    {
                        myProfile.DaLamViec = "";
                    }
                    if (nguoiDung.AnhDaiDien == null)
                    {
                        myProfile.AnhDaiDien = Resources.Profile_pic1;
                    }
                    else
                    {
                        myProfile.AnhDaiDien = Utility.LoadBitmapUnlocked(nguoiDung.AnhDaiDien);
                    }
                }
                xtraTabPage2.Show();
                pnlContainer2.Controls.Add(myProfile);
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHoSo_TrangChu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<string> HoSoQuanTam = listHoSoQuanTam();
            lbNamePage.Text = ("Hồ Sơ Người Dùng").ToString();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            using (var context = new Context())
            {
                List<NguoiDung> students = context.NguoiDung.Where(p => p.IDNguoiDung != nguoiDung.IDNguoiDung && p.TrangThai == true).ToList();               
                foreach (NguoiDung student in students)
                {
                    Custom_Profile custom_Profile = new Custom_Profile(student.IDNguoiDung, nguoiDung.TenDangNhap);
                    if (nguoiDung.PhanQuyen == "User")
                    {
                        custom_Profile.BtnCam = false;
                        custom_Profile.BtnDuyet = false;
                    }
                    if (student.AnhDaiDien == null)
                    {
                        custom_Profile.AnhDaiDien = Resources.Profile_pic1;
                    }
                    else
                    {
                        custom_Profile.AnhDaiDien = Utility.LoadBitmapUnlocked(student.AnhDaiDien);
                    }
                    custom_Profile.Ten = student.HoTen.ToString();
                    custom_Profile.NamSinh = student.NgaySinh;
                    custom_Profile.Email = student.Email;
                    if (student.IDBangCap == null)
                    {
                        custom_Profile.TrinhDo = "";
                    }
                    else
                    {
                        int IDBangCap = Convert.ToInt32(student.IDBangCap.ToString());
                        custom_Profile.TrinhDo = context.BangCap.FirstOrDefault(p => p.IDBangCap == IDBangCap).TenBangCap;
                    }
                    if (student.CongViecHienTai == null)
                    {
                        custom_Profile.CongViecHienTai = "";
                    }
                    else
                    {
                        custom_Profile.CongViecHienTai = student.CongViecHienTai.ToString();
                    }
                    if (HoSoQuanTam.Contains(student.IDNguoiDung.ToString()))
                    {
                        //btnTheoDoi.BackColor = Color.
                        custom_Profile.TheoDoi = "Đã Theo Dõi";
                    }
                    else
                    {
                        //btnTheoDoi.BackColor = Color.Beige;
                        custom_Profile.TheoDoi = "Theo Dõi";
                    }
                    xtraTabPage2.Show();
                    pnlContainer2.Controls.Add(custom_Profile);
                }
            }
        }
        
        private List<string> listHoSoQuanTam()
        {
            using (var context = new Context())
            {
                List<string> list;
                string HoSo = context.NguoiDung.FirstOrDefault(p => p.TenDangNhap.Equals(nguoiDung.TenDangNhap)).HoSoQuanTam;
                if (HoSo == null)
                {
                    list = new List<string>();
                }
                else
                {
                    list = new List<string>(HoSo.Split(','));
                }
                return list;
            }
        }

        private void btnThongBao_TrangChu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbNamePage.Text = ("Thông Báo").ToString();
            xtraTabPage2.Show();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
        }

        private void btnSuaThongTin_Admin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var context = new Context())
            {
                lbNamePage.Text = ("Sửa Thông Tin").ToString();
                pnlContainer.Controls.Clear();
                pnlContainer2.Controls.Clear();
                Change_Profile change = new Change_Profile(nguoiDung);
                change.CloseForm += () => DongForm();
                xtraTabPage2.Show();
                pnlContainer2.Controls.Add(change);
            }
        }

        private void DongForm()
        {
            this.Hide();
        }

        private void btnMatKhau_Admin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            lbNamePage.Text = ("Đổi Mật Khẩu").ToString();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            ChangePass changePass = new ChangePass();
            changePass.CloseForm += () => DongForm();
            xtraTabPage2.Show();
            pnlContainer2.Controls.Add(changePass);
        }

        private void btnXemTatCa_Admin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbNamePage.Text = ("Tất Cả Thông Báo").ToString();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            using (var context = new Context())
            {
                List<ThongBao> thongBaos = context.ThongBao.ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.AnDuyetBai = false;
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Utility.LoadBitmapUnlocked(item.AnhThongBao);
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    xtraTabPage2.Show();
                    pnlContainer2.Controls.Add(thongBao);
                }
            }
        }

        private string LayTenChuDeBangMaChuDe(int Id)
        {
            using (var context = new Context())
            {
                return context.ChuDe.SingleOrDefault(p => p.IDChuDe == Id).TenChuDe;
            }
        }

        private void btnThemBai_Admin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbNamePage.Text = ("Thêm Bài Viết").ToString();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            Add_Notification add_Notification = new Add_Notification(nguoiDung);
            xtraTabPage2.Show();
            pnlContainer2.Controls.Add(add_Notification);
        }

        private void btnXoaBai_Admin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSuaBai_Admin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangXuat_TrangChu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnBaiVietCho_Admin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbNamePage.Text = ("Tài khoản chờ duyệt").ToString();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            using (var context = new Context())
            {
                List<NguoiDung> nguoiDungs = context.NguoiDung.Where(p => p.TrangThai == false).ToList();
                foreach (NguoiDung item in nguoiDungs)
                {
                    Custom_Profile profile = new Custom_Profile(item);
                    xtraTabPage2.Show();
                    pnlContainer2.Controls.Add(profile);
                }
            }
        }

        private void btnTrangChu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbNamePage.Text = ("Trang Chủ").ToString();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            using (var context = new Context())
            {
                List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);

                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Utility.LoadBitmapUnlocked(item.AnhThongBao);
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                   
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                    xtraTabPage1.Show();
                }
            }
        }
        private void btnAllnotification_Click(object sender, EventArgs e)
        {
            lbNamePage.Text = ("Tất Cả Bài Viết").ToString();
            pnlContainer.Controls.Clear();
            using (var context = new Context())
            {
                List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Image.FromFile(item.AnhThongBao.ToString());
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                }
            }
        }

        private void btnThemBai_User_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbNamePage.Text = ("Thêm Bài Viết").ToString();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            Add_Notification add_Notification = new Add_Notification(nguoiDung);
            xtraTabPage2.Show();
            pnlContainer2.Controls.Add(add_Notification);
        }

        private void btnTimKiem_TrangChu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            List<string> HoSoQuanTam = listHoSoQuanTam();
            TimKiem timKiem = new TimKiem();
            timKiem.ShowDialog();
            List<NguoiDung> list = LocalVar.GET_DATA();
            using (var context = new Context())
            {
                foreach (NguoiDung student in list)
                {
                    Custom_Profile custom_Profile = new Custom_Profile(student.IDNguoiDung, nguoiDung.TenDangNhap);
                    custom_Profile.Ten = student.HoTen.ToString();
                    custom_Profile.NamSinh = student.NgaySinh;
                    custom_Profile.Email = student.Email;
                    int IDBangCap = Convert.ToInt32(student.IDBangCap.ToString());
                    custom_Profile.TrinhDo = context.BangCap.FirstOrDefault(p => p.IDBangCap == IDBangCap).TenBangCap;
                    custom_Profile.CongViecHienTai = student.CongViecHienTai.ToString();
                    custom_Profile.AnhDaiDien = Utility.LoadBitmapUnlocked(student.AnhDaiDien);
                    if (HoSoQuanTam.Contains(student.IDNguoiDung.ToString()))
                    {
                        //btnTheoDoi.BackColor = Color.
                        custom_Profile.TheoDoi = "Đã Theo Dõi";
                    }
                    else
                    {
                        
                        custom_Profile.TheoDoi = "Theo Dõi";
                    }
                    custom_Profile.BtnCam = false;
                    custom_Profile.BtnDuyet = false;
                    xtraTabPage2.Show();
                    pnlContainer2.Controls.Add(custom_Profile);
                    LocalVar.SET_DATA(null);
                }
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<string> HoSoQuanTam = listHoSoQuanTam();
            lbNamePage.Text = ("Hồ Sơ Đang Quan Tâm").ToString();
            xtraTabPage2.Show();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
            using (var context = new Context())
            {
                string _theoDoi = context.NguoiDung.FirstOrDefault(p => p.TenDangNhap == nguoiDung.TenDangNhap).HoSoQuanTam;
                if (_theoDoi == null || _theoDoi == "")
                {
                    return;
                }
                if (_theoDoi[0] == ',')
                {
                    _theoDoi = _theoDoi.Substring(1);
                }
                string[] theoDoiList;
                if (_theoDoi != null)
                {
                    theoDoiList = _theoDoi.Split(',');
                    List<NguoiDung> DSTheoDoi = new List<NguoiDung>();
                    foreach (string item in theoDoiList)
                    {
                        int Id = Convert.ToInt32(item);
                        if (Id == nguoiDung.IDNguoiDung)
                        {
                            continue;
                        }
                        NguoiDung temp = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == Id);
                        if (temp != null)
                        {
                            DSTheoDoi.Add(temp);
                        }
                    }
                    foreach (NguoiDung student in DSTheoDoi)
                    {
                        Custom_Profile custom_Profile = new Custom_Profile(student.IDNguoiDung, nguoiDung.TenDangNhap);

                        if(student.AnhDaiDien == null)
                        {
                            custom_Profile.AnhDaiDien = null;
                        }else
                        {
                            custom_Profile.AnhDaiDien = Utility.LoadBitmapUnlocked(student.AnhDaiDien);
                        }
                        custom_Profile.Ten = student.HoTen.ToString();
                        custom_Profile.NamSinh = student.NgaySinh;
                        custom_Profile.Email = student.Email;
                        //custom_Profile.GioiTinh = Convert.ToBoolean(student.GioiTinh) ? "Nam" : "Nữ";
                        if (student.BangCap != null)
                        {
                            custom_Profile.TrinhDo = context.BangCap.FirstOrDefault(p => p.IDBangCap == student.IDBangCap).TenBangCap;
                        }
                        else
                        {
                            custom_Profile.TrinhDo = "";
                        }
                        if (student.CongViecHienTai != null)
                        {
                            custom_Profile.CongViecHienTai = student.CongViecHienTai.ToString();
                        }
                        else
                        {
                            custom_Profile.CongViecHienTai = "";
                        }
                        if (HoSoQuanTam.Contains(student.IDNguoiDung.ToString()))
                        {
                            //btnTheoDoi.BackColor = Color.
                            custom_Profile.TheoDoi = "Đã Theo Dõi";
                        }
                        else
                        {
                            //btnTheoDoi.BackColor = Color.
                            custom_Profile.TheoDoi = "Theo Dõi";
                        }
                        pnlContainer2.Controls.Add(custom_Profile);
                    }
                }

            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lbNamePage.Text = ("Tìm Kiếm Hồ Sơ").ToString();
            xtraTabPage2.Show();
            pnlContainer.Controls.Clear();
            pnlContainer2.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNamePage.Text = ("Thông Tin Diễn Đàn").ToString();
            pnlContainer.Controls.Clear();
            using (var context = new Context())
            {
                //List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                List<ThongBao> thongBaos = (from A in context.ThongBao
                                            join B in context.ChuDe
                                            on A.IDChuDe equals B.IDChuDe
                                            where B.TenChuDe.Equals("Thông Tin Diễn Đàn")
                                            && A.TinhTrang == true
                                            select A).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Image.FromFile(item.AnhThongBao.ToString());
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbNamePage.Text = ("Chia Sẻ Kiến Thức").ToString();
            pnlContainer.Controls.Clear();
            using (var context = new Context())
            {
                //List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                List<ThongBao> thongBaos = (from A in context.ThongBao
                                            join B in context.ChuDe
                                            on A.IDChuDe equals B.IDChuDe
                                            where B.TenChuDe.Equals("Chia Sẻ Kiến Thức")
                                            && A.TinhTrang == true
                                            select A).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Image.FromFile(item.AnhThongBao.ToString());
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbNamePage.Text = ("Thảo Luận Chung").ToString();
            pnlContainer.Controls.Clear();
            using (var context = new Context())
            {
                //List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                List<ThongBao> thongBaos = (from A in context.ThongBao
                                            join B in context.ChuDe
                                            on A.IDChuDe equals B.IDChuDe
                                            where B.TenChuDe.Equals("Thảo Luận Chung")
                                            && A.TinhTrang == true
                                            select A).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Image.FromFile(item.AnhThongBao.ToString());
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbNamePage.Text = ("Việc Làm - Thực Tập").ToString();
            pnlContainer.Controls.Clear();
            using (var context = new Context())
            {
                //List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                List<ThongBao> thongBaos = (from A in context.ThongBao
                                            join B in context.ChuDe
                                            on A.IDChuDe equals B.IDChuDe
                                            where B.TenChuDe.Equals("Việc Làm - Thực Tập")
                                            && A.TinhTrang == true
                                            select A).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Image.FromFile(item.AnhThongBao.ToString());
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbNamePage.Text = ("Giao Lưu - Thư Giản").ToString();
            pnlContainer.Controls.Clear();
            using (var context = new Context())
            {
                //List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                List<ThongBao> thongBaos = (from A in context.ThongBao
                                            join B in context.ChuDe
                                            on A.IDChuDe equals B.IDChuDe
                                            where B.TenChuDe.Equals("Giao Lưu - Thư Giãn")
                                            && A.TinhTrang == true
                                            select A).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Image.FromFile(item.AnhThongBao.ToString());
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lbNamePage.Text = ("Đóng Góp Ý Kiến").ToString();
            pnlContainer.Controls.Clear();
            using (var context = new Context())
            {
                //List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                List<ThongBao> thongBaos = (from A in context.ThongBao
                                            join B in context.ChuDe
                                            on A.IDChuDe equals B.IDChuDe
                                            where B.TenChuDe.Equals("Đóng Góp Ý Kiến")
                                            && A.TinhTrang == true
                                            select A).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.TenThongBao = item.TieuDe;
                    if (item.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Image.FromFile(item.AnhThongBao.ToString());
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lbNamePage.Text = ("Bài Viết Mới Nhất").ToString();
            pnlContainer.Controls.Clear();
            using (var context = new Context())
            {
                //List<ThongBao> thongBaos = context.ThongBao.Where(p => p.TinhTrang == true).ToList();
                List<ThongBao> thongBaos = (from A in context.ThongBao
                                            join B in context.ChuDe
                                            on A.IDChuDe equals B.IDChuDe
                                            where B.TenChuDe.Equals("Bài Viết Mới Nhất")
                                            && A.TinhTrang == true
                                            select A).ToList();
                foreach (ThongBao item in thongBaos)
                {
                    Custom_Notification thongBao = new Custom_Notification(nguoiDung);
                    thongBao.IDThongBao = item.IDThongBao.ToString();
                    thongBao.AnDuyetBai = false;
                    thongBao.AnSuaBaiViet = false;
                    thongBao.AnXoaBai = false;
                    thongBao.NguoiDang = context.NguoiDung.FirstOrDefault(p => p.IDNguoiDung == item.IDNguoiDung).TenDangNhap;

                    thongBao.TenThongBao = item.TieuDe;
                    if (thongBao.AnhThongBao != null)
                    {
                        thongBao.AnhThongBao = Image.FromFile(thongBao.AnhThongBao.ToString());
                    }
                    else
                    {
                        thongBao.AnhThongBao = null;
                    }
                    thongBao.NoiDungThongBao = item.NoiDung;
                    thongBao.ChuDe = LayTenChuDeBangMaChuDe(Convert.ToInt32(item.IDChuDe));
                    pnlContainer.Controls.Add(thongBao);
                }
            }
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var context = new Context())
            {
                lbNamePage.Text = ("Tất Cả Thông Báo").ToString();
                pnlContainer.Controls.Clear();
                pnlContainer2.Controls.Clear();

                List<BaoCaoBaiViet> list = context.BaoCaoBaiViet.ToList();
                Report_Custom report_Custom = new Report_Custom(list);

                pnlContainer2.Controls.Add(report_Custom);
                xtraTabPage2.Show();
            }
        }
    }
}
