using PizzaStore.Library.Abstracts;
using PizzaStore.Library.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Sauce : AIngredient
    {
        
        public ESauce Name
        {
            get;
            set;
        }

        public Sauce()
        {
            Name = ESauce.Marinara;
            Price = 0M;
        }
    }
}