using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BTDay09_CodeFirst.Models.DataModels { 

    [Table("LtynSan_Pham")]
    public class LtynSanPham
    {
  
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ltynID { get; set; }
        public string ltynMaSanPham { get; set; }
        public string ltynTenSanPham { get; set; }
        public string ltynHinhAnh { get; set; }
        public int? ltynSoLuong { get; set; }
        public decimal? ltynDonGia { get; set; }
        public bool? ltynTrangThai { get; set; }

        public int? ltynMaLoai { get; set; }
        
        public LtynLoaiSanPham ltynLoaiSanPham { get; set; }
    }
}
