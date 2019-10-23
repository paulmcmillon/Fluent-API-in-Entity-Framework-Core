using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class JobActivityConfiguration : IEntityTypeConfiguration<JobActivity>
    {
        public void Configure(EntityTypeBuilder<JobActivity> builder)
        {
            builder.ToTable("JobActivities");

            builder.HasIndex(e => e.ActivityId);

            builder.HasIndex(e => e.JobId);

            builder.Property(e => e.Id).HasDefaultValueSql("(newid())");

            builder.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Activity)
                .WithMany(p => p.JobActivities)
                .HasForeignKey(d => d.ActivityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_JobActivities_Activities");

            builder.HasOne(d => d.Job)
                .WithMany(p => p.JobActivities)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_JobActivities_Jobs");
        }
    }
}
