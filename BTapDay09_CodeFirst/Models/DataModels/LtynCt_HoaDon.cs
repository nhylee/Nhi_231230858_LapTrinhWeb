using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTapDay09_CodeFirst.Models.DataModels
{
    [Table("LtynCT_HOA_DON")]
    public class LtynCt_HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ltynID { get; set; }

        // Khóa ngoại đến HOA_DON
        [ForeignKey("LtynHoaDon")]
        public int? ltynHoaDonID { get; set; }

        // Khóa ngoại đến SAN_PHAM
        [ForeignKey("LtynSanPham")]
        public int? ltynSanPhamID { get; set; }

        [Display(Name = "Số lượng mua")]
        public int? ltynSoLuongMua { get; set; }

        [Display(Name = "Đơn giá mua")]
        public double? ltynDonGiaMua { get; set; }

        [Display(Name = "Thành tiền")]
        public double? ltynThanhTien { get; set; }

        public bool? ltynTrangThai { get; set; }

        // Quan hệ n-1
        public LtynHoaDon? LtynHoaDon { get; set; }
        public LtynSanPham? LtynSanPham { get; set; }
    }
}
