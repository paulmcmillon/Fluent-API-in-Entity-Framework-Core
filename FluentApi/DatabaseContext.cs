using GroundzKeeper.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace GroundzKeeper.Data
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountTransaction> AccountTransactions { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerProfile> CustomerProfiles { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<JobActivity> JobActivities { get; set; }
        public virtual DbSet<JobTemplateActivity> JobTemplateActivities { get; set; }
        public virtual DbSet<JobTemplate> JobTemplates { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=[ServerName];Initial Catalog=[DatabaseName];Integrated Security=True;")
                .ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.ApplyConfiguration(new CustomerProfileConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerAddressConfiguration());
            modelBuilder.ApplyConfiguration(new AccountTransactionConfiguration());
            modelBuilder.ApplyConfiguration(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerAccountConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeAddressConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProfileConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceConfiguration());
            modelBuilder.ApplyConfiguration(new JobActivityConfiguration());
            modelBuilder.ApplyConfiguration(new JobTemplateActivityConfiguration());
            modelBuilder.ApplyConfiguration(new JobTemplateConfiguration());
            modelBuilder.ApplyConfiguration(new JobConfiguration());
            modelBuilder.ApplyConfiguration(new PhoneNumberConfiguration());

            // CONFIGURE GLOBAL ENTITY FILTERS
            //modelBuilder.Entity<CustomerProfile>().HasQueryFilter(b => EF.Property<string>(b, "TenantId") == _tenantId);
            //modelBuilder.Entity<CustomerProfile>().HasQueryFilter(c => !c.IsSoftDeleted);
        }
    }
}
