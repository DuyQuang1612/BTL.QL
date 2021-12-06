using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{   [Table("DonHang")]
    public class DonHang
    {
        [Key]
        [DataType(DataType.Date)]
        public DateTime NgayLapDonHang { get; set; }
        [Required(ErrorMessage = "TenSanPham is require.")]
        public string TenSP { get; set; }
        [Required(ErrorMessage = "DonGia is require.")]
        public decimal GiaSP { get; set; }
        [Required(ErrorMessage = "SoLuongSanPham is require.")]
        public int SoLuongSP{ get; set; }
        [Required(ErrorMessage = "KhachHang is require.")]
        public string KhachHangMua { get; set; }
        [Required(ErrorMessage = "NhanVienLapDonHang is require.")]
        public string NhanVienLapDonHang { get; set; }
    }
}