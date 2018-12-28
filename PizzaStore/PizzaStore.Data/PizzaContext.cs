using Microsoft.EntityFrameworkCore;
using PizzaStore.Library.Models;

namespace PizzaStore.Data

{
    public class PizzaContext : DbContext
    {
        #region Properties

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:pizzastore89.database.windows.net,1433;Initial Catalog=pizzadb;Persist Security Info=False;User ID=sqladmin;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey("UserId");
            modelBuilder.Entity<Order>().HasKey("OrderId");
            modelBuilder.Entity<Pizza>().HasKey("PizzaId");

            modelBuilder.Entity<Cheese>().HasKey("IngredientId");
            modelBuilder.Entity<Crust>().HasKey("IngredientId");
            modelBuilder.Entity<Sauce>().HasKey("IngredientId");
            modelBuilder.Entity<Topping>().HasKey("IngredientId");
            modelBuilder.Entity<Size>().HasKey("IngredientId");
            
        }
    }
}