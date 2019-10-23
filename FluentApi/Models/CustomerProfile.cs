using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This represents a tenant's customer. If you need to represent a company as a customer, 
    // use the "TypeCustomer" enum...CustomerType.Commercial
    //-------------------------------------------------------------------------------------------------------
    public partial class CustomerProfile : BaseEntity

    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        public CustomerProfile()
        {
            Id = Guid.NewGuid();
            CustomerAddresses = new HashSet<CustomerAddress>();
            PhoneNumbers = new HashSet<PhoneNumber>();
        }

        public CustomerProfile(string firstName, string lastName, ModelEnums.TypeCustomer type)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            CustomerType = type;
            FullName = DataFormatFunctions.FullName<string>(firstName, lastName);
            CustomerAddresses = new HashSet<CustomerAddress>();
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
        public ModelEnums.TypeCustomer CustomerType { get; set; }

        public virtual CustomerAccount CustomerAccount { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

        //public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPropertyChanged(PropertyChangedEventArgs e)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //        handler(this, e);
        //}

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        //}
    }
}
