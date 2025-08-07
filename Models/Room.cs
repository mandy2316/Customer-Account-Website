using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Room
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[G123]$", ErrorMessage = "only 4 level,G,1,2,3")]
        public string Level { get; set; }
        [Required]
        [RegularExpression(@"^[1-3]$", ErrorMessage = "one room can only put 3 beds")]
        public int BedCount { get; set; }
        [Required]
        [Range(50, 300)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public ICollection<Booking> TheBookings { get; set; }
    }
}
