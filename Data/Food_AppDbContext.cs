using Microsoft.EntityFrameworkCore;
using Food_Ordering_ApI.Models;
namespace Food_Ordering_ApI.Data
{
    public class Food_AppDbContext:DbContext
    {
        public Food_AppDbContext()
        {

        }

        public Food_AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DeliveryPartner> DeliveryPartners {  get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<UserRole>().HasData(new UserRole {UserRole_Id = 1,role=Role.ADMIN} ,new UserRole { UserRole_Id=2,role=Role.CUSTOMER});
        }



    }
}
