using PizzaStore.Library.Abstracts;
using PizzaStore.Library.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Cheese : AIngredient
    {
        
        public ECheese Name
        {
            get;
            set;
        }

        public Cheese()
        {
            Name = ECheese.Chedder;
            Price = 0M;
        }
    }

    
}
