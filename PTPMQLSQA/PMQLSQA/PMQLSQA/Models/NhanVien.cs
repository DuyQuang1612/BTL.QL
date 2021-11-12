using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        
        public string MaNhanVien { get; set; }
        [Required(ErrorMessage = "TenNhanVien is required.")]
        public string TenNhanVien { get; set; }
        [Required(ErrorMessage = "GioiTinh is required.")]
        public string GioiTinh { get; set; }
        [Required(ErrorMessage = "SoDienThoai is required.")]
        public string SoDienThoai { get; set; }
        [Required(ErrorMessage = "TenDangNhapNhanVien is require")]
        public string TenDangNhapNhanVien { get; set; }
        [DataType(DataType.Password)]
        public string MatKhauNhanVien { get; set; }
        [Compare("MatKhauNhanVien", ErrorMessage = "MatKhauNhanVien is require")]
        public string ConfirmMatKhauNhanVien{ get; set; }
    }
}
