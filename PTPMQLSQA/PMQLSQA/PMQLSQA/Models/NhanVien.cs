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
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string TenDangNhapNhanVien { get; set; }
        public string MatKhauNhanVien { get; set; }
    }
}