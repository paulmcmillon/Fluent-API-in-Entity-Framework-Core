using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    public class CustomerAccountConfiguration : IEntityTypeConfiguration<CustomerAccount>
    {
        public void Configure(EntityTypeBuilder<CustomerAccount> builder)
        {
            builder.ToTable("CustomerAccounts");

            builder.HasIndex(e => e.CustomerProfileId)
                .IsUnique()
                .HasName("IX_CustomerAccount_CustomerId");

            builder.Property(e => e.Id).HasDefaultValueSql("(newid())");

            builder.Property(e => e.AccountBalance).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.CustomerProfile)
                .WithOne(p => p.CustomerAccount)
                .HasForeignKey<CustomerAccount>(d => d.CustomerProfileId);
        }
    }
}
