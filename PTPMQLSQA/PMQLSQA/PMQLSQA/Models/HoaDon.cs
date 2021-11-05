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
        public string TenSanPham { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongSanPham { get; set; }
        public string KhachHang { get; set; }
        public string NhanVienLapHoaDon { get; set; }

    }
}