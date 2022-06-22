using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLCuuSinhVien.Models
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<BangCap> BangCap { get; set; }
        public virtual DbSet<BaoCaoBaiViet> BaoCaoBaiViet { get; set; }
        public virtual DbSet<ChuDe> ChuDe { get; set; }
        public virtual DbSet<Nganh> Nganh { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ThongBao> ThongBao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.NgaySinh)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.SDT)
                .IsUnicode(false);
        }
    }
}
