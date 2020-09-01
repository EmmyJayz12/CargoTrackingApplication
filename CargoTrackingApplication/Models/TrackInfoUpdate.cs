using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CargoTrackingApplication.Models
{
    public class TrackInfoUpdate
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Tracking Id is Required")]
        public string TrackingId { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [SqlDefaultValue(Defaultvalue = "getdate()")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Status of the product is Required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Current Location is Required")]
        public string Location { get; set; }
    }
}