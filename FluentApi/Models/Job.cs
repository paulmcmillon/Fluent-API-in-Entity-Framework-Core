using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    public partial class Job
    {
        public Job()
        {
            Id = Guid.NewGuid();
            IsComplete = false;
            JobCost = 0.00m;
            Invoice = new HashSet<Invoice>();
            JobActivities = new HashSet<JobActivity>();
        }

        public Guid Id { get; set; }
        public Guid CustomerProfileId { get; set; }
        public Guid CustomerAddressId { get; set; }
        public decimal JobCost { get; set; }
        public bool IsComplete { get; set; }
        public DateTimeOffset ShceduledDate { get; set; }
        public DateTimeOffset? CompletionDate { get; set; }
        public bool IsReoccurring { get; set; }

        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<JobActivity> JobActivities { get; set; }
        public virtual ICollection<JobDate> JobDates { get; set; }
        public virtual CustomerProfile CustomerProfile { get; set; }
        public virtual CustomerAddress CustomerAddress { get; set; }
    }
}
