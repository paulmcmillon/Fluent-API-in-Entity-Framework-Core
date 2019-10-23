using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This class represents a customer's billing account.
    //-------------------------------------------------------------------------------------------------------
    public partial class CustomerAccount
    {
        private CustomerAccount() => AccountTransactions = new HashSet<AccountTransaction>();

        public CustomerAccount(Guid customerId)
        {
            Id = Guid.NewGuid();
            AccountBalance = 0.00m;
            CustomerProfileId = customerId;
            AccountTransactions = new HashSet<AccountTransaction>();
        }

        public Guid Id { get; set; }
        public decimal AccountBalance { get; set; }
        public Guid CustomerProfileId { get; set; }

        public virtual CustomerProfile CustomerProfile { get; set; }
        public virtual ICollection<AccountTransaction> AccountTransactions { get; set; }
    }
}
