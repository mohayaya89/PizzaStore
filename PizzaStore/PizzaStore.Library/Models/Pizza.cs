using PizzaStore.Library.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Pizza
    {
        #region Pizza Properties

        private static readonly Dictionary<ESize, decimal> _sizePricing = new Dictionary<ESize, decimal>
        {
            { ESize.Small, 5M },
            { ESize.Medium, 10M },
            { ESize.Large, 15M },
            { ESize.ExtraLarge, 20M }
        };

        public List<Topping> Toppings
        {
            get;
            set;
        }
        public Crust Crust
        {
            get;
            set;
        }
        public Size Size
        {
            get;
            set;
        }
        public List<Cheese> Cheeses
        {
            get;
            set;
        }
        public Sauce Sauce
        {
            get;
            set;
        }
        public decimal Cost
        {
            get;
            set;
        }
        #endregion

        public Pizza(ESize size = ESize.Medium)
        {
            Size = new Size()
            {
                Name = size,
                Price = _sizePricing[size]
            };
        }
    }
}
