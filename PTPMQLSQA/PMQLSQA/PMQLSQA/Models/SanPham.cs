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
        public string TenSanPham { get; set; }
        public int GiaSanPham { get; set; }
        public int SoLuong { get; set; }
        public string XuatSu { get; set; }

    }
}