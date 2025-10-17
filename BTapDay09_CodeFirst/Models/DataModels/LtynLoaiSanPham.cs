using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BTapDay09_CodeFirst.Models.DataModels
{
    [Table("LtynLOAI_SAN_PHAM")]
    public class LtynLoaiSanPham
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int ltynID { get; set; }
        [Display(Name = "Ma Loai")]
        [StringLength(10)]
        public string ltynMaLoai { get; set; }
        [Display(Name = "Ten Loai")]
        [StringLength(10)]
        public string ltynTenLoai { get; set; }
        public bool? ltynTrangThai { get; set; }

        // Quan hệ 1-nhiều: 1 loại có nhiều sản phẩm
        public ICollection<LtynSanPham> LtynSanPhams { get; set; }
    }
}
