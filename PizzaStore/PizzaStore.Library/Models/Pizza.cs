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

        public List<ETopping> Toppings
        {
            get;
            set;
        }
        public List<ECrust> Crust
        {
            get;
            set;
        }
        public List<ESize> Size
        {
            get;
            set;
        }
        public List<ECheese> Cheeses
        {
            get;
            set;
        }
        public List<ESauce> Sauce
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

        //public Pizza(ESize size = ESize.Medium)
        //{
        //    Size = new Size()
        //    {
        //        Name = size,
        //        Price = _sizePricing[size]
        //    };
        //}
        #region Contructor
        public Pizza()
        {
            Toppings = new List<ETopping>();
            Cheeses = new List<ECheese>();
            Size = new List<ESize>();
            Crust = new List<ECrust>();
            Sauce = new List<ESauce>();
            
        }
        #endregion


        public void AddTopping(ETopping topping)
        {
            Toppings.Add(topping);
        }

        public void AddCrust(ECrust crust)
        {
            Crust.Add(crust);
        }

        public void AddSauce(ESauce sauce)
        {
            Sauce.Add(sauce);
        }

        public void AddCheese(ECheese cheese)
        {
            Cheeses.Add(cheese);
        }

        public void AddSize(ESize size)
        {
            Size.Add(size);
        }

       

        
    }
}
