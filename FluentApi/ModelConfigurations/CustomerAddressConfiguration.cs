using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.ToTable("CustomerAddresses");

            builder.HasIndex(e => e.CustomerProfileId)
                .HasName("IX_CustomerAddresses_CustomerId");

            builder.Property(e => e.Id).HasDefaultValueSql("(newid())");

            builder.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.StreetAddress)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.IsBilling)
                .IsRequired();

            builder.Property(e => e.IsPrimary)
                .IsRequired();

            builder.Property(e => e.CustomerProfileId)
                .IsRequired();

            builder.HasOne(d => d.CustomerProfile)
                .WithMany(p => p.CustomerAddresses)
                .HasForeignKey(d => d.CustomerProfileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
