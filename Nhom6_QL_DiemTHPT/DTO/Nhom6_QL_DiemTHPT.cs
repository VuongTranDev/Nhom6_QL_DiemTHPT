using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Nhom6_QL_DiemTHPT.ASD
{
    public partial class Nhom6_QL_DiemTHPT : DbContext
    {
        public Nhom6_QL_DiemTHPT()
            : base("name=Nhom6_QL_DiemTHPT")
        {
        }

        public virtual DbSet<DIEM> DIEMs { get; set; }
        public virtual DbSet<GIANGDAY> GIANGDAYs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<HOCBA> HOCBAs { get; set; }
        public virtual DbSet<HOCKY> HOCKies { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<HOCSINH_LOP> HOCSINH_LOP { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THONGTINCANHAN> THONGTINCANHANs { get; set; }
        public virtual DbSet<TRUONG> TRUONGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DIEM>()
                .Property(e => e.MAHS)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MAMH)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MALOP)
                .IsUnicode(false);

            modelBuilder.Entity<DIEM>()
                .Property(e => e.MAHK)
                .IsUnicode(false);

            modelBuilder.Entity<GIANGDAY>()
                .Property(e => e.MAGD)
                .IsUnicode(false);

            modelBuilder.Entity<GIANGDAY>()
                .Property(e => e.MAGV)
                .IsUnicode(false);

            modelBuilder.Entity<GIANGDAY>()
                .Property(e => e.MALOP)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.MAGV)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.MAMH)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.MATT)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.MATK)
                .IsUnicode(false);

            modelBuilder.Entity<HOCBA>()
                .Property(e => e.MAHB)
                .IsUnicode(false);

            modelBuilder.Entity<HOCBA>()
                .Property(e => e.MAHS)
                .IsUnicode(false);

            modelBuilder.Entity<HOCKY>()
                .Property(e => e.MAHK)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MAHS)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MATRUONG)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MATT)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH>()
                .Property(e => e.MATK)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH_LOP>()
                .Property(e => e.MAHS)
                .IsUnicode(false);

            modelBuilder.Entity<HOCSINH_LOP>()
                .Property(e => e.MALOP)
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MALOP)
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MAGVCN)
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.MAMH)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MATK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TENTK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<THONGTINCANHAN>()
                .Property(e => e.MATT)
                .IsUnicode(false);

            modelBuilder.Entity<TRUONG>()
                .Property(e => e.MATRUONG)
                .IsUnicode(false);

            modelBuilder.Entity<TRUONG>()
                .Property(e => e.MATK)
                .IsUnicode(false);
        }
    }
}
