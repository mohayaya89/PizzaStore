using PizzaStore.Library.Abstracts;
using PizzaStore.Library.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Models
{
    public class Pizza : A_ID
    {

        #region Pizza Properties   
        private static readonly Dictionary<ESize, decimal> _sizePricing = new Dictionary<ESize, decimal>
        {
            { ESize.Small, 5M },
            { ESize.Medium, 10M },
            { ESize.Large, 15M },
            { ESize.ExtraLarge, 20M }
        };

        private static readonly Dictionary<ETopping, decimal> _toppingPricing = new Dictionary<ETopping, decimal>
        {
            { ETopping.BananaPeppers, 3M },
            { ETopping.Chicken, 5M },
            { ETopping.GreenPeppers, 13M },
            { ETopping.Hams, 9M },
            { ETopping.Mushrooms, 11M },
            { ETopping.None, 0M },
            { ETopping.Onion, 4M },
            { ETopping.Pepperoni, 19M },
            { ETopping.Pineapple, 17M }
        };

        private static readonly Dictionary<ESauce, decimal> _saucePricing = new Dictionary<ESauce, decimal>
        {
            { ESauce.Alfredo, 16M },
            { ESauce.Barbecue, 17.5M },
            { ESauce.Marinara, 18M },
            { ESauce.Pesto, 18.5M }
        };

        private static readonly Dictionary<ECrust, decimal> _crustPricing = new Dictionary<ECrust, decimal>
        {
            { ECrust.DeepDish, 20M },
            { ECrust.Neopolitan, 21M },
            { ECrust.NewYorkStyle, 22M },
            { ECrust.Stuffed, 23M },
            { ECrust.Thin, 24M }
        };

        private static readonly Dictionary<ECheese, decimal> _cheesePricing = new Dictionary<ECheese, decimal>
        {
            { ECheese.Chedder, 20.5M },
            { ECheese.Mozarella, 21.5M },
            { ECheese.Parmesan, 22.5M }
        };

        public List<Topping> Toppings
        {
            get;
            set;
        }
        public List<Crust> Crust
        {
            get;
            set;
        }
        public List<Size> Size
        {
            get;
            set;
        }
        public List<Cheese> Cheeses
        {
            get;
            set;
        }
        public List<Sauce> Sauce
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
     
        #region Contructor
        public Pizza()
        {
            Toppings = new List<Topping>();
            Cheeses = new List<Cheese>();
            Size = new List<Size>();
            Crust = new List<Crust>();
            Sauce = new List<Sauce>(); 
        }
        #endregion


        public void AddTopping(ETopping topping)
        {
            Toppings.Add(new Topping { Name = topping });
        }

        public void AddCrust(ECrust crust)
        {
            Crust.Add(new Crust { Name = crust });
        }

        public void AddSauce(ESauce sauce)
        {
            Sauce.Add(new Sauce { Name = sauce });
        }

        public void AddCheese(ECheese cheese)
        {
            Cheeses.Add(new Cheese { Name = cheese });
        }

        public void AddSize(ESize size)
        {
            Size.Add(new Size { Name = size });
        }

    }
}
