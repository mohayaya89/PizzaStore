using PizzaStore.Library.Abstracts;
using PizzaStore.Library.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Size : AIngredient
    {
        public ESize Name
        {
            get;
            set;
        }

        public Size()
        {
            Name = ESize.Medium;
            Price = 0M;

        }
    }
}
