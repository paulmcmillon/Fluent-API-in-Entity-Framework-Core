using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    public partial class Invoice
    {
        private Invoice() => Id = Guid.NewGuid();

        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; }
        public Guid? JobId { get; set; }
        public Guid? CustomerProfileId { get; set; }
        public decimal? Amount { get; set; }
        public DateTimeOffset? InvoiceDate { get; set; }
        public DateTimeOffset? PaidDate { get; set; }

        public virtual Job Job { get; set; }
        public virtual CustomerProfile CustomerProfile { get; set; }
    }
}
