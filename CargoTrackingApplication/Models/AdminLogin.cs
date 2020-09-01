using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CargoTrackingApplication.Models
{
    public class AdminLogin
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string State { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Your Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }

        [Compare("Password", ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [SqlDefaultValue(Defaultvalue = "getdate()")]
        public DateTime DataRegistered { get; set; } = DateTime.Now;
    }
}