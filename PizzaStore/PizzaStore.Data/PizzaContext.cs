using Microsoft.EntityFrameworkCore;
using PizzaStore.Library.Models;

namespace PizzaStore.Data

{
    public class PizzaContext : DbContext
    {
        public DbSet<User> Users
        {
            get;
            set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) // going to contain the writer 
        {
            builder.UseInMemoryDatabase("PizzaDB");
        }
    }
}