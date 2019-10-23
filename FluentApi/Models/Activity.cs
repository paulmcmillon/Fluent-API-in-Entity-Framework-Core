using System;
using System.Collections.Generic;

namespace GroundzKeeper.Data
{
    //-------------------------------------------------------------------------------------------------------
    // This class represents a service or activity performed by a tenant for their customers.
    //-------------------------------------------------------------------------------------------------------
    public partial class Activity
    {
        public Activity()
        {
            Id = Guid.NewGuid();
            JobActivities = new HashSet<JobActivity>();
            JobTemplateActivities = new HashSet<JobTemplateActivity>();
        }

        public Activity(string name, string description, ModelEnums.UnitOfMeasure unitOfMeasure, 
            decimal defaultCost = 0, decimal defaultPrice = 0)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            DefaultUom = unitOfMeasure;
            DefaultCost = defaultCost;
            DefualtPrice = defaultPrice;
            JobActivities = new HashSet<JobActivity>();
            JobTemplateActivities = new HashSet<JobTemplateActivity>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ModelEnums.UnitOfMeasure DefaultUom { get; set; }
        public decimal DefaultCost { get; set; }
        public decimal DefualtPrice { get; set; }
        public bool IsSelected { get; set; }

        public virtual ICollection<JobActivity> JobActivities { get; set; }
        public virtual ICollection<JobTemplateActivity> JobTemplateActivities { get; set; }
    }
}
