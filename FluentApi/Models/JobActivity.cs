using System;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This class represents an activity to be performed on a specific job.
    //-------------------------------------------------------------------------------------------------------
    public partial class JobActivity
    {
        public JobActivity() => Id = Guid.NewGuid();

        public JobActivity(Guid jobId, Guid activityId, decimal cost)
        {
            Id = Guid.NewGuid();
            JobId = jobId;
            ActivityId = activityId;
            Cost = cost;
        }

        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid ActivityId { get; set; }
        public decimal Cost { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Job Job { get; set; }
    }
}
