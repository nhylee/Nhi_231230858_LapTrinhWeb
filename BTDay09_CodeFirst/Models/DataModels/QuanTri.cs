using System.ComponentModel.DataAnnotations;

namespace BTDay09_CodeFirst.Models.DataModels
{
    public class QuanTri
    {
        [Key]
        public int ID { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool? TrangThai { get; set; }
    }
}
