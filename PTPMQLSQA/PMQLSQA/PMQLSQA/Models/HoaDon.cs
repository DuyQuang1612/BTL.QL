using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public string MaHoaDon { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgayLapHoaDon { get; set; }
        [Required(ErrorMessage = "TenSanPham is require.")]
        public string TenSanPham { get; set; }
        [Required(ErrorMessage = "DonGia is require.")]
        public decimal DonGia { get; set; }
        [Required(ErrorMessage = "SoLuongSanPham is require.")]
        public int SoLuongSanPham { get; set; }
        [Required(ErrorMessage = "KhachHang is require.")]
        public string KhachHang { get; set; }
        [Required(ErrorMessage = "NhanVienLapHoaDon is require.")]
        public string NhanVienLapHoaDon { get; set; }

    }
}