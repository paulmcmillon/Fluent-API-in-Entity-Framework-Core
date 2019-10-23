using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class CustomerProfileConfiguration : IEntityTypeConfiguration<CustomerProfile>
    {
        public void Configure(EntityTypeBuilder<CustomerProfile> builder)
        {
            builder.ToTable("CustomerProfiles");
                //.HasQueryFilter(x => x.FirstName != "");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.FullName).HasMaxLength(40);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(e => e.IsSoftDeleted)
                .HasDefaultValue(0);
        }
    }
}
