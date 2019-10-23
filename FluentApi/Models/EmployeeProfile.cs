using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This class represents an employee that works for a tenant.
    //-------------------------------------------------------------------------------------------------------
    public partial class EmployeeProfile
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        public EmployeeProfile()
        {
            Id = Guid.NewGuid();
            CompensationRate = 0;
            EmployeeAddresses = new HashSet<EmployeeAddress>();
            PhoneNumbers = new HashSet<PhoneNumber>();
        }

        public EmployeeProfile(string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            FullName = DataFormatFunctions.FullName<string>(firstName, lastName);
            CompensationRate = 0;
            EmployeeAddresses = new HashSet<EmployeeAddress>();
            PhoneNumbers = new HashSet<PhoneNumber>();
        }

        public Guid Id { get; set; }
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                _fullName = value + " " + _lastName; ;
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                _fullName = _firstName + " " + value;
            }
        }
        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }
        public string Email { get; set; }

        public ModelEnums.TypeCompensation CompensationType { get; set; }
        public int? WorkCrewId { get; set; }
        public decimal? CompensationRate { get; set; }

        public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
