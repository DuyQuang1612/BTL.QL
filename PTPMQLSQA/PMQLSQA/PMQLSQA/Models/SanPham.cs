using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public string MaSanPham { get; set; }
        [Required(ErrorMessage = "TenSanPham is require")]
        public string TenSanPham { get; set; }
        [Required(ErrorMessage = "GiaSanPham is require")]
        public decimal GiaSanPham { get; set; }
        [Required(ErrorMessage = "XuatXu is require")]
        public string XuatXu { get; set; }
        [Required(ErrorMessage = "SoLuong is require")]
        public int SoLuong { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgaySanXuat { get; set; }


    }
}