using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        // Navigation Property: Loads a Customer's entire MembershipType object
        public MembershipType MembershipType { get; set; }

        // foreign key
        public byte MembershipTypeId { get; set; }
    }
}