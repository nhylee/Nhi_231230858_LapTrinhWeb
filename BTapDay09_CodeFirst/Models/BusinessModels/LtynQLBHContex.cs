using BTapDay09_CodeFirst.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BTapDay09_CodeFirst.BusinessModels
{
    public class LtynQLBHContext : DbContext
    {
        public LtynQLBHContext()
        {
        }

        public LtynQLBHContext(DbContextOptions<LtynQLBHContext> options)
            : base(options)
        {
        }

        // Khai báo các bảng trong cơ sở dữ liệu (DbSet)
        public DbSet<LtynLoaiSanPham> LtynLoaiSanPhams { get; set; }
        public DbSet<LtynSanPham> LtynSanPhams { get; set; }
        public DbSet<LtynKhachHang> LtynKhachHangs { get; set; }
        public DbSet<LtynHoaDon> LtynHoaDons { get; set; }
        public DbSet<LtynCt_HoaDon> LtynCt_HoaDons { get; set; }
        public DbSet<LtynQuanTri> LtynQuanTris { get; set; }
    }
}
