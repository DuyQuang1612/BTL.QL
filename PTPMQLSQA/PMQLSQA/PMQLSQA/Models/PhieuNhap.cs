using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{   [Table("PhieuNhap")]
    public class PhieuNhap
    {
        [Key]
        public string MaPhieuNhap { get; set; }
        [Required(ErrorMessage = "SanPhamNhap is require.")]
        public string SanPhamNhap{ get; set; }
        [Required(ErrorMessage = "SoLuongNhap is require.")]
        public int SoLuongNhap { get; set; }
        [Required(ErrorMessage = "NgayNhapHang is require.")]
        [DataType(DataType.Date)]
        public DateTime NgayNhapHang{ get; set; }
        [Required(ErrorMessage = "NguoiNhap is require.")]
        public string NguoiNhap { get; set; }
        [Required(ErrorMessage = "NhaCungCap is require.")]
        public string NhaCungCap { get; set; }

    }
}