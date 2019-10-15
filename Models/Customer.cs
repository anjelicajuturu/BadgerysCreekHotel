using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BadgerysCreekHotel.Models

 public class Customer
    {
        [Required, Key]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [EmailAddress]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Email { get; set; }
        [Display(Name = "FamilyName")]
        [RegularExpression("^[a-zA-Z '-]*$")]
        [MinLength(2), MaxLength(20)]
        public string FamilyName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z '-]*$")]
        [MinLength(2), MaxLength(20)]
        public string GivenName { get; set; }
        [Required]
        [RegularExpression(@"^((?!(9))[0-9]{4})$", ErrorMessage = "Please enter a valid postcode.")]
        public string PostalCode { get; set; }
        public ICollection<Booking> TheBookings { get; set; }
    }
}
