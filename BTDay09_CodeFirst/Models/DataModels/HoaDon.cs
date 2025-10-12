
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BTDay09_CodeFirst.Models.DataModels
{
    public class HoaDon
    {
        [Key]
        public int ID { get; set; }
        public string MaHoaDon { get; set; }

        public int? MaKhachHang { get; set; }
        [ForeignKey("MaKhachHang")]
        public KhachHang KhachHang { get; set; }

        public DateTime? NgayHoaDon { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string HoTenKhachHang { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public decimal? TongTriGia { get; set; }
        public bool? TrangThai { get; set; }

        public ICollection<CT_HoaDon> CT_HoaDons { get; set; }
    }
}
