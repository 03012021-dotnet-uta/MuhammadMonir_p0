using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.DAL
{
    public class MyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CustomizedPizza> CustomizedPizzas { get; set; }
        public DbSet<PremadePizza> PremadePizzas { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<PremadePizzaTopping> PremadePizzaTopping { get; set; }
        public DbSet<CustomizedPizzaTopping> CustomizedPizzaTopping { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source = (localdb)\MSSqlLocalDB;Initial Catalog=MyPizzaStoreDB;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PremadePizzaTopping>()
                .HasKey(c =>  new { c.PremadePizzaID, c.ToppingID });

            modelBuilder.Entity<CustomizedPizzaTopping>()
                .HasKey(c => new { c.CustomizedPizzaID, c.ToppingID });


        }
    }
}
