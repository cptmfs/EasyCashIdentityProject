using EasyCashIdentityProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccess.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EasyCashDb;Trusted_Connection=True");
        }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }
        public DbSet<ElectricBill> ElectricBills{ get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<CustomerAccountProcess>()
                .HasOne(x=> x.SenderCustomer)
                .WithMany(y=> y.CustomerSender)
                .HasForeignKey(z=>z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

			builder.Entity<CustomerAccountProcess>()
				 .HasOne(x => x.ReceiverCustomer)
				 .WithMany(y => y.CustomerReceiver)
				 .HasForeignKey(z => z.ReceiverID)
				 .OnDelete(DeleteBehavior.ClientSetNull);
            base.OnModelCreating(builder);
		}
	}
}
