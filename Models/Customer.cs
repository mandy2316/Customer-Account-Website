using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Customer
    {
        [Key, Required]
        [DataType(DataType.EmailAddress)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email{ get; set; }
        [Required]
        [Display(Name = "Surname")]
        [RegularExpression(@"[A-Za-z,-]{2-20}$")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Givenname")]
        [RegularExpression(@"[A-Za-z,-]{2-20}$")]
        public string Givenname { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        [RegularExpression(@"[1-9]{4}", ErrorMessage = "exactly 4 digits")]
        public string Postcode { get; set; }
        public ICollection<Booking> TheBookings { get; set; }
    }
}
