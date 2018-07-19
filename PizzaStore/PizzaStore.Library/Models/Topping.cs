using PizzaStore.Library.Abstracts;
using PizzaStore.Library.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Topping : AIngredient
    {
        public ETopping Name
        {
            get;
            set;
        }

        public Topping()
        {
            Name = ETopping.None;
            Price = 0M;
        }
    }
}