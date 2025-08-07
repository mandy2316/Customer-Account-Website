using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }
        [Required]
        [Display(Name = "Check in ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckIn { get; set; }
        [Required]
        [Display(Name = "Check out ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckOut { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Cost{ get; set; }
       
        public Room TheRoom { get; set; }
        public Customer TheCustomer { get; set; }

    }
}
