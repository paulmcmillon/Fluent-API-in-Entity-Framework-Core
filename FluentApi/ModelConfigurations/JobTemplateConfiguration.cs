using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class JobTemplateConfiguration : IEntityTypeConfiguration<JobTemplate>
    {
        void IEntityTypeConfiguration<JobTemplate>.Configure(EntityTypeBuilder<JobTemplate> builder)
        {
            builder.ToTable("JobTemplates");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.DefaultCost).HasColumnType("decimal(18, 2)")
                                .HasDefaultValueSql("((0))");

            builder.Property(e => e.DefaultPrice).HasColumnType("decimal(18, 2)")
                                .HasDefaultValueSql("((0))");
        }
    }
}
