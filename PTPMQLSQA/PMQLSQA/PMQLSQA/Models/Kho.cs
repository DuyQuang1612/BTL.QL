using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PMQLSQA.Models
{    [Table("Kho")]
    public class Kho
    {   [Key]
        public string MatHang { get; set; }
        [DataType(DataType.Date)]
        public DateTime NgaySanXuat { get; set; }
        public string NguonGoc { get; set; }
        public int SoLuongSanPham { get; set; }
    }
}