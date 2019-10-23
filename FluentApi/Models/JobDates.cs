using System;
using System.Collections.Generic;
using System.Text;

namespace GroundzKeeper.Data
{
    public class JobDate
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public DateTimeOffset ScheduledDate { get; set; }

        public virtual Job Job { get; set; }
    }
}
