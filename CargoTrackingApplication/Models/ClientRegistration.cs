using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CargoTrackingApplication.Models
{
    public class ClientRegistration
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Shipper First Name is Required")]
        public string ShippersFirstName { get; set; }

        [Required(ErrorMessage = "Shippers Last Name is Required")]
        public string ShippersLastName { get; set; }

        [Required(ErrorMessage = "")]
        public string ShippersPhone { get; set; }

        [Required(ErrorMessage = "Shippers Country Name is Required")]
        public string ShippersCountryName { get; set; }

        [Required(ErrorMessage = "Receivers First Name is Required")]
        public string ReceiversFirstName { get; set; }

        [Required(ErrorMessage = "Receivers Last Name is Required")]
        public string ReceiversLastName { get; set; }

        [Required(ErrorMessage = "")]
        public string ReceiversPhone { get; set; }

        [Required(ErrorMessage = "Receivers Email is Required")]
        public string ReceiversEmail { get; set; }

        [Required(ErrorMessage = "Receivers Country Name is Required")]
        public string ReceiversCountryName { get; set; }

        [Required(ErrorMessage = "TrackingId is Required")]
        public string TrackingId { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "weight is Required")]
        public string weight { get; set; }

        [Required(ErrorMessage = "Invoice is Required")]
        public string Invoice { get; set; }

        [Required(ErrorMessage = "Booking Mode is Required")]
        public string BookingMode { get; set; }

        [Required(ErrorMessage = "Total Freight is Required")]
        public string TotalFreight { get; set; }

        [Required(ErrorMessage = "Delivery Mode is Required")]
        public string DeliveryMode { get; set; }

        [Required(ErrorMessage = "PickupDate is Required")]
        public string PickupDate { get; set; }

        [Required(ErrorMessage = "PickupTime is Required")]
        public string PickTime { get; set; }

        [Required(ErrorMessage = "Delivery Status is Required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Comment is Required")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Receivers Address is Required")]
        public string ReceiversAddress { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [SqlDefaultValue(Defaultvalue = "getdate()")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}