using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TrenLop_10_3.Models;

namespace TrenLop_10_3.Data;

public partial class QLBHContext : DbContext
{
    public QLBHContext()
    {
    }

    public QLBHContext(DbContextOptions<QLBHContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CtHoaDon> CtHoaDons { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOPNHYLEE;Database=QLBH;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CtHoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CT_HOA_D__3214EC27CAE83228");

            entity.ToTable("CT_HOA_DON");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.CtHoaDons)
                .HasForeignKey(d => d.HoaDonId)
                .HasConstraintName("FK__CT_HOA_DO__HoaDo__59063A47");

            entity.HasOne(d => d.SanPham).WithMany(p => p.CtHoaDons)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__CT_HOA_DO__SanPh__59FA5E80");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HOA_DON__3214EC27433550F2");

            entity.ToTable("HOA_DON");

            entity.HasIndex(e => e.MaHoaDon, "UQ__HOA_DON__835ED13A8A049E66").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HoTenKhachHang).HasMaxLength(255);
            entity.Property(e => e.MaHoaDon)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NgayHoaDon).HasColumnType("datetime");
            entity.Property(e => e.NgayNhan).HasColumnType("datetime");

            entity.HasOne(d => d.MaKhaHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKhaHang)
                .HasConstraintName("FK__HOA_DON__MaKhaHa__5629CD9C");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KHACH_HA__3214EC275133E34A");

            entity.ToTable("KHACH_HANG");

            entity.HasIndex(e => e.DienThoai, "UQ__KHACH_HA__1F03187626A0E103").IsUnique();

            entity.HasIndex(e => e.MaKhachHang, "UQ__KHACH_HA__88D2F0E44525EE18").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__KHACH_HA__A9D1053445423376").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HoTenKhachHang).HasMaxLength(255);
            entity.Property(e => e.MaKhachHang)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MaKhau)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NgayDangKy).HasColumnType("datetime");
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOAI_SAN__3214EC27BF29D2CB");

            entity.ToTable("LOAI_SAN_PHAM");

            entity.HasIndex(e => e.MaLoai, "UQ__LOAI_SAN__730A5758AAFB5796").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaLoai)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TenLoai).HasMaxLength(255);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SAN_PHAM__3214EC278F48A4AE");

            entity.ToTable("SAN_PHAM");

            entity.HasIndex(e => e.MaSanPham, "UQ__SAN_PHAM__FAC7442C85DA3FB3").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HinhAnh).HasMaxLength(255);
            entity.Property(e => e.MaSanPham)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TenSanPham).HasMaxLength(255);

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaLoai)
                .HasConstraintName("FK__SAN_PHAM__MaLoai__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
