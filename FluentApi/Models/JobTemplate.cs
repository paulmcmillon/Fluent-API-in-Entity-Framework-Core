using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    public partial class JobTemplate
    {
        //-------------------------------------------------------------------------------------------------------
        // This class represents a collection of activities that can be applied to a job as a single unit.
        //-------------------------------------------------------------------------------------------------------
        public JobTemplate()
        {
            Id = Guid.NewGuid();
            JobTemplateActivities = new HashSet<JobTemplateActivity>();
        }

        public JobTemplate(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            JobTemplateActivities = new HashSet<JobTemplateActivity>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Decsription { get; set; }
        public decimal DefaultCost { get; set; }
        public decimal DefaultPrice { get; set; }

        public virtual ICollection<JobTemplateActivity> JobTemplateActivities { get; set; }
    }
}
