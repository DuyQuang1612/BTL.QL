using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMQLSQA.Models
{ 
    [Table("Account")]
    public class Account
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}