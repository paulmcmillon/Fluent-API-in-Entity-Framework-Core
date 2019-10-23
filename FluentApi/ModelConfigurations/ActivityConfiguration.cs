using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.DefaultCost).HasColumnType("decimal(18, 2)")
                                .HasDefaultValueSql("((0))");

            builder.Property(e => e.DefualtPrice).HasColumnType("decimal(18, 2)")
                                .HasDefaultValueSql("((0))");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
