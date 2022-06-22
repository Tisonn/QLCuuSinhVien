namespace QLCuuSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            ThongBao = new HashSet<ThongBao>();
        }

        [Key]
        public int IDNguoiDung { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(11)]
        public string NgaySinh { get; set; }

        public string DiaChi { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string CongViecHienTai { get; set; }

        public string AnhDaiDien { get; set; }

        public bool? GioiTinh { get; set; }

        public string MoTa { get; set; }

        [Required]
        [StringLength(24)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(24)]
        public string MatKhau { get; set; }

        [StringLength(20)]
        public string PhanQuyen { get; set; }

        public string HoSoQuanTam { get; set; }

        public int? IDBangCap { get; set; }

        public int? IdNganh { get; set; }

        public string DaLamViecTai { get; set; }

        public bool? TrangThai { get; set; }

        public virtual BangCap BangCap { get; set; }

        public virtual Nganh Nganh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongBao> ThongBao { get; set; }
    }
}
