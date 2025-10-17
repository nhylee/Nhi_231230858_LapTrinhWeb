using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTapDay09_CodeFirst.Models.DataModels
{
    [Table("LtynKHACH_HANG")]
    public class LtynKhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ltynID { get; set; }

        [Display(Name = "Mã khách hàng")]
        [StringLength(50)]
        public string? ltynMaKhachHang { get; set; }

        [Display(Name = "Họ tên khách hàng")]
        [StringLength(255)]
        public string? ltynHoTenKhachHang { get; set; }

        [Display(Name = "Email")]
        [StringLength(255)]
        public string? ltynEmail { get; set; }

        [Display(Name = "Mật khẩu")]
        [StringLength(255)]
        public string? ltynMatKhau { get; set; }

        [Display(Name = "Điện thoại")]
        [StringLength(10)]
        public string? ltynDienThoai { get; set; }

        [Display(Name = "Địa chỉ")]
        [StringLength(255)]
        public string? ltynDiaChi { get; set; }

        [Display(Name = "Ngày đăng ký")]
        public DateTime? ltynNgayDangKy { get; set; }

        public bool? ltynTrangThai { get; set; }

        // 1 khách hàng có thể có nhiều hóa đơn
        public ICollection<LtynHoaDon>? LtynHoaDons { get; set; }
    }
}
