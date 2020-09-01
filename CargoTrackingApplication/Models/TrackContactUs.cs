using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CargoTrackingApplication.Models
{
    public class TrackContactUs
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Subject of the message Required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is Required")]
        public string Message { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [SqlDefaultValue(Defaultvalue = "getdate()")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}