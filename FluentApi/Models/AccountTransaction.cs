using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    public partial class AccountTransaction
    {
        private AccountTransaction() { }

        public AccountTransaction(Guid customerAccountId, int transactionType, decimal ammount)
        {
            Id = Guid.NewGuid();
            CustomerAccountId = customerAccountId;
            TransactionType = transactionType;
            Ammount = ammount;
        }

        public Guid Id { get; set; }
        public Guid CustomerAccountId { get; set; }
        public int TransactionType { get; set; }
        public decimal Ammount { get; set; }

        public virtual CustomerAccount CustomerAccount { get; set; }
    }
}
