using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices");

            builder.HasIndex(e => e.CustomerProfileId);

            builder.HasIndex(e => e.JobId);

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Amount)
                .HasColumnType("decimal(18, 2)")
                .HasDefaultValueSql("((0))");

            builder.Property(e => e.InvoiceNumber).HasMaxLength(10);

            builder.HasOne(d => d.Job)
                .WithMany(p => p.Invoice)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_Invoice_Jobs");

            builder.HasOne(d => d.CustomerProfile)
                .WithMany(p => p.Invoices)
                .HasForeignKey(c => c.CustomerProfileId)
                .HasConstraintName("FK_Invoice_Customer");
        }
    }
}
