namespace QLCuuSinhVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoCaoBaiViet")]
    public partial class BaoCaoBaiViet
    {
        public int ID { get; set; }

        public int? IdThongBao { get; set; }

        [StringLength(255)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public virtual ThongBao ThongBao { get; set; }
    }
}
