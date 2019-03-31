namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLThiTracNghiem : DbContext
    {
        public QLThiTracNghiem()
            : base("name=QLThiTracNghiem")
        {
        }

        public virtual DbSet<CauHoi> CauHois { get; set; }
        public virtual DbSet<DeThi> DeThis { get; set; }
        public virtual DbSet<DiaChi> DiaChis { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<GopY> Gopies { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<HocSinhDeThi> HocSinhDeThis { get; set; }
        public virtual DbSet<HoSo> HoSoes { get; set; }
        public virtual DbSet<Khoi> Khois { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<LuaChon> LuaChons { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<PhuHuynh> PhuHuynhs { get; set; }
        public virtual DbSet<ThongTinGV> ThongTinGVs { get; set; }
        public virtual DbSet<ThongTinH> ThongTinHS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauHoi>()
                .HasMany(e => e.DeThis)
                .WithMany(e => e.CauHois)
                .Map(m => m.ToTable("CauHoi_DeThi").MapLeftKey("MaCauHoi").MapRightKey("MaDe"));

            modelBuilder.Entity<DeThi>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DeThi>()
                .Property(e => e.MaMH)
                .IsFixedLength();

            modelBuilder.Entity<DeThi>()
                .HasMany(e => e.HocSinhDeThis)
                .WithRequired(e => e.DeThi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DiaChi>()
                .Property(e => e.MaHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.PassWordHash)
                .IsUnicode(false);

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.DeThis)
                .WithOptional(e => e.GiaoVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<GiaoVien>()
                .HasOptional(e => e.ThongTinGV)
                .WithRequired(e => e.GiaoVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.MonHocs)
                .WithMany(e => e.GiaoViens)
                .Map(m => m.ToTable("GiaoVienMonHoc").MapLeftKey("MaGV").MapRightKey("MaMH"));

            modelBuilder.Entity<GopY>()
                .Property(e => e.MaTK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.MaHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.NienKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.PassWordHash)
                .IsUnicode(false);

            modelBuilder.Entity<HocSinh>()
                .HasOptional(e => e.ThongTinH)
                .WithRequired(e => e.HocSinh)
                .WillCascadeOnDelete();

            modelBuilder.Entity<HocSinhDeThi>()
                .Property(e => e.MaHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoSo>()
                .HasMany(e => e.HocSinhs)
                .WithMany(e => e.HoSoes)
                .Map(m => m.ToTable("HoSoHocSinh").MapLeftKey("MaHoSo").MapRightKey("MaHS"));

            modelBuilder.Entity<Khoi>()
                .Property(e => e.MaKhoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaKhoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.GiaoViens)
                .WithMany(e => e.Lops)
                .Map(m => m.ToTable("GiaoVienLop").MapLeftKey("MaLop").MapRightKey("MaGV"));

            modelBuilder.Entity<LuaChon>()
                .HasMany(e => e.HocSinhDeThis)
                .WithMany(e => e.LuaChons)
                .Map(m => m.ToTable("LuaChonHocSinhDeThi").MapLeftKey("MaLuaChon").MapRightKey("MaBT"));

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaMH)
                .IsFixedLength();

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaKhoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhuHuynh>()
                .Property(e => e.MaHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhuHuynh>()
                .Property(e => e.DienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinGV>()
                .Property(e => e.MaGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinGV>()
                .Property(e => e.DienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinGV>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinGV>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinH>()
                .Property(e => e.MaHS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinH>()
                .Property(e => e.DienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinH>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinH>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);
        }
    }
}
