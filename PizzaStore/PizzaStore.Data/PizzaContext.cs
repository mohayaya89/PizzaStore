using System;
using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Data
{
    public class PizzaContext : DbContext
    {
       public PizzaContext(DbContextOptionsBuilder builder)
        {
            builder.UseInMemoryDatabase("PizzaDB");
        }

        //protected override void OnConfiguring()
        //{

        //}

  
    }
}
