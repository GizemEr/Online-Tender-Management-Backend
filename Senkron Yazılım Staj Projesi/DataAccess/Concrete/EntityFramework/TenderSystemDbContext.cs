using Microsoft.EntityFrameworkCore;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.DataAccess.Concrete.EntityFramework
{
    public class TenderSystemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2SV2MHL; 
                                        Database=TenderSystem; 
                                        Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().ToTable("Admins");
            modelBuilder.Entity<Client>().ToTable("Clients");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        //public DbSet<Admin> Admins { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Client> Clients { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Tender> Tenders { get; set; }
        public DbSet<TenderStatus> TenderStatuses { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
