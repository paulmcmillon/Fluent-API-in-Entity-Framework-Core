using System;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This class is used to create an intermediate table for relating activities to a job template.
    //-------------------------------------------------------------------------------------------------------
    public partial class JobTemplateActivity
    {
        private JobTemplateActivity() { }

        public JobTemplateActivity(Guid jobTemplateId, Guid activityId)
        {
            JobTemplateId = jobTemplateId;
            ActivityId = activityId;
        }

        public Guid JobTemplateId { get; set; }
        public Guid ActivityId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual JobTemplate JobTemplate { get; set; }
    }
}
