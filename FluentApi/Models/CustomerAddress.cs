using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This class represents a physical location for a person.
    //-------------------------------------------------------------------------------------------------------
    public partial class CustomerAddress
    {
        public CustomerAddress() => Id = Guid.NewGuid();

        public CustomerAddress(string streetAddress, string city, string state, string postalCode, Guid customerId,
            bool billing = true, bool primary = true)
        {
            Id = Guid.NewGuid();
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;            
            CustomerProfileId = customerId;
            IsBilling = billing;
            IsPrimary = primary;
        }

        public Guid Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public bool IsBilling { get; set; }
        public bool IsPrimary { get; set; }
        public Guid? CustomerProfileId { get; set; }

        public virtual CustomerProfile CustomerProfile { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
