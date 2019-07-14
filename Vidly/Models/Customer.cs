using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required] // not null
        [StringLength(255)] // varchar(255)
        public string Name { get; set; }

        // Overrides the input's label
        [Display(Name = "Date of Birth")]
        // DateTime type must be nullable, because it has default a value.
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        // Navigation Property: Loads a Customer's entire MembershipType object
        public MembershipType MembershipType { get; set; }

        // foreign key
        [Display(Name = "Memebership Type")]
        public byte MembershipTypeId { get; set; }
    }
}