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
        public string MaUser{ get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is require")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username is require")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is require")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password is require")]
        public string ConfirmPassword { get; set; }
    }
}