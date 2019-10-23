using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    public class EmployeeAddressConfiguration : IEntityTypeConfiguration<EmployeeAddress>
    {
        public void Configure(EntityTypeBuilder<EmployeeAddress> builder)
        {
            builder.ToTable("EmployeeAddresses");

            builder.HasIndex(e => e.EmployeeProfileId)
                .HasName("IX_EmployeeAddresses_EmployeeId");

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

            builder.HasOne(d => d.EmployeeProfile)
                .WithMany(p => p.EmployeeAddresses)
                .HasForeignKey(d => d.EmployeeProfileId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
