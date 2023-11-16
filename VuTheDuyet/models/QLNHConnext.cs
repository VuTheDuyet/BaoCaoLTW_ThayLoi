using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VuTheDuyet.models
{
    public partial class QLNHConnext : DbContext
    {
        public QLNHConnext()
            : base("name=ChuoiKN")
        {
        }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<PhanLoaiMonAn> PhanLoaiMonAns { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .Property(e => e.MaBan)
                .IsFixedLength();

            modelBuilder.Entity<MonAn>()
                .Property(e => e.MaMonAn)
                .IsFixedLength();

            modelBuilder.Entity<PhanLoaiMonAn>()
                .HasMany(e => e.MonAns)
                .WithRequired(e => e.PhanLoaiMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhVien>()
                .Property(e => e.TenDangNhap)
                .IsFixedLength();
        }
    }
}
