using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{   [Table("Account")]
    public class Account
    {   [Key]
        [Required(ErrorMessage = "Username is require")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is require")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}