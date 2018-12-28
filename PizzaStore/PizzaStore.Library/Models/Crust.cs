using PizzaStore.Library.Abstracts;
using PizzaStore.Library.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Crust : AIngredient
    {
        public ECrust Name
        {
            get;
            set;
        }
 
        public Crust()
        {
            Name = ECrust.Thin;
            Price = 0M;
        }
            

    }
}
