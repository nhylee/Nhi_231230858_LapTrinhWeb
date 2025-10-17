using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTapDay09_CodeFirst.Models.DataModels
{
    [Table("LtynQUAN_TRI")]
    public class LtynQuanTri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ltynID { get; set; }

        [Display(Name = "Tên đăng nhập")]
        [StringLength(50)]
        public string ltynTenDangNhap { get; set; }

        [Display(Name = "Mật khẩu")]
        [StringLength(255)]
        public string ltynMatKhau { get; set; }

        [Display(Name = "Họ tên quản trị")]
        [StringLength(255)]
        public string? ltynHoTen { get; set; }

        public bool? ltynTrangThai { get; set; }
    }
}
