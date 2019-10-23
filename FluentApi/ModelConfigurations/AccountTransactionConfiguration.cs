using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroundzKeeper.Data.EntityConfiguration
{
    //-------------------------------------------------------------------------------------------------------
    // Entity Framework Core Fluent API configuration for model class.  Use this class instead of model
    // anotations.
    //-------------------------------------------------------------------------------------------------------
    public class AccountTransactionConfiguration : IEntityTypeConfiguration<AccountTransaction>
    {
        public void Configure(EntityTypeBuilder<AccountTransaction> builder)
        {
            builder.ToTable("AccountTransactions");

            builder.HasIndex(e => e.CustomerAccountId);

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Ammount).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.CustomerAccount)
                .WithMany(p => p.AccountTransactions)
                .HasForeignKey(d => d.CustomerAccountId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
