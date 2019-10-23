using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class JobDateConfiguration : IEntityTypeConfiguration<JobDate>
    {
        public void Configure(EntityTypeBuilder<JobDate> builder)
        {
            builder.ToTable("JobDates");

            builder.HasIndex(e => new { e.JobId })
                .HasName("IX_JobDate_Job");

            builder.HasIndex(e => new { e.ScheduledDate })
                .HasName("IX_JobDate_ScheduledDate");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.JobId).IsRequired();

            builder.Property(e => e.ScheduledDate).IsRequired();

            builder.HasOne(d => d.Job)
                .WithMany(p => p.JobDates)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
