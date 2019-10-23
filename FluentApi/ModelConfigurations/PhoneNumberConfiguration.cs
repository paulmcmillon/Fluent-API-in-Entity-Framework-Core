using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.HasIndex(e => e.CustomerProfileId)
                .HasName("IX_PhoneNumbers_CustomerId");

            builder.HasIndex(e => e.EmployeeProfileId)
                .HasName("IX_PhoneNumbers_EmployeeId");

            builder.Property(e => e.Id).HasDefaultValueSql("(newid())");

            builder.Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.NumberType).IsRequired();

            builder.HasOne(d => d.CustomerProfile)
                .WithMany(p => p.PhoneNumbers)
                .HasForeignKey(d => d.CustomerProfileId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PhoneNumbers_CustomerProfiles");

            builder.HasOne(d => d.EmployeeProfile)
                .WithMany(p => p.PhoneNumbers)
                .HasForeignKey(d => d.EmployeeProfileId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PhoneNumbers_EmployeeProfiles");
        }
    }
}
