using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTapDay09_CodeFirst.Models.DataModels
{
    [Table("LtynSAN_PHAM")]
    public class LtynSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ltynID { get; set; }

        [Display(Name = "Mã sản phẩm")]
        [StringLength(50)]
        public string ltynMaSanPham { get; set; }

        [Display(Name = "Tên sản phẩm")]
        [StringLength(255)]
        public string ltynTenSanPham { get; set; }

        [Display(Name = "Hình ảnh")]
        [StringLength(255)]
        public string? ltynHinhAnh { get; set; }

        [Display(Name = "Số lượng")]
        public int? ltynSoLuong { get; set; }

        [Display(Name = "Đơn giá")]
        public double? ltynDonGia { get; set; }

        // Khóa ngoại đến LOAI_SAN_PHAM
        [ForeignKey("LtynLoaiSanPham")]
        public int? ltynMaLoai { get; set; }

        public bool? ltynTrangThai { get; set; }

        // Quan hệ n-1: Nhiều sản phẩm thuộc 1 loại
        public LtynLoaiSanPham? LtynLoaiSanPham { get; set; }

        // Quan hệ 1-nhiều: 1 sản phẩm có thể có nhiều chi tiết hóa đơn
        public ICollection<LtynCt_HoaDon>? LtynCt_HoaDons { get; set; }
    }
}
