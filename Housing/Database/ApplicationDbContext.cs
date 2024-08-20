using Housing.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Housing.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Invoicing> Invoicing { get; set; }

        public DbSet<Items> Items { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<TypePayment> TypePayment { get; set; }

        public DbSet<UserBuyItem> UserBuyItem { get; set; }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
