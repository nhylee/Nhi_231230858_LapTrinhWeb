using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTDay09_CodeFirst.Models.DataModels
{
    public class CT_HoaDon
    {
        [Key]
        public int ID { get; set; }

        public int? HoaDonID { get; set; }
        [ForeignKey("HoaDonID")]
        public HoaDon HoaDon { get; set; }

        public int? SanPhamID { get; set; }
        [ForeignKey("SanPhamID")]
        public SanPham SanPham { get; set; }

        public int? SoLuongMua { get; set; }
        public decimal? DonGiaMua { get; set; }
        public decimal? ThanhTien { get; set; }
        public bool? TrangThai { get; set; }
    }
}
