using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This class represents a physical location for a person.
    //-------------------------------------------------------------------------------------------------------
    public partial class EmployeeAddress
    {
        public EmployeeAddress() => Id = Guid.NewGuid();

        public EmployeeAddress(string streetAddress, string city, string state, string postalCode, Guid customerId,
            bool billing = true, bool primary = true)
        {
            Id = Guid.NewGuid();
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
            EmployeeProfileId = customerId;
        }

        public Guid Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public Guid? EmployeeProfileId { get; set; }

        public virtual EmployeeProfile EmployeeProfile { get; set; }
    }
}
