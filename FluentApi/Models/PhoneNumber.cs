using System;
//using System.ComponentModel.DataAnnotations;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This class represents a phone number.
    //-------------------------------------------------------------------------------------------------------
    public partial class PhoneNumber
    {
        public PhoneNumber() { }

        public PhoneNumber(string number, ModelEnums.TypePhoneNumber type, Guid? customerId, Guid? employeeId)
        {
            Id = Guid.NewGuid();
            Number = number;
            NumberType = type;
            CustomerProfileId = customerId ?? null;
            EmployeeProfileId = employeeId ?? null;
        }

        public Guid Id { get; set; }
        //[DisplayFormat(DataFormatString = "{0:###-###-####}")]
        public string Number { get; set; }
        public ModelEnums.TypePhoneNumber NumberType { get; set; }
        public Guid? CustomerProfileId { get; set; }
        public Guid? EmployeeProfileId { get; set; }

        public virtual CustomerProfile CustomerProfile { get; set; }
        public virtual EmployeeProfile EmployeeProfile { get; set; }
    }
}
