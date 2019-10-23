using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class JobTemplateActivityConfiguration : IEntityTypeConfiguration<JobTemplateActivity>
    {
        public void Configure(EntityTypeBuilder<JobTemplateActivity> builder)
        {
            builder.ToTable("JobTemplateActivities");

            builder.HasKey(e => new { e.JobTemplateId, e.ActivityId });

            builder.HasIndex(e => e.ActivityId);

            builder.HasOne(d => d.Activity)
                .WithMany(p => p.JobTemplateActivities)
                .HasForeignKey(d => d.ActivityId);

            builder.HasOne(d => d.JobTemplate)
                .WithMany(p => p.JobTemplateActivities)
                .HasForeignKey(d => d.JobTemplateId);
        }
    }
}
