namespace QLCuuSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongBao")]
    public partial class ThongBao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongBao()
        {
            BaoCaoBaiViet = new HashSet<BaoCaoBaiViet>();
        }

        [Key]
        public int IDThongBao { get; set; }

        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public int? IDNguoiDung { get; set; }

        public int? IDChuDe { get; set; }

        public string AnhThongBao { get; set; }

        public bool? TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoCaoBaiViet> BaoCaoBaiViet { get; set; }

        public virtual ChuDe ChuDe { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
