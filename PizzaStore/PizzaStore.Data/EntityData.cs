using PizzaStore.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaStore.Data
{
    public class EntityData
    {
        private static PizzaContext context = new PizzaContext();

        public EntityData()
        {
            
        }
        
        public void Save(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User Read(int userId)
        {
            return context.Users.SingleOrDefault(u => u.UserId == userId);
        }

        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
    }
}
