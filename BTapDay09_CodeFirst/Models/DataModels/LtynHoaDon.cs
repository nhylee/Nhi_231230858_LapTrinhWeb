using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTapDay09_CodeFirst.Models.DataModels
{
    [Table("LtynHOA_DON")]
    public class LtynHoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ltynID { get; set; }

        [Display(Name = "Mã hóa đơn")]
        [StringLength(50)]
        public string ltynMaHoaDon { get; set; }

        // Khóa ngoại đến KHACH_HANG
        [ForeignKey("LtynKhachHang")]
        public int? ltynMaKhachHang { get; set; }

        [Display(Name = "Ngày hóa đơn")]
        public DateTime? ltynNgayHoaDon { get; set; }

        [Display(Name = "Ngày nhận hàng")]
        public DateTime? ltynNgayNhan { get; set; }

        [Display(Name = "Họ tên khách hàng")]
        [StringLength(255)]
        public string? ltynHoTenKhachHang { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string? ltynEmail { get; set; }

        [Display(Name = "Điện thoại")]
        [StringLength(10)]
        public string? ltynDienThoai { get; set; }

        [Display(Name = "Địa chỉ giao hàng")]
        [StringLength(255)]
        public string? ltynDiaChi { get; set; }

        [Display(Name = "Tổng trị giá")]
        public double? ltynTongTriGia { get; set; }

        public bool? ltynTrangThai { get; set; }

        // Quan hệ n-1: Nhiều hóa đơn thuộc 1 khách hàng
        public LtynKhachHang? LtynKhachHang { get; set; }

        // Quan hệ 1-nhiều: 1 hóa đơn có nhiều chi tiết hóa đơn
        public ICollection<LtynCt_HoaDon>? LtynCt_HoaDons { get; set; }
    }
}
