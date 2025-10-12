using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BTDay09_CodeFirst.Models.DataModels
{
    public class LoaiSanPham
    {
        [Key]
        public int ID { get; set; }
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public bool? TrangThai { get; set; }

        // Quan hệ 1-nhiều: 1 loại có nhiều sản phẩm
        public ICollection<SanPham> SanPhams { get; set; }
    }
}
