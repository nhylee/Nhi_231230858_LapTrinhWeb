using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BTDay09_CodeFirst.Models.DataModels
{
    public class SanPham
    {
        [Key]
        public int ID { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string HinhAnh { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public bool? TrangThai { get; set; }

        public int? MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public LoaiSanPham LoaiSanPham { get; set; }
    }
}
