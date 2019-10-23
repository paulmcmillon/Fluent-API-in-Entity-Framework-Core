using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    public class EmployeeProfileConfiguration : IEntityTypeConfiguration<EmployeeProfile>
    {
        public void Configure(EntityTypeBuilder<EmployeeProfile> builder)
        {
            builder.ToTable("EmployeeProfiles");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.FullName).HasMaxLength(40);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.CompensationType).IsRequired();

            //builder.HasOne(d => d.WorkCrew)
            //    .WithOne(p => p.Employees)
            //    .HasForeignKey<EmployeeProfile>(d => d.WorkCrewId);

        }
    }
}
