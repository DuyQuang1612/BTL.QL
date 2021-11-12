using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{
    [Table("PhieuXuat")]
    public class PhieuXuat
    {  
       [Key]
        public string MaPhieuXuat { get; set; }
        [Required(ErrorMessage = "SanPhamXuat is require.")]
        public string SanPhamXuat { get; set; }
        [Required(ErrorMessage = "SoLuongXuat is require.")]
        public int SoLuongXuat { get; set; }
        [Required(ErrorMessage = "NgayXuatHang is require.")]
        [DataType(DataType.Date)]
        public DateTime NgayXuatHang { get; set; }
        [Required(ErrorMessage = "NguoiBan is require.")]
        public string NguoiBan { get; set; }
        [Required(ErrorMessage = "KhachHangMua is require.")]
        public string KhachHangMua { get; set; }

    }

}
