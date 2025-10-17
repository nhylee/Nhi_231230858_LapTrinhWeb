using BTDay09_CodeFirst.Models.DataModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore; 
namespace BTDay09_CodeFirst.Data
{
    public class QLBHContext : DbContext
    {
        public QLBHContext(DbContextOptions<QLBHContext> options) : base(options) { }

        public DbSet<QuanTri> QuanTris { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<CT_HoaDon> CT_HoaDons { get; set; }
        public DbSet<LtynSanPham> SanPhams { get; set; }
        public DbSet<LtynLoaiSanPham> LoaiSanPhams { get; set; }
    }
}
