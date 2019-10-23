using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.ToTable("Jobs");

            builder.HasIndex(e => new { e.CustomerProfileId, e.CustomerAddressId, e.ShceduledDate })
                .HasName("IX_Job_Customer_CustomerAddress")
                .IsUnique();

            builder.HasIndex(e => new { e.CustomerProfileId })
                .HasName("IX_Job_Customer");

            builder.HasIndex(e => new { e.CustomerAddressId })
                .HasName("IX_Job_CustomerAddress");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.JobCost).HasColumnType("decimal(18, 2)");

            builder.Property(e => e.ShceduledDate).IsRequired();

            builder.HasOne(d => d.CustomerProfile)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.CustomerProfileId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(d => d.CustomerAddress)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.CustomerAddressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
